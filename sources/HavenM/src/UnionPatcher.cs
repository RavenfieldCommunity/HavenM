using HarmonyLib;
using System;
using HavenM.Patcher;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace HavenM {
public static class UnionPatch
{
    public static void Patch()
    {
        Main.DebugLog("Patch All!");
        try { Harmony.CreateAndPatchAll(typeof(GameManager_Start)); }  catch (Exception e) { Main.ErrorLog(e.ToString()); }
        try { Harmony.CreateAndPatchAll(typeof(AiActorController_Patch)); }  catch (Exception e) { Main.ErrorLog(e.ToString()); }
    }

    public static Harmony _temp = null; 

}
}

namespace HavenM.Patcher {
[HarmonyPatch(typeof(GameManager), "Start")]
class GameManager_Start
{
    public static void Postfix () { }//NotchInputWrapper.InitInput(); }
}

/*
public class ParentClass_Patch
{

    
    [HarmonyPatch(typeof(AiActorController),"Awake")]

    [HarmonyPrefix]
    static void Prefix(ref AiActorController __instance)
    {
        __instance.gameObject.AddComponent<AiActorControllerDataClient>();
    }


}*/

public static class AiActorController_Patch
{
    public class AiActorControllerData
    {
        public float stationaryTime;
        public Coroutine checkMovementCoroutine;
        public Coroutine checkUnderwaterStationaryCoroutine;
        public float targetDeathTime;
        public float overkillDuration;
        public bool isTargetObstructed;
        public TimedAction HaltCooldownAction;
        public bool isHelicopterStuck;
        public bool isVehicleSunk;
        public Vector4 previousInput;
        public float smoothingFactor;
        public float flightTargetSmoothingFactor;
        public TimedAction haltForTargetAction;
        public TimedAction grenadeThrowingAction;
        public TimedAction GrenadeThrowingCooldownAction;
        public TimedAction findCoverAction;
        public TimedAction TakingFireAlertAction;
        public TimedAction TakingFireAlertCoolDown;
        public TimedAction SuppressionAction;
        public TimedAction SuppressionCooldownAction;
        public TimedAction haltCooldownAction2;
        public bool canSeeTarget;
    }

    public static Dictionary<int,AiActorControllerData> data = new Dictionary<int,AiActorControllerData>();

    [HarmonyPatch(typeof(AiActorController),"Awake")]
    [HarmonyPostfix]
    static void Awake(AiActorController __instance)
    {
        if ( !data.ContainsKey(__instance.actor.actorIndex) ) data.Add(__instance.actor.actorIndex,new AiActorControllerData(){});
    }

    //2/22/25
    [HarmonyPatch(typeof(AiActorController),"AiVehicle")]
    [HarmonyPostfix]
    static void AiVehicle(AiActorController __instance,AiActorController ___isSeated,ref IEnumerator __result, bool ___isDriver,ref TimedAction ___countermeasureReactAction,ref TimedAction ___vehicleIsNotStuckAction,ref TimedAction ___forceReverseAction,ref TimedAction ___helicopterTakeoffAction)
    {
        if (!(___isSeated && __instance.actor.seat.vehicle != null && ___isDriver)) return;
        var n = __instance.actor.actorIndex;
        var vehicle = __instance.actor.seat.vehicle;
        Type vehicleType = vehicle.GetType();
        if (___isDriver && vehicle.GetHealthRatio() < 0.5f && __instance.IsTakingFire() && !__instance.HasTarget() && !vehicle.IsAircraft())
		{
			___countermeasureReactAction.StartLifetime(UnityEngine.Random.Range(5f, 8f));
		}
        if (__instance.isSquadLeader && !vehicle.IsAmphibious() && !vehicle.IsWatercraft())
		{
			if (data[n].checkUnderwaterStationaryCoroutine == null && __instance.targetVehicle.IsInWater())
			{
				data[n].checkUnderwaterStationaryCoroutine = __instance.StartCoroutine("CheckIfUnderwaterStationaryForTime");
			}
			else if (data[n].checkUnderwaterStationaryCoroutine != null)
			{
				__instance.StopCoroutine(data[n].checkUnderwaterStationaryCoroutine);
				data[n].checkUnderwaterStationaryCoroutine = null;
			}
		}
		if (vehicle.IsAircraft() && ___helicopterTakeoffAction.TrueDone() && !__instance.squad.pickingUpPassengers)
		{
			Vector3 vector2 = __instance.actor.seat.vehicle.Velocity();
			if (Mathf.Abs(vector2.y) < 0.1f && Mathf.Abs(vector2.z) < 0.1f)
			{
				if (data[n].checkMovementCoroutine == null)
				{
					data[n].checkMovementCoroutine = __instance.StartCoroutine("CheckIfStationaryForTime");
				}
			}
			else if (data[n].checkMovementCoroutine != null)
			{
				__instance.StopCoroutine(data[n].checkMovementCoroutine);
				data[n].checkMovementCoroutine = null;
			}
		}

        if (__instance.squad == null || !__instance.squad.pickingUpPassengers)
		{
            if (___vehicleIsNotStuckAction.TrueDone())
			{
                if (vehicleType == typeof(Boat) && vehicle.IsWatercraft() && vehicle.aiType != Vehicle.AiType.Roam && !vehicle.IsInWater()){}
                else {
                    float reverseAcceleration = (vehicle as ArcadeCar).reverseAcceleration;
					float num = 10f / reverseAcceleration;
					___forceReverseAction.StartLifetime(Mathf.Clamp(num, 1.8f, num));
                }
            }
        }

    }
}

}