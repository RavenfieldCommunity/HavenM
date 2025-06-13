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
    - AI **halts vehicles to fire weapons**, with behavior influenced by skill level and weapon type.
    - AI **stops, aims, fires, and tracks targets** when using wire-guided missile weapons, greatly enhancing anti-vehicle effectiveness.
    - AI vehicle will not halt on slope, uneven terrain.
    - AI **exits vehicles when submerged** in water and leaves aircraft when stuck and not moving, preventing soft-lock situations.
    - AI-Infantry **get out of vehicle path while it's moving**.
    - AI on transport vehicles will **not disembark while assaulting if the vehicle is currently in water**, preventing combat delays an improving combat effectiveness.
    - **Water navigation behavior** improved: amphibious units and infantry no longer stall in water and seek to exit when safe.
    - **Helicopters ignore halt commands** at altitudes above 150m to maintain consistant flight height.
    - **Amphibious Infantry & Vehicles in Water**: Infantry and amphibious vehicles that are not watercraft will no longer halt while in water, preventing them from becoming sitting ducks and improving survival in aquatic environments.
  - Combat Behavior & Engagements
    - AI in a vehicle will **pop countermeasures** when damaged below 50% health (ground vehicles only).
    - Only **Veteran and Elite skill vehicle drivers** pop flares against lock-on threats.
    - AI **fires more aggressively**, reducing hesitation in firefights.
    - AI from **all skill levels can lean**.
    - AI **provides suppressive fire** on known enemy positions when not having a target.
    - AI **prioritizes high-threat targets** like mortar teams.
    - AI **engages low-flying/slow aircraft**, increasing threat to aircrafts in the sandbox.
    - AI **randomizes weapon switching** to avoid predictability.
    - AI **switches between grenades, UBGL, and melee** when appropriate.
    - Vehicles with no passenger count **halt more** to offer fire support.
    - **Airplanes perform better** in air-to-ground tactics based on loadout.
    - AI **reverses based on the vehicle's actual reverse speed**, preventing stuck logic (e.g., T-72 tanks).
    - AI **loadouts are now actually randomized**.
    - AI **no longer drops targets** in SpecOps or at <40m range.
    - AI **panic fires when enemies are within 20m**, enhancing close-quarters realism.
    - Helicopter AI now **slows and stabilizes** for accurate wire guided missile use upon spotting enemies.
    - **AI groups near cover** are now treated as infantry group for weapons targeting.
    - AI **vehicle driver halts** if passenger count is low and gunner has a target.
    - **Missile Lock-On Enforcement**: AI does not fire missiles beyond actual lock-on range.
    - **Dynamic Leading**: AI leads shots based on target velocity for better realism in aircraft and AA.
    - **Skill-Based Range Logic**: AI chooses engagement range based on individual skill, not global difficulty.
    - **Weapon Preference Logic**: AI picks from available weapons randomly, factoring situation and effectiveness.
    - AI with grenade weapons now adjusts **throw velocity based on target distance** improving tactical grenade usage.
    - **Vehicle Gunner Logic**: Vehicles halt if the gunner is the only occupant and sees a valid target.
    - **Driver Infantry Filter**: Transport Vehicle drivers will not halt to fire at infantry unless the infantry is carrying AT or operating static weapons.
    - **Smoke and countermeasure Deployment for transport vehicle**: AI transport vehicles automatically deploy smoke when near capture zones under fire.
    - **Halt Behavior Logic**: AI vehicles halt intelligently based on threat type, passengers, and cooldown logic.
    - **Minimum Reversing Time**: AI reverses for at least 3 seconds when avoiding distant targets (>100m).
    - **Fixed Turret Vision Limits**: AI in casemate/fixed weapons can only see within their arc.
    - **Hull Rotation Rules**: Casemate vehicles always rotate until the target is targetable; turreted vehicles rotate hull only if target is 45°+ off so the tank strongest armor is facing the enemy direction.
    - **Clamped Turret Behavior**: Limited-arc vehicles stay behind capture zones unless threats are directly ahead.

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
    - Weapons **dealing over 100 damage penetrate cover**.
    - Explosives **dealing 900+ damage ignore cover** and explode through it.
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

- **Partial Revamp of Haunted Mode**
  - Skeletons now have **randomized health** (30–100).
  - **Wave count increases** enemy spawns dynamically.
  - Skeletons can now **run after players**, not just walk.
  - Hero Armor **applies to player and allies**.
  - Skeletons **no longer take cover**, improving pacing.


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
