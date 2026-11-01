# HavenM Changelog
> [!tip]
>
> For history changelogs, check [Page 1](https://github.com/RavenfieldCommunity/HavenM/blob/26628c863f99de628b9c0bedaf1bd393366aa81c/CHANGELOG.md)
## Update — 11/1/2026
- Added an optional modifier which stop actor from spawning in capture point that are under attack/contested
- Tweaked helicopter ai movement code when taking off
- Tweaked actor movement code.
- Removed AI lower update rate when taking fire.
## Update — 10/31/2026
- Tweaked Helicopter behavior.
## Update — 10/30/2026
- Added A shooting currently held weapon ability when swimming so both ai and player can enable this via the mutator which remain off by default.                                  
- Added some tweak to ai movement and pathfinding so the Ai should move more smartly in different situation.
- Tweaked some aiming behavior and added the ability for ai to target other location on their target vehicle if they can't aim directly at the vehicle driver.

## Update — 10/29/2026
 - Tweaked AI movement
 - Tweaked Missile movement.
 - Tweaked Ai weapon effectiveness switching.
## Update — 10/28/2026

### AI Commander
- Added a Commander AI for both teams in all modes **except SpecOps and SpookOps**.
- The commander nudges and directs AI squads toward its agenda based on the active gamemode.
- Currently, the commander prioritizes getting vehicles out and running so AI don’t sit idle.
- The AI commander “thinks out loud” while directing. You can toggle this on or off in the new mutator config.

### Vehicles
- Fully implemented the gear system into AI vehicle code.
- AI are now more proficient at using vehicles that have a gear system.

### Fixes
- Fixed camera and rigid body updating. This should nearly eliminate the rubberbanding effect, where a moving object appears jittery when the player camera moves at the same speed as the object.

### AI Behavior
- Tweaked AI weapon-switching behavior and grenade danger zone checks.
- Tweaked helicopter AI.
- Tweaked AI helicopter code so helicopters no longer wobble when attacking ground targets.
  - Helicopters may still lean/roll into attacks when engaging aircraft, but that’s the only case.
  - AI helicopters should now have better flight and attack-run performance.
- Added a quick throw system for smoke and supply packs, similar to grenade behavior, so AI can throw them more easily.
- Tweaked Ai center position so instead of pointing at their stomach, it point toward the actor chest and neck position so AI can have a better chance at fighting target in cover overall.
- Tweaked some melee movement code.

### Cleanup
- Removed and disabled the staging attack code. It is now redundant and should be removed.
## Update 10/17/2026
- Improved AI vehicle driving/halted movement and casemate tank aiming; unarmed drivers now turn toward gunner targets when halted. Re-added single-operator AI behavior (driver switches to gunner when target is near, or exits unarmed vehicle to engage nearby enemies).
- Added ground-AI tick reduction when no active target (aircraft excluded) for performance.
- Tweaked armed-vehicle AI scavenging, AI repair distance/movement, AI aiming/update rate, and AI weapon switching for easier future expansion (AI/subweapon).
- Added a skill-scaled delay before AI throws grenades after spotting targets.
- Tweaked AI suppression to skip targets more than 20m from last seen position.
- Fixed AI grouped targeting not activating; optimized AI aircraft/projectile targeting.
- CIWS now off by default unless the mutator is active/loaded with HavenM; improved SpecOps AI patrol behavior.
- Significantly improved AI leading against ground targets and fixed AI update/respawn reset issues.
- Reworked SpecOps to work better; tweaked helicopter AI movement and attack-run distance.
## Update 10/6/2026
- Changed Ai tank driving behavior
- Made a new system for enemy ai infantry in specops mode
- Tweaked Ai leading code so they scale with the game time so slow motion doesn't mess up the ai leading.

## Update 10/4/2026
- Redo the entire code + updated it to the latest version
- Optimized some existing code (helicopter raycast, ai combat decision and weapon switching)
- Improved ai Airplane flying ability allowing ai when dogfight do better maneuver and smoother combat movement.
- Improved ai ability to track and lead their target when intercepting aircraft and projectile target.
- Rework the staging attack code so ai start attack after a set time limit is finish so they don't stay still forever.

## Update 9/18/2026
- Tweaked helicopter ai movement.
- tweaked mortar targeting.
- Fixed Ai not entering vehicle that are in water.
## Update 9/16/2026
- AI Squad Staging System: AI squads now gather and build up their numbers at their squad spawn position until enough units are present (2 or more squads) at the staging point. Once the threshold is met, they immediately advance to attack their capture point — creating a defend-and-attack system that improves both AI defensive and offensive capabilities.
- Improved Ai accuracy and lead behavior.
- Improved ai prone behavior check.
- Improve vehicle driving behavior (fixed ai getting stuck/ not reversing ), improved and simplified casemate/slowturret/normal armed vehicle behavior.
- Fixed an issue where scripted turrets spawned with AI onboard would not function
- Improved AI weapon-switching behavior for better responsiveness and reliability
- Tweaked vehicle behavior for more natural and consistent handling
- Fixed and improved code related to AI vehicle reversing
## Update 9/11/2026
- Fixed a weird issue with ai on horn/auto repair weapon keep trying to target enemy + some tweak to ai helicopter movement behavior 
- Fixed heli take off too quick when getting boarded after spawning.
- Fixed Ai sometime poke their body out of their seated vehicle.
- Improved helicopter movement and behavior.
- Fix up some code when it come to stuck checking of aircraft and vehicle that are getting stuck underwater.
- UPDATED to the latest EA39
## Update 9/7/2026
- Added a clamp so that aircraft (heli and airplane)doesn't fire as soon as it's projectile and hit their target but only when within effective range (doesn't affect guided missile and lock on)  
- Fixed airplane bombing check so they don't sometime fire when their target is behind them.
## Update 9/5/2026
- Removed the ground vehicle steering system (obstacle dodging behavior) for simplification of the ground ai vehicle behavior.
- Fixed ai going full throttle when on casemate tank.
- Change the heli movement code so that their general obstacle dodging/steering are only active when the heli is doing volatile movement such as attack run / disengaging.
- Added a new system which have heli picking up their passenger if they somehow forget them when taking off.
- Added few new code in the update() side so that aircraft when having target will always try to shoot more .

## Update 8/24/2026
- Added a new system which force vehicle to hull turn so it's turret of slow speed can get on target faster .
- Added a few code which will hopefully fix some weird issue with ai capturing and order movement    and should fix  a problem with ai leaning weirdly.
- Fixed helicopter flying too high.
- Fixed ai in the player squad not rotating their turret for combat when on a stationary turret vehicle.
## Update 8/16/2026
- Added a new reposition and steering code for vehicle.
- Removed the muzzle on target check for the halt in aitarget
- Added seated exclusion for actor inside vehicle so that the explosive penetration doesn't damage them.
- Added a projectile collider configuration support in accordance with the new mutator update which added the ability to do so.
## Update 8/13/2026
- Fixed up Airplane bombing run
- Added a new Bombing / strafing system which allow ai to fire more accurately when they do attack run which involved using a more reliable spherecast system 
- Fixed a few problem with Ai repair behaviour
- Fixed up the culling code so ai doesn't get culled as much when looked at by player and Increased the culling distance to 6000 from 1200
- Improved ai vehicle movement.
- Fixed the boat code not working.
- Added a new behavior which allow Ai infantry to get toward a nearby supply box and resupply.
- Tweaked the ai update code.

## Update 8/3/2026
- Fixed projectile interception not working.
## Update 8/2/2026

* Removed the requirement for AI ground vehicles to must have the same order as the nearby squad before picking up nearby squads up, allowing them to transport squads more naturally.
* Tweaked various systems and implemented a new aggressive AI culling system. Actors now render only when visible to the player or spectator camera using frustum culling, occlusion raycasts, allocation-free , cached visibility checks, and vehicle support. Nearby AI skip expensive checks, reducing rendering overhead and improving performance in large battles while minimizing pop-in.
* AI outside the player's view now skip tick updates(Except ai in combat or having a CIWS target). 
* Fixed penetration settings only applying in Spec Ops. Penetration can now be customized correctly across all game modes.

## Update 7/30/2026
- Improved ai driving code.
- Tweaked ai threading code.
## Update 7/29/2026
- Improved Penetration code .
- Updated to the latest patch .
## Update 7/28/2026
- Added a new melee system to enhance ai behavior when using melee weapons (taken from PAIO with permission + allow it to support melee subweapon like bayonet as well)
- Reverted a few codes that no longer work or work but doesn't leave enough impact on the game (mainly around ai)
- Added a code which allow ai driver to dynamicly switch to their empty mounted gun seat if it is the only member in the vehicle (the driver only switch to gunner if it is near an enemy and the vehicle is either defending or attacking a capture point and it get near enough so the driver would switch to mounted weapon when needed, only if the driver doesn't have a mounted weapon of it's own)
- Removed ai taking cover restriction so ai go into cover more often (taken from PAIO with permission)
- Tweaked the ai vision code so ai doesn't raycast it's eyes toward every enemy it can see and limit it to the nearest 12 enemy only, this Improve ai target acquisition so ai would focus on the nearest target first  and not on some far off enemy, this result in more successful ai assault and ai teammate coordination with the player.
## Update 7/23/2026
- hotfix , projectile and proximity projectile and CIWS not updated.
## Update 7/22/2026
 - Updated to the latest version.
 - Added a tweak to ensure that the mutator save to config
## Update 7/21/2026
 - Improved specops spawning code / Tweaked for the latest mutator update.
 
## Update 7/19/2026
- Improved ground vehicle ai steering .
- Improved helicopter ai vehicle movement .
- Fixed an issue with specops exfil wave infantry spawning not respecting the delay set by the mutator.

## Update 7/15/2026
 - Improve airplane codes and improve lean ability for ai so they don't twitch as much and respond better to ai movement with ai now lean toward the direction that they are moving when they are moving to the side.
## Update 7/14/2026
- Updated with more options for specops to be customized (enemy spawn distances and infinite ammo for teammate in specops).


