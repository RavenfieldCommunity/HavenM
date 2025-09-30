# HavenM Changelog
**Update 9/30/2025**

- Changed target-seeking missile: when the target uses countermeasures, the missile will just move forward to its last tracking position, only pulled down slightly by gravity.
- Added Laser Guided Missile to the list of weapons that make AI actors stop and fire (this one uses a point-target system, not a normal lock-on — I missed it before because I thought it was wire-guided).
- Reworked helicopter hovering: if a heli is hovering above 80 m, it will now lower its height automatically.
- Removed rocket-lobbing for helicopters (artillery already covers that role, and the heli wasn’t moving forward enough anyway).
- Took helicopters out of the target-sharing system — now only mortars and airplanes can receive shared targets.

**Update 9/25/2025**
- Updated to the latest version.
- Tweaked target seeking missile behavior to be better.
- Tweaked track vehicle Hull toward target behavior so they don't do the same for fast moving air target like airplane.

**Update 9/24/2025**
- Updated to the latest version.
- Tweaked Ai airplane behavior and removed certain clamps, allowing airplane to commit to attack run with less constrain when targeting airplane target.

**Update 9/21/2025**
- Tweaked **Specops helicopter patrol spawn locations** for better mission flow.  
- Changed **AI squad target sharing**: no more than 2 squad members can focus on the same target at once, preventing tunnel vision.  
- Added new **aircraft attack run targeting**:  
  - If the target is within the reach of the aircraft’s active weapon (based on velocity/gravity), the aircraft can now perform very long-range attack runs. (Example : Helicopter rocket lobbing/lofting)
  - Excludes guided missiles and target-seeking missile types.  
- Tweaked **aircraft unarmored checks**:  
  - Helicopters and airplanes are now separated into their own categories.  
  - Slow-moving helicopters under 30m altitude are treated as unarmored ground vehicles.  
  - Slow-moving airplanes  that are low to the ground are also treated as unarmored ground vehicles.  
  - This separation prevents ground vehicles from incorrectly targeting airplanes.  

**Update 9/16/2025**
- Improved specops patrol spawning location.

**Update 9/13/2025**
- Updated to the latest version
- Added a new behavior which allow all Ai in the same squad to share target with each other as long as they are not taking fire, Improving the infantry squad behavior( work for both vehicle and no foot, as long as they are in a squad).

**Update 9/11/2025**
- Updated to the latest update.

**Update 9/9/2025**
- Updated repair vehicle behavior: AI repair units now stay behind the vehicle they are repairing, improving survivability and consistency.  
- Added a new system for **wire-guided weapons and AI aircraft-mounted weapons**:  
  - Removed offset and inaccuracy noise from missiles and flight paths.  
  - Wire-guided users and AI aircraft weapons are now pinpoint accurate.  
- Fixed repair loadout not spawning correctly .

**Update 9/7/2025**
- Added a new feature which allow Mortar and Aircraft(airplane/helicopter) to acquire target from friendly squads that are engaging them.
- For Specops mode, the feature above will be tie around the comm officer, if a squad with the comm officer spotted the player or their teammate, they can call in support from nearby mortar and aircraft (if you want to make this harder for yourself, add the Lt. infront of your bot names, allowing all unit in specops to able to receive constant supportive fire 
- Fix some code logic to fix a bug involving transport boat.

**Update 9/6/2025**
- Fixed up some code and change how the repair system work and added a limit to how long a vehicle get repair to prevent ai getting stuck in spawn because they can't physically go to the vehicle location.

**Update 9/5/2025**
- Update to EA32 version.
- fixed a problem with ai not able to hop on vehicle because of repair order.

**Update 9/4/2025**
- fixed ai in player squad not moving.
- Tweaked wire guided missile ai targeting
- Changed the weaponlead value so no random noise value will touch the wire guided missile guidance so the ai lead of the weapon will always be perfect

**Update 9/1/2025**
- hot fix a code that causes vehicles such as rhib , jeep mg to no longer move.

**Update 8/31/2025**
- Fixed airplanes stopping fire during attack runs.  
- Overhauled obstruction detection system to prevent unintended problems.  
- Improved seated AI weapon handling in close-range vehicle encounters.  
- Refined airplane attack run behavior: planes now switch to a random effective weapon against the target before committing to an attack run.  
- Improved wire-guided missile handling.  
- Tweaked infantry cover system: now only activates if the squad leader requires it, making infantry support behind vehicles more situational and less disruptive to pacing.  

**Update 8/27/2025**
- Tweaked Wire Guided missile behavior, improving their update rate and helicopter behavior. 
- Fixed Specops helicopter exfil pilot and gunner not using the right team skin.

- Allow ai to fire at target even if their weapon can't damage them/Fix projectile so the person impact mod now work

**Update 8/25/2025**
- Fixed ai not shooting after getting recruited into player's squad

**Update 8/19/2025**
- Hotfix for repair behaviour.

**Update 8/18/2025**
- New Ai feature: Ai with wrench/repair tool will repair friendly vehicle that are under 50% health , the repair system started when a vehicle squad has their squad vehicle health goes bellow 50%, the squad then will ask other squad within 100m radius for anymember with a repair tool to fix them up.
-  Tweaked other Ai feature to support the newly added repair feature .

**Update 8/13/2025**
- Fixed Wireguided passenger gunner not halting and improved helicopter halting performance in battle

**Update 8/10/2025**
- Re added **Combat vehicle target halt priority system**: Vehicles now only stop for dangerous/seated infantry; will keep advancing if spotting infantry that can’t damage them.
- Re added a code that forces AI and AI in vehicles (except boats) to not halt when touching water and to keep going.
- Re added **Mortar halt to fire** behavior.
- Flanking system refinements for more effective AI infantry maneuvers.
- Added **Smart driver bail-out**: Exposed or lightly-armored drivers (with no mounted weapons, and not piloting aircraft or boats) will disembark with their squad.


**Update 8/5/2025**
- Fixed ai sometime getting stuck on ladder while going to ambush point.
- Tweak ai accuracy to match with the old HavenM version.

**Update 8/4/2025**
- Fixed specops vehicle spawning location and flare spamming
- Fixed friendly ai in specops sometime stop firing entirely after leaving vehicle as well as improve Vehicle Ai anti friendly fire code

**Update 8/3/2025**
- localize some codes so the specops teammate not firing bug stop appearing.
- Added a feature that make actors that are 30m from the ground will be considered as a helicopter target type to prevent ground unit from shooting far up into a skies at parachuting actor unless they are an anti air weapon (don't worry weapon can't lock on to infantry, yet).

**Update 8/2/2025**
- Rewrote the entire AI system from scratch to fix SpecOps AI not shooting after leaving vehicles.
-  Removed AI jogging behavior. ( It made ai too exposes while the boost in speed is minimal)
- Removed forced halting for vehicles against low-threat enemies (like infantry that isn't having anti armor weapon). **reason: that code create some problem**
- Improved flanking and ambush behavior to work better with the new system.
- Ai infantry now if see falling bombs will try to run away to avoid them.
- Some small features are not yet re-added. Will be added back over time.

**Update 7/28/2025**

- Removed AI vehicle speed limiter: AI vehicles are no longer restricted to 80% of their max speed. They now travel at full top speed, increasing the overall pace and intensity of sandbox battles.

- Tweaked weapon leading mechanics for improved target prediction and firing accuracy.

- **Added new AI squad flanking and ambushing behaviors**  
  - Applies to both **Battle Mode** and **SpecOps**.

  ### Flanking AI
  - When an **attacking squad** in Battle Mode has a target near a capture point:
    - The squad will split into **two elements**:
      - One element will attempt to **flank** the enemy.
      - The other will stay in cover and **provide suppressive fire**.

  ### Ambushing AI
  - When a **defending squad** spots a target and is near cover:
    - They will reposition to **intercept the enemy’s path**, setting up an ambush.


**Update 7/20/2025**
- Reworked Ai airplane attack run behavior be more simplistic so ai have an easier time attacking their targets.

**Update 7/19/2025**
- Localize codes.
- Improved Aircraft/Air to Air and General weapon tracking for some weapons.

**Update 7/11/2025**
- Improved Ai suppression code so vehicle stop suppression when their barrel is obstructed .
- Tweaked aircraft  copilot mounted machine gunner so they perform better.
- Tweaked Ai weapon retention code for wire guided missile.
- Tweaked Ai turret anti air movement speed .
- Improved WireGuidedMissile by removing AI weapon sway on all wireguidedMissile type.
- Removed dynamic squad order (Conflict with RavenM).

**Update 7/8/2025**
- Improved Ai suppression code so vehicle doesn't stop suppressing from taking fire, only when they take large amount of damage.
- Tweaked vehicle ai driver combat behavior.

**Update 7/7/2025**
- Improved clamped turret , tracked vehicle

**Update 7/6/2025**

- Removed game-imposed AI turret speed buff: AI tank turrets now rotate based on modder-defined/default values, reducing jitter and unintended over-rotation.
- Improved AI suppression behavior: AI will now stop suppressing if they are attacked during suppressive fire, allowing them to respond to immediate threats. This improves both AI survivability and gameplay flow. (Does not affect aircraft, wire-guided, or mortar weapons.)
- SpecOps patrol behavior update: Patrol vehicles and their infantry now split into two separate squads during combat, enabling independent vehicle and infantry engagement against the player and allies.
- Added dynamic disembark logic for player-commanded vehicles:
  - If the player remains inside the vehicle, only non-gunner infantry will exit; gunners stay to provide fire support.
  - If the player exits the vehicle, all AI will disembark when ordered.
- Reverted and adjusted various weapon and vehicle attack run parameters for more consistent AI attack behavior.
- Improved AI first-shot accuracy for single-fire, wire-guided, and target-tracking weapons. AI now reliably hits targets on initial acquisition.
- Fixed erratic movement behavior in SpecOps AI, reducing jitter and improving pathing during engagements.
- Tweaked specops enemy behavior.

**Update 7/2/2025**
-  Added a check so tank turning vehicle doesn't take into account animated driven vehicle unless the animated driven vehicle is also having a clamped turret, to prevent the jittering of animation driven vehicle.
- Tweaked some ai weapon behavior.

**Update 7/1/2025**
-  Remove infantry flee from moving vehicle for now.

**Update 6/30/2025**
- Added a halt check so when Ai vehicle is picking up newly recruited squad, they will remained halted.
- Fixed Ai airplane being lock at a certain velocity when flying.
- Tweaked the suppression to stop in certain situation such as when Ai moving in and out of cover.

**Update 6/29/2025**
- All AI using wire-guided missile weapons now have zero infantry sway, overriding any modder-defined values, to significantly improve missile accuracy.
- Tweaked AI prone behavior to eliminate movement while firing in prone, resulting in more stable combat animations and improved Ai performance.
- Added a new mechanic for ground vehicles (excluding boats): if the vehicle has a driver and unfilled seats, and the squad can't fill them, the vehicle will now recruit nearby squads (within 100m) with the same or fewer members to seat ratio to fill the empty seats.
- Added a squad member limit check to transport helicopter pickups to prevent helicopters from getting stuck on the ground when there's one extra infantry who can’t board because the Heli doesn't have enough seats.
- Tweaked AI tank behavior so they no longer perform hull-down positioning (front toward enemy) for targets under 50m, preventing tanks from getting stuck in close-quarters environments.
- Tweaked Ai airplane attack run slightly.

**Update 6/14/2025**
- Tweaked the accuracy deviation code so it work better and more noticeable.

**Update 6/13/2025**

-  Fixed Ai airplane overshooting their shots when in dog fight .
-  Tweaked ai grenade throwing, this will make infantry using grenade more effectively, avoiding friendly fire and self damage with extra accuracy in the form of a new   Grenade homing system for ai only.
-  Extra tweaks to the codes for Aircraft so they don't crash as often.
- Removed some old left over suppression code .

**Update 6/1/2025**
-  tweaked target seeking missile so their first 15m of travel distance is a normal vanilla behavior so the missile has a chance to stabilize before active tracking  


**Added a Hunter-Killer system for vehicle AI:**

- When in combat but without a direct target, AI units mounted on a vehicle will now use the look direction of any other crew member who currently has a target.

- This allows gunners and passengers to coordinate better by aligning their aim with active threats spotted by teammates.

- For helicopters, the pilot will now turn the aircraft toward the position of the co-pilot's current weapon, significantly increasing combat effectiveness and coordination during engagements.


**Update 5/20/2025**
**Reworked AI Suppression Behavior:**
- AI now starts a 10-second suppression timer after directly spotting an enemy.

- During this period, they will continue firing at the enemy’s last known location, even if line of sight is lost.

- This significantly improves AI responsiveness in low-visibility environments (e.g., smoke, particles, debris), enhancing both realism and gameplay flow.

- Also improves aircraft bombing and helicopter attack runs, as AI can now sustain attacks based on brief target exposure.

**Update 5/6/2025**
- Removed weapon leading for helicopter because some heli spin out of control because the ai is trying to lead fire the target under them.

**Update 5/4/2025**
- Added a code preventing Amphibious, normal vehicle and infantry from halting for target if they are in water.
- Re added Switching grenade and melee for AI (yes, I finally fixed it).
- Added some tweak to improve infantry ai behaviour in water, mostly to get infantry out of water as soon as possible.
 
**Update 5/1/2025**
 - Removed auto U-turn reload aircraft will still perform U-turns but will no longer auto-reload during the maneuver.
- Added defensive behavior for transport vehicles: when within 60 meters of a capture point and taking fire, transports will now deploy smoke to improve infantry survivability.
- Tweaked TOW launcher handling to make AI usage more responsive.
- Added helicopter halting logic for target tracking and co-pilot targeting, improving engagement stability.
- Adjusted aircraft attack distances for bullet- and rocket-based weapons (straight-shooting types), preventing aircraft from curving downward unnecessarily during attack runs.
- Tweaked helicopter flight height and halting behavior: helicopters will now stop halting if they are over 150 meters above the ground, improving their flight consistency in high-altitude scenarios.

**Update 4/21/2025**
 - Removed Weapon lead on helicopter halting.
 - Tweaked hull-to-target calculation, improve the hull toward target detections system .
 - Tweaked the halting cooldown code.
   
**Update 4/21/2025**
 - Fixed helicopter spinning out of control
 - Tweaked hull-to-target timing.
 - Added a check so that the hull toward target code will not activate if the vehicle velocity is over 5 velocity, allowing the vehicle to move normally.
 - Added a check so that vehicle that preferred infantry on their main gun will halt to fire at infantry when they are within 100m of the vehicle.
 
**Update 4/20/2025**

- Added a reverse time limit check: vehicles will now always reverse for a minimum of 3 seconds before re-evaluating their movement.
 - Tweaked hull-to-target timing: instead of a 3-second limit, vehicles will now continuously adjust their hull toward the target until their front is within 45 degrees of alignment.
 - Added several checks for helicopter halting behavior, improving their ability to maintain movement and avoid getting stuck or unnecessarily hovering when engaging or moving to objectives.
 
**Update 4/18/2025**
- Revert the not stuck state tweak
- Added a time limit to the stuck-check code: vehicles tilted under 45 degrees will now only trigger the “not stuck” state for 3 seconds, instead of indefinitely.

- Tweaked tank tilt threshold from 40 degrees to 45 degrees for cleaner and more consistent behavior.

- Expanded the hull rotation angle for rotating turret tanks from 20 degrees to 40 degrees, allowing for more natural and flexible hull alignment.

- Adjusted hull-facing behavior so that tanks now only turn their hull toward targets that are over 50 meters away, preventing awkward or unnecessary close-range adjustments.

- Fixed unstable TOW launcher leading fire behavior by removing leftover test code that was affecting accuracy.
 
**Update 4/16/2025**

 - HotFix: tweaked the turning
 - Added Tank Hull Facing Behavior:

- Separated Tank Hull Toward Target behavior into three types:

- Clamped turret vehicles (Casemate): Turn their entire hull toward the target until the turret is within a 5-degree angle of the target.

- Rotating turret vehicles: Rotate their hull only if their front armor is over 20 degrees off from the target’s direction.

This system ensures Tracked (allowed for tank turning) armored vehicles keep their strongest armor facing their target for maximum protection.

None of these vehicles will rotate while reversing or avoiding obstacles, maintaining sensible and safe movement behavior during combat.

**Update 4/14/2025**

- Updated the maximum travel range for wire-guided missile weapons to match their configured effective range, instead of using a default 400 meters.

- For wire-guided (TOW) weapons with a lower effective range, 400 meters is now the minimum travel range, ensuring existing weapon configurations are not broken.

- Brought back the hidden code boolean that Steel (Ravenfield dev) had previously concealed, allowing the AI to now understand when their weapons cannot aim at a target. This improves targeting logic and ensures more accurate engagements.


**Update 4/12/2025**

- Bots in vehicles with clamped or restricted turrets can now only detect and engage enemies within their turret’s firing arc — meaning AI awareness is limited to where their turret can aim.

- Removed the behavior where casemate or clamped turret tank drivers would recklessly rush into capture points. These vehicles will now behave more cautiously, respecting their limited firing arcs and positioning accordingly.

- Tweaked the slope check so tank doesn't get stuck trying to shoot at target they can't aim at with their barrel because of factor such as (Depression, Slope and collision).


**Update 4/11/2025**

- Vehicles (Except aircraft) now only halt for infantry that pose an actual threat—those carrying heavy weapons or anti-tank gear.

- Heavily armored vehicles will only react to anti-tank-wielding infantry.

- Lighter vehicles that can be damaged by heavy arms will also be cautious of heavy armed weapon type on infantry such as HMG or modded weapon that can deal heavy arms damage and anti tank.

- This prevents constant halting for non-threatening infantry, significantly improving game flow and reducing unnecessary delays.

- Vehicles will now only halt at 50 meters from a threat.

- If a target gets within 5 meters, the vehicle will resume moving—preventing it from getting stuck in close-range engagements.

**Update 4/8/2025**

- Fixed Heli in SpecOps extraction get stuck hovering—waiting for their gunner to finish engaging a target instead of proceeding to land and pick up the player.
- Added a check so that bot ordered to move to a location doesn't halt to fire at target but instead keep moving.

**Update 4/7/2025**
- Fixed missile flare deviation path.
- Added an experimental proximity tracking missile script: missiles explode within 20 meters of the target, but only for weapons with a child component named HavenM Missile Proximity Explosion. This serves as both a test of the custom DLL's modding capabilities and a flexible tool for modders to implement proximity-based behavior using the dll as a foundation. 
- Example for the proximity explosion system working is here : https://steamcommunity.com/sharedfiles/filedetails/?id=3458994412]

**Update 4/5/2025**
- Fixed ai tracking while firing not take into account the target's velocity.
- Re-enabled grenade and melee switching when the AI is not actively attacking a target:
  -Grenade: The bot will switch if it senses an enemy between 10m and 40m.
  -Melee: The bot will switch if an enemy is within 5m and it’s not already holding a melee weapon.
 ==>Only applies when the AI is in a passive state and does not interfere with the existing weapon switching code used during active combat. It simply adds more flexibility based on proximity and awareness.

**Update 4/3/2025**
- Tweaked Tank behavior, re added always halt on normal and Beginner bots.
- Tweaked the missile deviation speed from 1 to 0.2

**Update 4/1/2025**
- Allow ai to repair their vehicle if they are not currently spotting a target
- Tweaked the velocity again for aircraft.
- Re added Sub weapon switching to ai, Ai will now switch to their sub weapon (if they have any) when they are not having any target.
-   Added a velocity limit, aircraft ai must be over 50 unit of velocity for them to actively slow down, to prevent excessive slow down on aircraft when they are doing attack run .

**Update 3/31/2025**
- Implemented a system that dynamically adjusts the velocity of AI-thrown grenades based on the target's distance, enhancing accuracy. This feature was inspired by the grenade-throwing behavior of Combine soldiers in Half-Life 2.

**Update 3/30/2025**
- Tweaked ai Air to Air missile tracking.
- Tweaked Vehicle combat halting behavior so it more reactive.
- Disable the auto avoidance code on vehicle after they finish reversing from a stuck location so the basic feature work without the avoidance thing mistakenly auto corrects the vehicle into stuck location, (3s cooldown)

**Update 3/29/2025**
- Removed ai ability extend their landing gear while airbrake, only player driven aircraft do that now.

**Update 3/28/2025**
-  Added Airplane throttle speed change depends on the target it's targeting (if the target is ground based or a helicopter, they will pull their throttle down to the negative, else they will leave the throttle at 0f).
- Reworked ground forces firing at aircraft system (if an aircraft flies low and slow, it turns into a ground vehicle) .

**Update 3/27/2025**
- Tweaked infantry avoiding vehicle system.
- Improved anti friendly fire system.
- Tweak the helicopter halting.
- Fixed specops not spawning extra patrol ( i forgor ).

**Update 3/26/2025**
- Reworked helicopter halting (allowing Heli to halt for passenger TOW missile passenger only when the driver isn't having a target, stop Heli from halting if their flight height is over the helicopter flight celling).
- Tweaked Vehicle halting, increase near objective capture point so vehicle will not halt when they are within 20m of the capture point's capturing radius.
- Reworked Airplane speed input (Should allow them to fly at full speed now).

**Update 3/24/2025**
- Added a limit to lock on weapon to not lock on target beyond their effective range so you don't randomly have BVR battle on weapons that are not built around that by their respective modder, also affect AI.
- Tweaked weapon switching to be more interesting.

**Update 3/23/2025**
- Fixed Mortar vehicle not moving.
- Tweaked some halt maneuvering.
- Limit the Combat reversing on vehicle to only activate when enemy distance is over 100m away to avoid (exposing weak points, crash into convoy).

**Update 3/21/2025**
- Tweaked, simplified leading fire.

**Update 3/20/2025**
- Fixed some turret cause vehicle to halt when they are not supposed to (ex: Transport boat with Mounted gun).

**Update 3/19/2025**
- Reworked the entire vehicle halting system.
- Vehicle only halt when spotted target with 50m radius. (Except TOW behavior, or when vehicle is set to never halt in combat)
- Everything else is dependence on the vehicle's targeting and engagement range set by the modder of the vehicle.
- Reworked ai engagement range, now instead of dependence on the game difficulty, it depends on the bot skill level, Easy mode range was 50m is now apply to beginners, normal is 80m now apply to normal, Hard was 120m, now apply to Veteran and Elite. Creating more dynamic bot behavior
- Added Mounted Gun signal halting to driver for Tow launcher, mortar and Automatic weapon that preferer aircraft that is currently shooting an aircraft.

**Update 3/17/2025**
- Added a tweak that disables all halting on vehicles if they have a preferred target (Because I re-added the infantry groups' targeting variable, most vehicle start halting when engaging a target, so I added another that force them not to halt when they are transporting infantry (in APC or IFV or IMV), improving the game's pacing.
- Added a tweak allowing the vehicle to continue moving forward if their barrel can't reach their target 
- Fixed the missile stop tracking after target flared

**Update 3/16/2025**
- Removed the AI tank hull toward target behavior (it needed more time in the oven).

**Update 3/15/2025**
- Added the Targetseeking missile code ( I forgot).
- Tweaked the Ai tank hull toward the target behaviour.
- Updated to EA31.
- Added experimental AI Tanks hull toward targets behaviour.

**Update 3/13/2025**
- Reworked the switch to effective weapon code. Now, the bot will only randomize if they 1 have no preferred weapon or multiple preferred weapons. This allows the bot to switch between multiple weapons in their inventory without becoming too robotic and choose the first effective weapon (example: the F4 chooses the napalm over the cluster even though they have the same preferred variable when targeting infantry group).
- Tweaked AI Weapon switching so they don't require any ammo to ensure more randomization of weapons.
- Improve spam fire accuracy on vehicle-mounted weapon such as auto cannon (driver operated auto gun).
We removed the instant reload variable from the combat reverse, so the vehicle stops in reverse when its gun is finished reloading.
- Tweaked the combat reversing again.
- Tweaked the Vehicle combat reversing.
- Fixed boat reversing infinitely.

**Update 3/12/2025**
- Added a new driver halt system:  
  - Vehicles with **transport AI** will halt if they have no passengers to allow the gunner to fire.  
  - Vehicles with **capture AI** will always stop to let the gunner fire.  
  - Vehicles with the **never halt** variable will never stop unless they have no passengers and only a gunner, in which case they will halt for firing.  
  - Transport vehicles with both passengers and a gunner will halt for **15 seconds**, followed by a **25-second cooldown** before the next halt.  


- Tweaked driver halt for gunner, I used the wrong variable, reduced the cooldown from 30s to 25s .

- Tweaked the aiming and firing to allow for better weapon leading by using the target velocity, using this, you will see a more responsive anti-air with them leading their shots at the target plane, and a general improvement to AI targeting and leading.

**Update 3/10/2025**
- Tweaked the driver halt for gunner so the code never applies to vehicles with passengers while keeping the same behaviour on 1 driver and 1 gunner. Grad and anti-air truck, any vehicle with only a driver and a gunner will halt as usual.
- made it so that the gunner with an automatic weapon fires even before looking at the target position to ensure more rounds go down range.
- Extra tweak to how the vehicle stops moving their turret around while having a target.
- Added a check to prevent AI-controlled vehicles from halting if the modder specifically makes them never halt in combat (example: T-34 for the Soviet-style assault). This will allow for more historically accurate gameplay, even though the AI driver will sometimes still halt to aim and then fire, but I think it's good enough. 

**Update 3/9/2025**
- Tweaked the combat reverse to prevent AI on vehicle getting stuck, mostly reducing the duration of cooldown halting
- Increase the slope detection angle from 15 degrees to 20 degrees.

**Update 3/8/2025**
- Added the projectile leading system to all vehicle ai firing behaviour except the wire-guided missile (TOW) weapon type.
- Added avoidance path check so ai vehicle won't do combat reverse while near another vehicle to prevent them from getting stuck. 
- Added a 20s timer to missile boat target tracking before dropping.
- Fixed AI not getting into boats and vehicles in water under certain conditions.
- Implemented a new prediction system for turret and non-driver gunner AI actors.
- Introduced a new wire-guided missile system for AI in boats, ensuring they never drop their target and always aim at the ground their enemy is standing on. This improves SOFA's missile boat AI behavior.

**Update 3/7/2025**
- Added more instances of vehicle anti-stuck reverse to prevent issues caused by the new reverse system.
- Reverted idle behavior changes.
- Implemented an idle animation check to prevent soft locks when AI is entering a vehicle (e.g., SOFA's Archipelago map).
- Adjusted AI behavior so that bots only run away from vehicles if their velocity is over 4f, reducing the distance and frequency of their fleeing behavior.

**Update 3/6/2025**
- Temporarily removed AI melee, grenade, and subweapon switching to fix issues preventing AI from firing after exiting water.
- Adjusted aim fire timing to improve vehicle accuracy at long range (e.g., tanks).
- Fixed an issue where vehicle drivers without passengers would stop driving.
- Added additional checks:
  - Preventing the game from falsely detecting a vehicle as stuck after reversing.
  - Implemented new AI behavior: When reloading under fire, AI will reverse until either the enemy stops firing or the weapon is fully reloaded.
- Re-added grenade launcher and melee switching to ensure system integrity.

**Update 3/5/2025**
- Removed ragdolling again.
- Removed melee and subweapon switching for AI.
- Reintroduced vehicle falling/ragdolling but clamped velocity at 15.
- Disabled high-speed ragdolling.
- Fixed an issue causing infinite mortar fire in certain locations.
- Removed unnecessary AI variables related to single-shot weapon behavior on foot.
- Added a mechanic where AI and players will fall out of non-aircraft vehicles if they exceed 15f velocity, triggering instant ragdolling.
- Removed redundant code.

**Update 3/4/2025**
- Tweaked AI variables.
- Allowed mortar bots to track targets even without line-of-sight.

**Update 3/3/2025**
- Increased helicopter attack distance to align with TOW launcher firing behavior.
- Tweaked AI firing mechanics.
- Fixed AI not firing in certain scenarios.

**Update 3/2/2025**
- Adjusted AI firing variables.
- Removed ragdoll velocity tweaks due to the absence of fall damage.

**Update 3/1/2025**
- Reverted previous update.
- Updated melee logic.
- Adjusted AI weapon range, removing some previous limitations.

---



