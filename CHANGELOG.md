# HavenM Changelog
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



