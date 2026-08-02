# HavenM Changelog
> [!tip]
>
> For history changelogs, check [Page 1](https://github.com/RavenfieldCommunity/HavenM/blob/26628c863f99de628b9c0bedaf1bd393366aa81c/CHANGELOG.md)
## Update 8/2/2026

* Removed the requirement for AI ground vehicles to receive an order before picking up nearby squads, allowing them to transport squads more naturally.
* Tweaked various systems and implemented a new aggressive AI culling system. Actors now render only when visible to the player or spectator camera using frustum culling, occlusion raycasts, allocation-free , cached visibility checks, and vehicle support. Nearby AI skip expensive checks, reducing rendering overhead and improving performance in large battles while minimizing pop-in.
* AI outside the player's view now skip tick updates. 
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


