# HavenM 
![](https://img.shields.io/discord/1132554570099343380.svg?label=Discord&logo=Discord&style=flat-square) ![](https://img.shields.io/github/downloads/RavenfieldCommunity/HavenM/latest/total.svg?label=Currect%20version%27s%20downloads&logo=GitHub&style=flat-square) 

![](https://img.shields.io/badge/dynamic/json?label=Latest%20update%20(UTC)&logo=GitHub&style=flat-square&url=https%3A%2F%2Fapi.github.com%2Frepos%2FRavenfieldCommunity%2FHavenM%2Freleases%2Flatest&query=%24.assets%5B0%5D.updated_at)

AI and Gameplay Overhaul for Ravenfield

## Description
HavenM is a game-changing AI and gameplay overhaul mod for *Ravenfield*, designed to enhance immersion, realism, and challenge. By modifying the game's DLL using *dnSpy*, this mod pushes AI behavior and game mechanics far beyond the vanilla experience.

Ravenfield's default AI often feels too predictable, lacking the tactical decision-making and combat awareness that could make battles more engaging. Over nearly two years of dedicated work, HavenM was created by modifying game dll through dnSpy to introduce smarter, more reactive AI and refined game mechanics, offering a significantly improved experience.

> [!tip]
>
> **↓↓↓ Read the content below carefully!!!**

## Key Features & Changes

- **AI Improvements**

  - Tactical Movement & Reactions
    - AI soldiers go **prone under fire**, making them harder to hit.
    - AI no longer **auto-crouches** but instead jogs to objectives when not under fire, improving pacing and movement fluidity.
    - AI **halts vehicles to fire weapons**, with behavior influenced by weapon type and vehicle type, if the vehicle is a transport vehicle and they are not currently using a single shot or smart weapon (lock on/guided), the vehicle will likely go into a creeping mode in which they slow down and move slowly.
    - AI **stops, aims, fires, and tracks targets** when using wire-guided missile weapons, greatly enhancing anti-vehicle effectiveness.
    - AI vehicle will not halt if their weapon muzzle is not aiming straight at their target + leading angle to target position so vehicle doesn't get stuck on slopes and uneven terrain.
    - AI **exits vehicles when submerged** in water and leaves aircraft when stuck and not moving, preventing soft-lock situations.
    - **Amphibious Infantry & Vehicles in Water**: Infantry and amphibious vehicles that are not watercraft will no longer halt while in water, preventing them from becoming sitting ducks and improving survival in aquatic environments.
  - Combat Behavior & Engagements
    - AI in a vehicle will **pop countermeasures** when damaged below 50% health or when they are transporting infantry near target capture point and taking fire to support dismounting infantry (ground vehicles only).
    - Only **Veteran and Elite skill vehicle drivers** pop flares against lock-on threats.
    - AI **fires more aggressively**, reducing hesitation in firefights as well giving ai a suppressive fire ability in general.
    - AI from **all skill levels can lean**.
    
    - AI **provides suppressive fire** on last known enemy positions when not having any other target nearby.
    - AI Helicopter/airplane/mortar artillery unit **prioritizes high-threat targets** like enemy mortar teams.
    - AI with mortar weapon will pick targets from other friendly squad that is currently engaging a target, allowing mortar unity to be a truely indirect fire unit instead of requiring direct visual sight on enemy target.
    - Ai Airplane will also have the same target sharing ability similar to mortar AI so ai Airplane will always be engaging target on the sandbox.
    - Ai heli will also have the same sharing code but only for high priority target.
    - AI **engages (low-flying/slow/stucked) aircraft** as a ground target, increasing threat to aircrafts in the sandbox.
    - AI **randomizes weapon switching** to allow for more diversity in combat.
    - AI **switches between grenades, UBGL, and melee** when appropriate.
    - Transport vehicles with no passenger count **halt more** to offer fire support.
    - **Airplanes perform better** in air-to-ground tactics based on loadout.
    - AI **reverses based on the vehicle's actual reverse speed**, preventing stuck logic (e.g., T-72 tanks).
    - AI **loadouts are now actually randomized** and not distance based.
    - AI **panic fires when enemies are within 20m**, enhancing close-quarters realism as well as allowing for vbied to work or just to simulate panic.
    - Helicopter AI now **slows and stabilizes** for accurate guided missile use upon spotting enemies.
    - **AI groups near cover** are now treated as infantry group for weapons targeting.
    - AI **vehicle driver halts** if passenger count is low and gunner has a target.
    - **Missile Lock-On Enforcement**: AI does not fire missiles beyond actual lock-on range.
    - **Dynamic Leading**: AI leads shots based on target velocity for better realism in aircraft and AA.
    - **Skill-Based Range Logic**: AI chooses engagement range based on individual skill, not global difficulty.
    - **Weapon Preference Logic**: AI picks from available weapons randomly, factoring situation and effectiveness.
    - AI with grenade weapons now auto throw their grenade without switching their weapon improving tactical grenade usage on AI.
    - **Vehicle Gunner Logic**: Vehicles halt if the gunner is the only occupant and  the gunner sees a valid target with their gun muzzle on target.
    - **Driver Infantry Filter**: Transport Vehicle drivers will not halt to fire at infantry unless the infantry is carrying AT or operating static weapons.
    - **Fixed Turret Vision Limits**: AI in casemate/fixed weapons can now see outside of their  limited arc.
    - **Hull Rotation Rules**: Casemate vehicles always rotate until the target is targetable; turreted vehicles rotate hull only if target is 45°+ off so the tank strongest armor is facing the enemy direction.

- **New Game Mechanics**

  - **Weapon Mounting System**
    - Inspired by *Rising Storm: Vietnam*, players can now mount weapons on surfaces for improved accuracy and stability.

  - **Advanced Missile Targeting**
    - Missiles **predict target movement** instead of flying straight.
    - Flares **confuse missiles** with unpredictable deviations instead of outright misses.

  - **Tank Track Climb**
    - Tanks and tracked vehicles **climb over any obstacle** their tracks touch.
    
  - **Missile Target Tracking Range Limitation**  
    - Target-tracking missiles will **not lock onto targets outside of their effective range**, ensuring 
      more realistic engagements and enhancing the sandbox gameplay depth, also prevent RavenM long range 
      spawn camping when in air to air match.
  
  - **Simple Penetration System**
    - Explosive Weapons **dealing over 100 damage and have higher than Heavy Arms damage type penetrate cover**.
  -  **Missile Proximity Detonation (Mod support feature)**  
     - Missiles that modder allowed to have proximity Detonation will **detonate within 20m of the target**, providing more realistic impact behavior without adding more to the normal ravenfield experience.
  - **Overhauled SpecOps Game Mode**
    - **Dynamic enemy spawns** for varied combat.
    - **Configurable objectives and bot count**, scaling challenge.
    - AI **exits vehicles** to fight nearby players.
    - AI **flanks and ambushes** based on skill.
    - **Hero Armor** now negates balance knockdown and reduces damage.
    - Friendly AI get **improved Hero Armor** to survive firefights.
    - Low-skill AI **rush player location**; Veterans hold and support.
    - **More enemy waves during exfil**, increasing tension.
    - AI **reacts with flares** on alert—not just on visual contact.

# Installation 
Re-installing equals updating or fixing!

**DO NOT USE GAME'S BETA BRANCH!**
## By Command
Copy the following command and open [Windows Terminal](https://apps.microsoft.com/detail/9n0dx20hk701) or [powershell](https://learn.microsoft.com/en-us/powershell/scripting/windows-powershell/starting-windows-powershell?view=powershell-7.5#run-from-the-start-menu), paste it and press `Enter` to run:
> `$w=(New-Object System.Net.WebClient);$w.Encoding=[System.Text.Encoding]::UTF8;iex($w.DownloadString('http://ravenfieldcommunity.github.io/static/get_havenm-utf8.ps1'));Read-Host;`

Run this command to get a update for ACUpdater from time to time!

> [!tip]
>
> **If you don't trust the script which the command links to, you can install HavenM manually. Or visit the Q&A for more info.**
>
> **More details like uninstalling, refer [Docs](https://ravenfieldcommunity.github.io/docs/en/Projects/havenm.html)** (this site does not belong to this project).

## By yourself
Open [releases page](https://github.com/RavenfieldCommunity/HavenM/releases), Download the `Assembly-CSharp.dll` and put it in `Ravenfield\ravenfield_Data\Managed`

Download the `HavenM.ACUpdater.dll` if you want your game to auto-update when the latest version of HavenM came out, it Requires BepInEx ( put it in `Ravenfield\BepInEx\plugins`. **If you want to use the updater, then you will not need to download the HavenM main file again manually, after installing updater, the updater will install HavenM automatically**)

# Q&A
Refer [Docs](https://ravenfieldcommunity.github.io/docs/en/Projects/havenm.html).

# Support Us
Give a `Like` in the [Steam Workshop](https://steamcommunity.com/sharedfiles/filedetails/?id=3428665609) or a star on GitHub, thanks for support!

You can also feedback any issues and suggestions on workshop!
