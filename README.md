# HavenM 
![](https://img.shields.io/discord/1132554570099343380.svg?label=Discord&logo=Discord&style=flat-square) ![](https://img.shields.io/github/downloads/RavenfieldCommunity/HavenM/latest/total.svg?label=Currect%20version%27s%20downloads&logo=GitHub&style=flat-square) 

![](https://img.shields.io/badge/dynamic/json?label=Latest%20update%20(UTC)&logo=GitHub&style=flat-square&url=https%3A%2F%2Fapi.github.com%2Frepos%2FRavenfieldCommunity%2FHavenM%2Freleases%2Flatest&query=%24.assets%5B0%5D.updated_at)

AI and Gameplay Overhaul for Ravenfield

## Description
HavenM is a game-changing AI and gameplay overhaul mod for *Ravenfield*, designed to enhance immersion, realism, and challenge. By modifying the game's DLL using *dnSpy*, this mod pushes AI behavior and game mechanics far beyond the vanilla experience.

Ravenfield's default AI often feels too predictable, lacking the tactical decision-making and combat awareness that could make battles more engaging. Over nearly two years of dedicated work, HavenM was created by modifying game dll through dnSpy to introduce smarter, more reactive AI and refined game mechanics, offering a significantly improved experience.

**↓↓↓ Read the content below carefully!!!**

## Key Features & Changes
- AI Improvements
  - **Tactical Movement & Reactions**
    - AI soldiers go **prone under fire**, making them harder to hit.
    - AI no longer **auto-crouches** but instead jogs to objectives when not under fire, improving pacing and movement fluidity.
    - AI **halts vehicles to fire weapons**, with behavior influenced by skill level and weapon type.
    - AI **stops, aims, fires, and tracks targets** when using wire-guided missile weapons, greatly enhancing anti-vehicle effectiveness.
    - AI will not halt on slope, uneven terrain
    - AI **exits vehicles when submerged** in water and leaves aircraft when stuck, preventing soft-lock situations.
    - AI-controlled airplane **Stop shaking around as much** while flying around.
    - AI-Infantry **Get get out of vehicle path while it's moving**.
    - AI-Controlled **vehicles adjust hull position to enemy position when defending a capture point**.
    - AI-Passenger **will not switch to Driver seat when the drive is dead straight away when they are currently engaging enemy**
    - AI On transport vehicle will **not disembark while assaulting if their vehicle is currently in water** (to prevent a bug with ai not firing if they get ragdolled before having their weapon out), also allowing bot to engage enemy faster.
  - **Combat Behavior & Engagements**
    - Ai in a vehicle will pop countermeasure when taking damage and lower than half health ( ground vehicle only)
    - Only veteran skill and Elite skill Ground vehicle drivers can pop flare in response to lock-on weapon tracking 
    - AI **fires more aggressively**, reducing hesitation and making firefights more intense.
    - AI from **all skill levels can lean**.
    - AI **hides behind the cover when under fire**.
    - AI **provides suppressive fire** on known enemy positions.
    - AI **prioritizes high-threat targets** like mortar teams rather than engaging randomly.
    - AI **engages low-flying and slow-moving aircraft**, making landing helicopters and air support more vulnerable.
    - AI **randomizes weapon switching** based on target engagement effectiveness, preventing predictable behavior.
    - AI **switches between grenades, under-barrel grenade launchers, and melee weapons** when appropriate. (REMOVED because of bug)
    - Vehicles with low passenger counts halt more often to provide fire support instead of recklessly rushing into battle.
    - **Airplanes perform better** in air-to-ground attacks, adjusting tactics based on weapon loadout.
    - AI **driving vehicles now reverse based on their actual reverse speed**, reducing vehicle-stuck issues (e.g., T-72 tank).
    - AI **loadouts are randomized**.
    - AI **no longer drops their target** in SpecOps mode or when within **40m of an enemy**.
    - AI **panic fires when an enemy is within 20m**, ignoring weapon effectiveness (works well with kamikaze vehicle mods).
    - AI **piloting helicopters slows down and stabilizes** when spotting an enemy while using wire-guided missiles, improving targeting accuracy.
    - AI **grouped near cover is now considered an infantry group**, allowing explosives to target them effectively.
    - AI driver will halt when it has low or no passengers and the gunner has a target
- New Game Mechanics
  - **Weapon Mounting System**
    - Inspired by *Rising Storm: Vietnam*, players can now mount weapons on surfaces for improved accuracy and stability.
  - **Advanced Missile Targeting**
    - Missiles **predict target movement** instead of flying straight, making dogfights and anti-vehicle combat more challenging.
    - Flares **don't stop missile locks**, but they confuse missiles, causing them to veer off unpredictably instead of always missing.
  - **Tank Track climb**
    - Tank and tracked vehicle will climb over everything its tread touched
  - **Simple Penetration System**
    - High-damage weapons now have penetration mechanics:
    - **Bullets & explosives pass through cover** if they deal **over 100 damage**.
    - **Explosives ignore cover & explode** if their damage is over **900**.
  - Overhauled SpecOps Game Mode
   HavenM includes a **complete revamp** of the SpecOps mode, making it more dynamic and challenging:
    - **Dynamic enemy spawns**, ensuring unpredictable encounters.
    - **Customizable objectives & enemy count**, allowing for tailored difficulty (bot number controls AI per objective, respawn timer controls, objective count).
    - AI **exits vehicles** when the player is nearby to engage in direct combat.
    - AI **flanks and ambushes players** based on skill level.
    - Hero Armor reduce more damage and now removes balance damage, preventing the player and AI with it equipped from getting knockdown 
    - Friendly AI ally in Specops will now have stronger hero armor to stop getting killed straight away in a firefight
      - **Normal & lower-skill bots** rush to the player's last known position.
      - **Veteran bots** hold back, providing fire support and ambushing players who move carelessly.
    - **Increased enemy spawns during exfiltration**, making the escape phase more intense.
    - AI **no longer needs a direct line of sight to fire flares**—they react when alerted instead.
      
- **Partial revamp of the Haunted mode**
    - **Dynamic enemy health**, Skeleton spawn with randomized health between (30 and 100).
    - **Increased enemy count for each wave**, Increase challenges.
    - Skeleton **Can Run** after the player instead of walking slowly.
    - Hero Armor is also added to player and their ally
    - Skeleton no longer take cover when attacking player

# Installation 
Re-installing equals updating or fix!

## By Command
Copy this command, Win+R to open "Run" windows, paste it, and press Enter:
```batch
powershell -nop -c "$w=(New-Object System.Net.WebClient);$w.Encoding=[System.Text.Encoding]::UTF8;iex($w.DownloadString('http://ravenfieldcommunity.github.io/static/get_havenm-utf8.ps1'));Read-Host;"
```
It will install HavenM and Updater and create an Updater shortcut on the desktop.

Run this command to get a full update from time to time!
## By yourself
Open [releases page](https://github.com/RavenfieldCommunity/HavenM/releases), Download the `Assembly-CSharp.dll` and put it in `Ravenfield\ravenfield_Data\Managed`

Alternatively, Download the `HavenM.ACUpdater.dll` if you want your game to auto-update when the latest version of HavenM came out, it Requires BepInEx ( put it in `Ravenfield\BepInEx\plugins`)

**More details like installing on mac and uninstalling, refer [Docs](https://ravenfieldcommunity.github.io/docs/en/Projects/havenm.html)** (this site does not belong to this project).
# Q&A
Refer [Docs](https://ravenfieldcommunity.github.io/docs/en/Projects/havenm.html).

# Support Us
Give a `Like` in the [Steam Workshop](https://steamcommunity.com/sharedfiles/filedetails/?id=3428665609) or a star on github, thanks for support!
