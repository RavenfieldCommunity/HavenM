# HavenM Changelog
> [!tip]
>
> For history changelogs, check [Page 1](https://github.com/RavenfieldCommunity/HavenM/blob/26628c863f99de628b9c0bedaf1bd393366aa81c/CHANGELOG.md)
## Update 9/5/2026
- Removed the vehicle steering system for simplification of the ai behavior.
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


