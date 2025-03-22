# HavenM Changelog
**Update 3/21/2025**
-Tweaked, simplified leading fire.

**Update 3/20/2025**
-Fixed some turret cause vehicle to halt when they are not supposed to (ex: Transport boat with Mounted gun).

**Update 3/19/2025**
- Reworked the entire vehicle halting system.
- Vehicle only halt when spotted target with 50m radius.(Except TOW behavior, or when vehicle is set to never halt in combat)
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



