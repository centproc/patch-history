# 2023-09-27 - SF6 PATCHNOTES
---
<br>

<h3 id="top">General Changes</h3>
<strong><a href="/patch-history/docs/street-fighter-6/" style="text-decoration: none;">back to patch list</a></strong>
<br>
<br>

><h4>Assisted Combos</h4>
<p>
The following tweaks have been made in order to improve Assist Combo controls.

1. Each Assisted Combo's input reception timing has been adjusted due to some Assisted Combos accepting inputs too quickly, and others having very small input windows that made them difficult to perform.

2. Made an adjustment so that when special move cancels are allowed, Assisted Combos will also be allowed. This is due to Assisted Combo input reception being too short and thus not allowing for cancels during the active frames of an attack. <br><br>Please note that due to this adjustment, if your Assisted Combo input is too late, then there are situations where you won't be able to connect to the special move that you cancel into.

3. Fixed an issue where if you stopped an Assisted Combo midway through and then tried to perform another Assisted Combo of the same strength as soon as possible, the buffered input would not work.

4. Fixed an issue where if you stopped an Assisted Combo midway through and then tried to perform another Assisted Combo of a different strength, that Assisted Combo may not be performed properly.

5. Made an adjustment to prevent rapid cancel attacks from being performed when pressing the Light Attack button while the Assist button is being held. This adjustment was made as it was difficult to perform Light Assisted Combos from rapid cancel attacks.
</p>

><h4>Forward Dash/Back Dash</h4>
<p>

1. Fixed an issue where inputting forward three times would result in two forward dashes being performed.

2. Increased the buffer input window from 4 frames to 7 frames.
</p>

><h4>Input recognition frames</h4>
<p>
In order to reduce unintentional Super Art activations, the input recognition frames* of certain Super Art commands have been shortened. Due to this adjustment, players must input their commands faster or the Super Art may not be performed.

Adjusted Super Art Commands are as follows:
<ul>
<li>↓↘→↓↘→</li>
<li>↓↙←↓↙←</li>
</ul>

*Input recognition frames are the number of frames you must input the next command in order for the game to recognize you are performing a specific attack.

ex. In the case of the ↓↘→↓↘→ command, there are 9 input recognition frames between the first Down input and the next Down-Forward input, meaning if 10 frames pass between those inputs, the first Down input will be reset and the Super Art will not be performed.
</p>

><h4>Gauge gain on Perfect Parry</h4>
<p>
When perfect parrying certain multi-hitting attacks, there were cases where the Drive Gauge consumption was more than the Drive Gauge gain, so adjustments have been made. Perfect parrying strike attacks will now give an increase of 10,000 (1 block) while perfect parrying Super Arts will give an increase of 20,000 (2 blocks).

Considering the ease of parrying them, projectiles other than Super Arts will be kept in their current state.

For a list of moves affected by this adjustment, please refer to each character's section.
</p>

><h4>Attacks hitting an opponent behind the player</h4>
<p>
Fixed an issue where some attacks attacks could unintentionally hit an opponent behind the character.

For a list of moves affected by this adjustment, please refer to each character's section.
</p>

><h4>Drive Gauge gain during Burnout</h4>
<p>
Due to a value setting error, there were some attacks that when blocked during Burnout, only increased the Drive Gauge by half of what would be consumed when blocking it normally (the same as overhead or low attacks). This has been corrected with this update.

For a list of moves affected by this adjustment, please refer to each character's section.
</p>

><h4>Chip damage during Burnout</h4>
<p>
Due to a value setting error, outside of Super Art attacks, there were some attacks that when blocked during Burnout only chipped 1/4 of the original damage value. This has been corrected with this update.

For a list of moves affected by this adjustment, please refer to each character's section.
</p>

><h4>Drive Impact</h4>
<p>
Fixed an issue where stopping a Drive Impact with another Drive Impact after absorbing a hit via armor would result in the two Drive Impacts canceling each other out.
</p>

><h4>Drive Parry</h4>
<p>

1. Fixed an issue where performing a Drive Parry from a crouching position would result in a different Drive Gauge consumption timing compared to one done from a standing position.

2. Fixed an issue where performing a Drive Parry from a crouching position with certain characters and holding the parry would result in increased Drive Gauge consumption. This has been fixed to match what happens when performing a Drive Parry from a standing position.

■ Characters Affected
<ul>
<li>Luke</li>
<li>Kimberly</li>
<li>Zangief</li>
<li>Dee Jay</li>
<li>Rashid</li>
<li>Guile</li>
<li>E. Honda</li>
</ul>
</p>

><h4>Perfect Parry</h4>
<p>
Fixed an issue where if an upward direction (up, up-left, or up-right) was input after perfect parrying a projectile, the character would perform a jump even if the upward directional input was released before the character exited their recovery state.
</p>

><h4>Jump attack landing recovery</h4>
<p>
Fixed an issue where after having your jumping attack perfect parried, the timing for when you're next able to perform a standing attack was 1 frame later than intended.

Please note that no changes were made to Perfect Parries for this issue.
</p>

<!-- Section Index -->
<h3>Specific character updates this patch</h3>
<table class="character-table-style">
<tbody>
<tr>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#luke">Luke</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#jamie">Jamie</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#manon">Manon</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#kimberly">Kimberly</a></td>
    </tr>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#marisa">Marisa</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#lily">Lily</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#jp">JP</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#juri">Juri</a></td>
    </tr>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#dee-jay">Dee Jay</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#cammy">Cammy</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#ryu">Ryu</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#e.-honda">E. Honda</a></td>
    </tr>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#blanka">Blanka</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#guile">Guile</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#ken">Ken</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#chun-li">Chun-Li</a></td>
    </tr>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#zangief">Zangief</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#dhalsim">Dhalsim</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-07-24-sf6-patchnotes#rashid">Rashid</a></td>
    </tr>
</tbody>
</table>

---

<br>

<h2 id="luke">Luke</h2>

<br>

><h4>Overdrive No Chaser (↓↘→+2 Kicks, Punch)</h4>
<p>
The amount of Super Art gauge gained on block was not half of the amount gained on hit, so it has been adjusted from 500 to 600.
</p>

><h4>Shared adjustment: Chip damage during Burnout</h4>
<p>
The amount of chip damage done when an opponent blocks the following attack during Burnout has been adjusted.

<ul>
<li>Light Flash Knuckle (↓↙←+Light Punch)</li>
<li>Perfect version 2nd hit: From 75 to 50</li>
</ul>
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attacks during Burnout has been adjusted.

■ Light Flash Knuckle (↓↙←+Light Punch)<br>Perfect version 2nd hit: From 0 to 500

■ Fatal Shot (↓↘→+2 Punches, 2 Punches)<br>From 0 to 500
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.
<ul>
<li>Perfect and max charge versions of Light/Medium/Heavy Flash Knuckle (↓↙←+Punch)</li>
<li>Overdrive Rising Uppercut (→↓↘+2 Punches)</li>
<li>Vulcan Blast</li>
<li>Erase</li>
</ul>
</p>

><h4>Drive Impact</h4>
<p>
Fixed an issue that would cause the opponent to not take damage during the hit scene of a Drive Impact in certain circumstances.
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="jamie">Jamie</h2>

<br>

><h4>Forward/Backward walk</h4>
<p>
Fixed an issue where Jamie would not move on the 1st frame of a forward or backward movement if he was at drink level 4.
</p>

><h4>Tensei Kick (↓+2 Kicks)</h4>
<p>
Fixed an issue where if The Devil's Song had been activated, Tensei Kick on its fastest input started up 1 frame slower.
</p>

><h4>Ransui Haze (→+Heavy Kick, ←+Heavy Kick, Punch)</h4>
<p>
Fixed an issue where after The Devil's Song has run out and the player uses Ransui Haze to raise their drink level, the base attack level would not increase.
</p>

><h4>Shared adjustment: Attacks hitting with an opponent behind you</h4>
<p>
Fixed an issue where the following attacks would hit an opponent behind Jamie.
<ul>
<li>Standing Light Kick (rapid cancel version)</li>
<li>Breakin'</li>
<li>Getsuga Saiho</li>
</ul>
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attacks during Burnout has been adjusted.

■ Crouching Medium Kick<br>From 1000 to 2000
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Standing Heavy Punch</li>
<li>Crouching Heavy Kick</li>
<li>Ransui Haze (→+Heavy Kick, ←+Heavy Kick, Punch）</li>
<li>Freeflow Strikes (drink level 4) (↓↘→+Punch)</li>
<li>Bakkai (↓↘→+K)(↓↘→+K)</li>
<li>Breakin'</li>
<li>Getsuga Saiho</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="manon">Manon</h2>

<br>

><h4>Drive Impact</h4>
<p>
Fixed an issue where a Drive Impact clash would occur even if Manon's Drive Impact was activated 1 frame later than the opponent's.
</p>

><h4>Heavy/Overdrive Rond-point (↓↘→+Kick)</h4>
<p>

1. The 2nd hit of the Heavy version on Punish Counter had an incorrect damage value assigned to it, so it has been changed from 600 to 480.

2. Fixed an issue where it was possible to cancel the end of the Heavy or Overdrive version when it was blocked.
</p>

><h4>Overdrive Renverse (↓↘→+2 Punches)</h4>
<p>
Fixed an issue where the recovery difference was 1 frame slower after hit when Manon medal level was 3 or 4.
</p>

><h4>Arabesque (SA1)</h4>
<p>
Fixed an issue where certain moves and this move would miss each other when both active. This attack will now not pass through an opponent until it hits them.
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attack during Burnout has been adjusted.

■ Arabesque<br>From 1250 to 2500
</p>

><h4>Shared adjustment: Attacks hitting with an opponent behind you</h4>
<p>
Fixed an issue where the following attacks would hit an opponent behind Manon.

<ul>
<li>Standing Light Kick</li>
<li>Pas de Deux</li>
</ul>
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Light/Medium Dégagé (↓↙←+Kick)</li>
<li>Rond-point (↓↘→+Kick)</li>
<li>Étoile</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="kimberly">Kimberly</h2>

<br>

><h4>Light Punch, Medium Punch</h4>
<p>
The amount of Super Art gauge gained on block was not half of the amount gained on hit, so it has been adjusted from 150 to 200.
</p>

><h4>Medium/Heavy/Overdrive Vagabond Edge (↓↘→+Punch)</h4>
<p>
The amount of Drive Gauge lost when an opponent blocked the 2nd hit of this attack had an older value, so it has been adjusted from 2000 to 4000.
</p>

><h4>Bushin Beats (SA1)<br>Bushin Thunderous Beats (SA1)<br>Bushin Scramble (SA2)<br>Soaring Bushin Scramble (SA2)<br>Bushin Ninjastar Cypher (SA3/CA)</h4>
<p>
Fixed an issue where if certain attacks hit an opponent while they were in stun and had a full Drive Gauge, they would recover from Burnout upon getting hit.

<ul>
<li>Bushin Beats</li>
<li>Bushin Thunderous Beats</li>
<li>Bushin Scramble</li>
<li>Soaring Bushin Scramble</li>
<li>Bushin Ninjastar Cypher</li>
</ul>
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attacks during Burnout has been adjusted.

■ Neck Hunter (↓↘→+Kick, Heavy Kick)<br>From 2000 to 4000

■ Overdrive Neck Hunter (↓↘→+2 Kicks, Heavy Kick)<br>From 1250 x 2 to 2500 x 2

■ Shadow Slide (↓↘→+Kick, Medium Kick)<br>From 2000 to 4000

■ Overdrive Shadow Slide (↓↘→+2 Kicks, Medium Kick)<br>From 1250 x 2 to 2500 x 2
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Normal/Overdrive Arc Step (↓↘→+Kick)</li>
<li>Overdrive Torso Cleaver (↓↘→+2 Kicks, Light Kick)</li>
<li>Overdrive Shadow Slide (↓↘→+2 Kicks, Medium Kick)</li>
<li>Overdrive Neck Hunter(↓↘→+2 Kicks, Heavy Kick)</li>
<li>Normal/Overdrive Aerial Bushin Senpukyaku (in mid-air, ↓↙←+Kick)</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="marisa">Marisa</h2>

<br>

><h4>Modern Controls</h4>
<p>
Fixed an issue where you couldn't cancel Gladius from a normal or unique attack using Forward+Special Move button.
</p>

><h4>Caelum Arc (↓+Heavy Punch during a vertical jump)</h4>
<p>

1. Fixed an issue where if you hit an opponent from behind, the recovery would be much longer.
<ul>
<li>On hit: From 27 frames to 19 frames</li>
<li>On block: From 23 frames to 15 frames</li>
</ul>

2. Fixed an issue where if you forced an opponent to block from behind, their orientation would be reversed if they were in Burnout.

3. Fixed an issue where you could cancel the landing recovery with another move.

</p>

><h4>Dimachaerus (↓↙←+Punch)</h4>
<p>
Fixed an issue where the Super Art gauge gain on block was not half of what it was on hit.
</p>

><h4>Javelin of Marisa (SA1, charged version)</h4>
<p>
Fixed an issue where damage would increase on counter or Punish Counter only during the 5th and 6th active frames of the attack.
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attacks during Burnout has been adjusted.

■ Crouching Heavy Kick<br>From 1500 to 3000

■ Charged Crouching Heavy Kick<br>From 4000 to 8000

■ Charged Jumping Heavy Punch<br>From 3000 to 6000

■ Charged Jumping Heavy Kick<br>From 3000 to 6000

■ Charged Caelum Arc (↓+Heavy Punch during a vertical jump)<br>From 3000 to 6000

■ Novacula Swipe (→+Medium Punch, Heavy Punch)<br>From 2500 to 5000
</p>

><h4>Shared adjustment: Attacks hitting with an opponent behind you</h4>
<p>

Fixed an issue where the following attacks would hit an opponent behind Marisa.
<ul>
<li>Gladius (↓↘→+P)</li>
<li>Phalanx (→↓↘+P)</li>
<li>Quadriga (↓↘→+K)</li>
</ul>

</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following move has been adjusted.
<ul>
<li>Meteorite</li>
</ul>
</p>


<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="lily">Lily</h2>

<br>

><h4>Jumping</h4>
<p>
Fixed an issue where it was possible to perform special moves or Super Arts (except for 360 command throws) until the 5th frame of Lily's jump.
</p>

><h4>Thunderbird (SA2)<br>Soaring Thunderbird (SA2)</h4>
<p>

1. Adjusted the Drive Gauge gain when parrying the Windclad version of Thunderbird and Soaring Thunderbird, as it was less than when parrying the normal version of those moves.

2. This attack would miss more than expected when incorporated into mid-air combos, so the hitbox of the attack has been expanded upwards only when hitting an opponent already reeling from damage, allowing for multiple hits to land easier.

</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attack during Burnout has been adjusted.

■ Great Spin (↓+Heavy Punch during a jump)<br>From 2000 to 4000
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Crouching Heavy Punch</li>
<li>Crouching Heavy Kick</li>
<li>Overdrive/Windclad/Overdrive Windclad Tomahawk Buster (→↓↘+Punch)</li>
<li>Overdrive/Windclad/Overdrive Windclad Condor Dive (2 Punches during a jump)</li>
<li>Breezing Hawk</li>
<li>Thunderbird</li>
<li>Soaring Thunderbird</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="jp">JP</h2>

<br>

><h4>Overdrive Embrace (↓↙←+2 Kicks)</h4>
<p>
Fixed an issue where JP would still be able to move around during the cutscene when a projectile with a long trade time pierces and hits him.
</p>

><h4>Heavy Stribog (↓↘→+Heavy Punch)</h4>
<p>
Fixed an issue where JP's Drive Gauge increase gain would only be half when the first attack is blocked by the opponent while they are in Burnout.
</p>

><h4>Chornobog (SA1)</h4>
<p>
No Drive Gauge was gained when parrying the first attack, so it has been redistributed as follows.

<ul>
<li>1st attack: From 0 to 10,000</li>
<li>2nd attack: From 20,000 to 10,000</li>
</ul>

No changes were made for when only the 2nd attack is parried.
</p>

><h4>Lovushka (SA2)</h4>
<p>
Fixed an issue where the final attack would come out when JP is hit by an attack with a short knockback time immediately after performing this move.
</p>

><h4>Interdiction (SA3/CA)</h4>
<p>
Fixed an issue where if this attack hits an opponent while they were in stun and had a full Drive Gauge, they would recover from Burnout upon getting hit.
</p>

><h4>Shared adjustment: Attacks hitting with an opponent behind you</h4>
<p>
Fixed an issue where the following attacks would hit an opponent behind JP.

<ul>
<li>Standing Light Kick</li>
<li>Stribog (↓↘→+Punch)</li>
</ul>
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attacks during Burnout has been adjusted.

■ Medium/Heavy Torbalan (↓↘→+Kick)<br>From 1250 to 2500

■ Lovushka (2nd - 4th hit)<br>From 500 to 1000
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Bylina (→+Heavy Kick)</li>
<li>Chornobog</li>
<li>Lovushka</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="juri">Juri</h2>

<br>

><h4>Modern Controls</h4>
<p>
Fixed an issue where the rapid cancel version of crouching light attack would be performed when attempting to perform Assist Combo 1 from crouching light attack while Feng Shui Engine was active.
</p>

><h4>Assisted Combo 3</h4>
<p>
Fixed an issue where 2 blocks of Drive Gauge were used when transitioning into Overdrive Go Ohsatsu from Overdrive Ankensatsu via Assist Combo.
</p>

><h4>Shared adjustment: Attacks hitting with an opponent behind you</h4>
<p>
Fixed an issue where the following attack would hit an opponent behind.

<ul>
<li>Feng Shui Engine's initial forward charge</li>
</ul>
</p>

><h4>Senkai Kick (SA2 boosted) (→+Medium Kick）</h4>
<p>
When Senkai Kick connected as a chain combo while Feng Shui Engine was active, the Drive Gauge fluctuations would not be in accordance with the chain combo value, so they have been fixed to the following values.

■ Drive Gauge gain on hit<br>From 500 to 375

■ Drive Gauge loss on block<br>From 1250 to 625

■ Drive Gauge loss on Punish Counter<br>From 2000 to 1250
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Standing Medium Kick</li>
<li>Renko Kicks (→+Heavy Punch)</li>
<li>Korenzan (←+Heavy Kick)</li>
<li>Normal/Overdrive Tensenrin (→↓↘+Punch)</li>
<li>Boosted/Overdrive Go Ohsatsu (→↓↘+Heavy Kick)</li>
<li>Sakkai Fuhazan</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="dee-jay">Dee Jay</h2>

<br>

><h4>Assisted Combo 1</h4>
<p>
Fixed an issue where the Quick Rolling Sobat would not be performed by pressing forward and the Special Move button from the first hit.
</p>

><h4>Assisted Combo 3</h4>
<p>
Fixed an issue where Maximum Strike would have additional scaling added to it if the 3rd attack's input was late.
</p>

><h4>Overdrive Air Slasher (Charge ←, →+2 Punches)</h4>
<p>
Implemented a fix so only Overdrive Air Slasher is performed when holding back and using the Special Move button in Modern Controls. Previously, if a charge was ready, Overdrive Jus Cool or Overdrive Double Rolling Sobat could not be performed.
</p>

><h4>Speedy Maracas (↓↓+2 Punches)</h4>
<p>

1. In Street Fighter 6, when going from a Punish Counter state and transitioning to a move that can absorb attacks, the player is essentially in a Punish Counter state from the beginning. This is to prevent players from making mistakes during their combo selection, etc. when aiming for an opponent's recovery period.<br><br>By transitioning from Air Slasher to Speedy Maracas, Air Slasher's Punish Counter state was being overwritten by a Counter state, so we have fixed this issue so the transition to Speedy Marcas will be in a Punish Counter state.

2. Fixed an issue so when Air Slasher hits on Counter/Punish Counter, is parried, or runs into Super Armor, you cannot transition into Speedy Maracas.
</p>

><h4>Marvelous Sunrise Festival (SA2)<br>Headliner Sunrise Festival (SA2)</h4>
<p>
Fixed an issue where the first frame of the normal attack could not be kara-canceled*.

*Kara Cancel: Canceling the start up of a move into another move.
</p>

><h4>Drive Reversal</h4>
<p>
Updated the hurtbox to match the appearance of the attack from the end of its active frames to the end of the attack. Originally, the hurtbox was too small compared to the reach of the attack, making it extremely difficult to counter attack compared to other characters.
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attacks during Burnout has been adjusted.

■ Normal/Overdrive Funky Slicer (↓↙←+Kick, Light Kick)<br>From 2000 to 4000

■ Normal/Overdrive Waning Moon (↓↙←+Kick, Medium Kick)<br>From 2000 to 4000
</p>

><h4>Shared adjustment: Chip damage during Burnout</h4>
<p>
The amount of chip damage done when an opponent blocks the following attacks during Burnout has been adjusted.

■ Machine Gun Uppercut (↓↙←+Punch)<br>Light: From 200 to 37<br>Medium: From 200 to 25<br>Heavy: From 200 to 25<br>Overdrive: From 200 to 25

■ Quick Rolling Sobat (↓↘→+Medium Kick)<br>From 200 to 250

■ Double Rolling Sobat (↓↘→+Heavy Kick)<br>From 150 x 2 to 175 x 2

■ Medium/Heavy Jackknife Maximum (Charge ↓, ↑+Kick)<br>From 125 to 150
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attacks during Burnout has been adjusted.

■ Normal/Overdrive Funky Slicer (↓↙←+Kick, Light Kick)<br>From 2000 to 4000

■ Normal/Overdrive Waning Moon (↓↙←+Kick, Medium Kick)<br>From 2000 to 4000
</p>

><h4>Shared adjustment: Chip damage during Burnout</h4>
<p>
The amount of chip damage done when an opponent blocks the following attacks during Burnout has been adjusted.

■ Machine Gun Uppercut (↓↙←+Punch)<br>Light: From 200 to 37<br>Medium: From 200 to 25<br>Heavy: From 200 to 25<br>Overdrive: From 200 to 25

■ Quick Rolling Sobat (↓↘→+Medium Kick)<br>From 200 to 250

■ Double Rolling Sobat (↓↘→+Heavy Kick)<br>From 150 x 2 to 175 x 2

■ Medium/Heavy Jackknife Maximum (Charge ↓, ↑+Kick)<br>From 125 to 150
</p>

><h4>Shared adjustment: Attacks hitting with an opponent behind you</h4>
<p>
Fixed an issue where the following attacks would hit an opponent behind Dee Jay.

<ul>
<li>Standing Light Kick</li>
<li>1st hit of Machine Gun Uppercut (↓↙←+Punch)</li>
<li>1st hit of Sunrise Festival</li>
<li>Weekend Pleasure</li>
</ul>
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Face Breaker (←+Heavy Kick)</li>
<li>Double Rolling Sobat (↓↘→+Heavy Kick)</li>
<li>Overdrive Rolling Sobat (↓↘→+2 Kicks)</li>
<li>Marvelous Sunrise Festival</li>
<li>Headliner Sunrise Festival</li>
</ul>
</p>


<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="cammy">Cammy</h2>

<br>

><h4>Lifting Uppercut (←+Medium Punch)</h4>
<p>
Fixed an issue where, when an opponent's wake-up overlaps with the latter half of the active frames of this attack, a crouching opponent is able to block certain parts of the attack that they normally should not be able to.
</p>

><h4>Killer Bee Spin (SA2)<br>Aerial Killer Bee Spin (SA2)</h4>
<p>

1. Fixed an issue where Drive Gauge consumption while connecting with this attack while standing on the ground was more than other level 2 Super Arts.

2. During a mid-air hit the Drive Gauge decrease was small even during its biggest attack, so the final hit now drains 3700 instead of 3000.
</p>

><h4>Killer Bee Spin (SA2)<br>Aerial Killer Bee Spin (SA2)<br>Delta Red Assault (SA3/CA)</h4>
<p>
Fixed an issue where if these attacks hit an opponent while they were in stun and had a full Drive Gauge, they would recover from Burnout upon getting hit.

<ul>
<li>Killer Bee Spin</li>
<li>Aerial Killer Bee Spin</li>
<li>Delta Red Assault</li>
</ul>
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attacks during Burnout has been adjusted.

■ Delayed Ripper (→+Heavy Kick)<br>From 4000 to 2000

■Swing Combination (Heavy Punch, Heavy Kick)
2nd hit: From 4000 to 2000

■ Razor's Edge Slicer (↓↘→+Punch, No input)<br>Normal version: From1500 to 3000<br>Charged version: From 2500 to 5000<br>Overdrive version: From 2500 to 5000

■ Reverse Edge (↓↘→+Punch, ↓+Kick)<br>Normal version: From 2000 to 4000<br>Charged version: From 3000 to 6000<br>Overdrive version: From 4000 to 8000
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Heavy/Overdrive/Charged Spiral Arrow (↓↘→+Kick)</li>
<li>Overdrive/Charged Razor's Edge Slicer (↓↘→+Punch, No input)</li>
<li>Overdrive/Charged Reverse Edge (↓↘→+Punch,↓+Kick)</li>
<li>Spin Drive Smasher</li>
<li>Killer Bee Spin</li>
<li>Aerial Killer Bee Spin</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="ryu">Ryu</h2>

<br>

><h4>Crouching Heavy Punch</h4>
<p>
Fixed an issue where the animation would go back if the attack hit on the 2nd active frame.
</p>

><h4>Fuwa Triple Strike (Medium Punch, Light Kick, Heavy Kick)</h4>
<p>

1. The Drive Gauge decrease for the final hit on Punish Counter has been changed from 0 to 10,000.

2. The 2nd hit of this string was increasing the opponent's Drive Gauge by 2,000 on Punish Counter, but this has been changed so it now decreases their Drive Gauge by 2,000 instead.
</p>

><h4>High Double Strike</h4>
<p>
The Drive Gauge decrease on Punish Counter has been changed from 0 to 10,000.
</p>

><h4>Shin Hashogeki (SA2)</h4>
<p>
Applies only when using Shin Hashogeki charged to Level 2 or 3 during a juggle combo.

There was a situation where the attack hitbox would not hit an opponent if the player was right under them, so the following adjustments have been made to alleviate the issue.

<ul>
<li>The pushbox has been expanded upwards from the time the button is released until the end of the attack's active frames.</li>
<li>The attack's hitbox has been expanded inwards.</li>
</ul>
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attacks during Burnout has been adjusted.

■ Jumping Medium Punch<br>2nd hit: From 1500 to 750

■ Collarbone Breaker (→+Medium Punch)<br>2nd hit: From 1250 to 625

■ Known Issue<br>When only the 2nd hit of Collarbone Breaker lands the attack is considered a mid-level/overhead hit, but in this situation the 625 Drive Gauge increase for when the move is considered a high level hit is applied. This issue is scheduled to be resolved in the next update.
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Jumping Medium Punch</li>
<li>Collarbone Breaker (→+Medium Punch)</li>
<li>Solar Plexus Strike (→+Heavy Punch)</li>
<li>Axe Kick (←+Heavy Kick)</li>
<li>Overdrive Shoryuken (→↓↘+2 Punches)</li>
<li>Medium/Heavy/Overdrive Tatsumaki Senpu-kyaku (↓↙←+Kick)</li>
<li>Shinku Hadoken</li>
<li>Shin Shoryuken</li>
</ul>
</p>

><h4>Shared adjustment: Attacks hitting with an opponent behind you</h4>
<p>
Fixed an issue where the following attacks would hit an opponent behind Ryu.

<ul>
<li>Standing Light Kick</li>
<li>2nd hit of Fuwa Triple Strike</li>
<li>Final hit of Shin Shoryuken</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="e.-honda">E. Honda</h2>

<br>

><h4>Standing Heavy Punch</h4>
<p>
Fixed an issue where the distance covered when using this move out of a Drive Rush with Sumo Spirit stocked was much greater than intended.
</p>

><h4>Crouching Heavy Punch</h4>
<p>
Fixed an issue where the distance covered when using this move out of a Drive Rush with Sumo Spirit stocked was much smaller than intended.
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attacks during Burnout has been adjusted.

■ Powerstomp (↘+Heavy Kick)<br>From 2500 to 5000

■ Harai Kick (→+Heavy Kick)<br>From 3000 to 6000

■ Toko Shizume (Medium Punch, ↘+Heavy Kick)<br>From 2500 to 5000

■ Sumo Splash (Charge ↓, ↑+Kick)<br>2nd hit: From 4000 to 8000
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Overdrive Sumo Headbutt (Charge ←, →+2 Punches)</li>
<li>Teppo Triple Slap (↓↘→+Kick, Punch)</li>
<li>Taiho Cannon Lift (↓↘→+K,↓+Punch)</li>
<li>Hundred Hand Slap (↓↙←+P)</li>
<li>Ultimate Killer Headram</li>
<li>The Final Bout</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="blanka">Blanka</h2>

<br>

><h4>Crouching Heavy Kick</h4>
<p>
Adjusted the Super Art gauge gain on block from 600 to 500.
</p>

><h4>Rock Crusher (→+Medium Punch)</h4>
<p>
Adjusted the Super Art gauge gain on block from 500 (250/250) to 250 (125/125).
</p>

><h4>Double Knee Bombs (→+Medium Kick)</h4>
<p>
Adjusted the Super Art gauge gain on block from 500 (250/250) to 250 (125/125).
</p>

><h4>Overdrive Aerial Rolling Attack (Charge ←, →+2 Punches during a jump)</h4>
<p>
Adjusted the Super Art gauge when blocking the first hit from 650 to 450.
</p>

><h4>Overdrive Backstep Rolling Attack (→↘↓↙←+2 Kicks)</h4>
<p>

1. Adjusted the opponent's Drive Gauge gain when parrying the first attack from 5000 to 10000.

2. Adjusted the opponent's Drive Gauge gain when parrying the 2nd and 3rd attacks from 2500 to 5000.
</p>

><h4>Shared adjustment: Attacks hitting with an opponent behind you</h4>
<p>
Fixed an issue where the following attacks would hit an opponent behind Blanka.

<ul>
<li>Standing Heavy Kick</li>
<li>Double Knee Bomber (→+Medium Kick)</li>
<li>1st attack of Overdrive Backstep Rolling Attack (→↘↓↙←+2 Kicks)</li>
<li>SA2 boosted Light Rolling Attack (Charge ←, →+Light Punch)</li>
<li>Ground Shave Cannonball</li>
</ul>
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Rock Crusher (→+Medium Punch)</li>
<li>Double Knee Bomber (→+Medium Kick)</li>
<li>Overdrive Backstep Rolling Attack (→↘↓↙←+2 Kicks)</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="guile">Guile</h2>

<br>

><h4>Crouching Light Kick</h4>
<p>
Fixed an issue where the attack couldn't be rapid canceled if it was absorbed by super armor.
</p>

><h4>Double Shot (↓+Medium Punch, ↓+Medium Punch)</h4>
<p>
Fixed an issue where the advantage on block was 5 frames more than blocking it normally if the opponent blocked this attack while in Burnout.
</p>

><h4>Overdrive Sonic Cross (↓↙←+2 Punches)</h4>
<p>
Adjusted the opponent's Drive Gauge gain when parrying this attack from 5100 to 5000.
</p>

><h4>Sonic Hurricane (SA1)</h4>
<p>

1. Adjusted the opponent's Drive Gauge gain when blocking this attack from 2520 to 2500.

2. Fixed an issue where the Heavy version's projectile clash hitbox was significantly different from its visual appearance.
</p>

><h4>Crossfire Somersault (SA3/CA)</h4>
<p>
Fixed an issue where if this attack hits an opponent while they were in stun and had a full Drive Gauge, they would recover from Burnout upon getting hit.
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Overdrive Somersault Kick (Charge ↓, ↑+2 Kicks)</li>
<li>Sonic Hurricane</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="ken">Ken</h2>

<br>

><h4>Drive Reversal</h4>
<p>
Fixed an issue where Ken's invincibility would last longer than other characters on hit.
</p>

><h4>Shoryuken (Quick Dash version) (2 Kicks, →↓↘+Punch)</h4>
<p>
The amount of Super Art gauge gained by blocking the 1st and 2nd hit was not half of the amount gained on hit, so it has been adjusted from 300 to 200.
</p>

><h4>Overdrive Hadoken (↓↘→+2 Punches)</h4>
<p>
On Punish Counter, the opponent's Drive Gauge decrease was handled differently from other projectiles, so the values have been adjusted.

<ul>
<li>1st hit: From 5000 to 2500</li>
<li>2nd hit: From 0 to 2500</li>
</ul>
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attacks during Burnout has been adjusted.

■ Thunder Kick (2 Kicks, Medium Kick)<br>From 1250 to 2500

■ Normal/Overdrive Kazekama Shin Kick (↓↘→+Kick, Light Kick)<br>From 1500 to 3000

■ Normal/Overdrive Gorai Axe Kick (↓↘→+Kick, Medium Kick)<br>From 1250 to 2500
</p>

><h4>Shared adjustment: Chip damage during Burnout</h4>
<p>
The amount of chip damage done when an opponent blocks the following attack during Burnout has been adjusted.

■ Light Dragonlash Kick (→↓↘+Light Kick)<br>250 > 237
</p>

><h4>Shared adjustment: Attacks hitting with an opponent behind you</h4>
<p>
Fixed an issue where the following attacks would hit an opponent behind Ken.

<ul>
<li>Forward Step Kick (2 Kicks, Heavy Kick)</li>
<li>Jinrai Kick (↓↘→+Kick)</li>
<li>Medium/Heavy Tatsumaki Senpu-kyaku (↓↙←+Kick)</li>
<li>Forward attack hitbox on the Quick Dash version of Tatsumaki Senpu-kyaku</li>
<li>Dragonlash Flame</li>
</ul>
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Medium/Heavy/Overdrive/Quick Dash Shoryuken (→↓↘+Punch)</li>
<li>Medium/Heavy/Overdrive/Quick Dash Tatsumaki Senpu-kyaku (↓↙←+Kick)</li>
<li>Shippu Jinrai-kyaku</li>
<li>Shinryu Reppa</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="chun-li">Chun-Li</h2>

<br>

><h4>Jumping Heavy Punch</h4>
<p>
Jumping Heavy Punch's damage was 800 on grounded opponents and 500 on airborne opponents, but the damage on counter/Punish Counter on airborne opponents was set to the grounded damage of 960, so it has been adjusted to 600.
</p>

><h4>Lotus Punch (↓↙←+Punch, Heavy Punch)</h4>
<p>

1. The hurtbox on the head unintentionally shrank between frames 3 - 28, so it has been expanded

2. The 2nd hit was considered a high attack if the first attack whiffed, but it has been fixed to now be a mid-level/overhead attack. The 2nd hit is still a high attack if the 1st attack hits.
</p>

><h4>Overdrive Tensho Kicks (↓↓+2 Kicks)</h4>
<p>
Fixed an issue where Chun-Li would move a considerable distance upon landing if the players switched sides when the 2nd attack hit.
</p>

><h4>Kikosho (SA1)</h4>
<p>
Fixed an issue where hits except for the final one would not kill an airborne opponent.
</p>

><h4>Hoyoku-sen (SA2)</h4>
<p>
Fixed an issue where the Assist Combo would be interrupted if the next input was performed with specific timing, after performing Hoyoku-sen via Assist Combo.
</p>

><h4>Soten Ranka (SA3)</h4>
<p>
The Drive Gauge decrease when blocking the 2nd hit and later attacks was 0, so those values have been adjusted.

■ Super Art 3<br>1st hit: From 7500 to 6500<br>2nd and 3rd hit: From 0 to 500

■ Critical Art<br>1st hit: From 10000 to 9000<br>2nd and 3rd hit: From 0 to 500
</p>

><h4>Shared adjustment: Chip damage during Burnout</h4>
<p>
The amount of chip damage done when an opponent blocks the following attack during Burnout has been adjusted.

■ Medium Spinning Bird Kick (Charge ↓, ↑+Medium Kick)<br>From 275 to 300
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attack during Burnout has been adjusted.

■ Lotus Fist (↓↙←+Punch, Heavy Punch)<br>2nd hit: From 2500 to 1250

■ Known Issue<br>The 2nd hit of Lotus Fist is considered a mid-level/overhead hit when the only that hit lands, but in this situation the Drive Gauge increase of 1250, for when the move is considered a high level hit, is applied. This issue is scheduled to be resolved in the next update.
</p>

><h4>Shared adjustment: Attacks hitting with an opponent behind you</h4>
<p>
Fixed an issue where the following attacks would hit an opponent behind Chun-Li.

<ul>
<li>Lightning Kicks (↓↘→+Kick)</li>
<li>Lightning Kick Barrage (↓↘→+2 Kicks, 2 Kicks)</li>
<li>Hazanshu (↓↙←+Kick)</li>
<li>Spinning Bird Kick (Charge ↓, ↑+Kick)</li>
<li>Soten Ranka</li>
</ul>
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Crouching Heavy Punch</li>
<li>Lotus Fist (↓↙←+Punch, Heavy Punch)</li>
<li>Lightning Kicks (↓↘→+Kick)</li>
<li>Lightning Kick Barrage (↓↘→+2 Kicks, 2 Kicks)</li>
<li>Aerial Lightning Kicks (in mid-air, ↓↘→+Kick)</li>
<li>Spinning Bird Kick (Charge ↓, ↑+Kick)</li>
<li>Drive Reversal</li>
<li>Kikosho</li>
<li>Aerial Kikosho</li>
<li>Hoyoku-sen</li>
<li>Soten Ranka</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="zangief">Zangief</h2>

<br>

><h4>Smetana Dropkick (↘+Heavy Kick)</h4>
<p>
The amount of Drive Gauge lost when an opponent blocked this attack was unintentionally set at a low value, so it has been corrected from 3000 to 6000.
</p>

><h4>Borscht Dynamite (360+Kick while jumping)</h4>
<p>

1. This attack would come out unexpectedly when attempting to do a jumping attack, so the input recognition frames* have been changed from 20 to 12.

2. Fixed an issue where the amount of Super Art gauge gain on Punish Counter was 150 less than on normal hit.

*Input recognition frame is the the number of frames you must input the next command in order for the game to recognize you are performing a specific attack.

ex. When performing a Hadoken (↓↘→+Punch), you must input Down then Down-Forward within a certain number of frames for the game to recognize the input. This is known as the Input recognition frame.
</p>

><h4>Overdrive Double Lariat (3 Punches)</h4>
<p>
Adjusted the amount of Super Art gauge gain on the 2nd hit and after from 300 to 250.
</p>

><h4>Aerial Russian Slam (SA1)</h4>
<p>

1. Fixed an issue where Drive Gauge loss would be 60 less on hit when using Modern Controls' Special button to perform the move.

2. Fixed an issue where if this attack hits an opponent while they were in stun and had a full Drive Gauge, they would recover from Burnout upon getting hit.
</p>

><h4>Cyclone Lariat (SA2)</h4>
<p>

1. Made the following adjustments as the opponent would fly over Zangief during a mid-air hit, causing attacks after the 2nd hit to miss.
<ul>
<li>When the attack hitbox connects, the pushbox will expand upwards.</li>
<li>Attack hitboxes from the 2nd attack and later will have their range expanded upwards.</li>
</ul>

2. Fixed an issue where the attack's effect would remain when interrupted by an opponent's attack on startup.

3. Fixed the opponent's reaction animation on the final hit.
</p>

><h4>Shared adjustment: Drive Gauge gain during Burnout</h4>
<p>
The Drive Gauge increase gained by the opponent when they block the following attacks during Burnout has been adjusted.

■ Crouching Medium Kick<br>From 2500 to 5000

■ Smetana Dropkick (↘+Heavy Kick)<br>From 1500 to 3000
</p>

><h4>Shared adjustment: Attacks hitting with an opponent behind you</h4>
<p>
Fixed an issue where the following attack would hit an opponent behind Zangief.

<ul>
<li>Standing Light Kick</li>
</ul>
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Normal/Overdrive Double Lariat (2 Punches)</li>
<li>Cyclone Lariat</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="dhalsim">Dhalsim</h2>

<br>

><h4>Standing Medium Kick</h4>
<p>
The amount of Super Art gauge gain on Punish Counter was higher than on a normal hit, so it's been adjusted from 700 to 500 to match.
</p>

><h4>Jumping Medium Kick</h4>
<p>
The attack property for the tip of the attack has been corrected to be a mid-level/Overhead instead of a high attack.
</p>

><h4>Jumping Heavy Punch</h4>
<p>
Fixed an issue where the recovery frame difference does not change if an opponent blocks this attack while in Burnout.
</p>

><h4>Aerial Yoga Teleport (← or →+3 Punches or 3 Kicks while jumping)</h4>
<p>

1. Fixed an issue where Dhalsim would gain Super Art gauge upon activation.

2. Fixed an issue where after performing the Punch version, if Dhalsim does nothing while in mid-air, the landing timing would be 1 frame slower compared to the Kick version.
</p>

><h4>Heavy Yoga Flame (→↘↓↙←+Heavy Punch)</h4>
<p>
Fixed an issue where projectile clash would only occur twice.
</p>

><h4>Yoga Arch (↓↘→+Kick)</h4>
<p>
Fixed an issue where Initial Scaling and Combo Scaling would be applied when the opponent is only hit by the detonation from the projectile landing on the ground.
</p>

><h4>Overdrive Yoga Comet (→↘↓↙←+2 Punches while jumping)</h4>
<p>
Fixed an issue where Dhalsim couldn't cancel into other mid-air special moves before landing if the player plinked* the two attack buttons by 1 frame when performing the attack.

*Plinking: Quickly pressing two or more buttons exactly one frame apart
</p>

><h4>Yoga Sunburst (SA2)</h4>
<p>
Fixed an issue where the fireball could not be seen if only the final attack missed.
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Overdrive Yoga Blast (→↘↓↙←+2 Kicks)</li>
<li>Drive Reversal</li>
<li>Yoga Inferno</li>
<li>Yoga Sunburst</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="rashid">Rashid</h2>

<br>

><h4>Forward Dash</h4>
<p>

1. Fixed the beginning animation as it was difficult to visually recognize the technique.

2. Fixed an issue where the technique's overall frame data would change depending on the inputs during the technique.

3. Fixed an issue where after recovery frames end and Rashid is thrown, Rashid would not be able to perform a throw escape.
</p>

><h4>Desert Slider (Light Punch+Light Kick during a jump)</h4>
<p>
Drive Gauge gain on block was different from a normal hit, so it has been adjusted from 2000 to 900.
</p>

><h4>Light Spinning Mixer (air current boosted) (↓↘→+Light Punch)</h4>
<p>
Drive Gauge gain on block was different from a normal hit, so it has been adjusted from 2000 to 900.
</p>

><h4>Medium Spinning Mixer (air current boosted) (↓↘→+Medium Punch)</h4>
<p>

1. Made the following adjustments as the damage on Punish Counter was 120%
<ul>
<li>1st - 2nd hit: From 360 to 240</li>
<li>3rd - 10th hit: From 240 to 120</li>
</ul>

2. Made the following adjustments as the Drive Gauge gain on Punish Counter differed from normal hit.
<ul>
<li>1st - 2nd hit: From 0 to 150</li>
<li>3rd - 10th hit: From 200 to 150</li>
<li>Final hit: From 200 to 500</li>
</ul>
</p>

><h4>Overdrive Spinning Mixer (air current boosted) (↓↘→+2 Punches)</h4>
<p>

1. Made the following adjustments as the damage on Punish Counter was 120%
<ul>
<li>1st - 2nd hit: From 360 to 240</li>
<li>3rd - 10th hit: From 240 to 120</li>
</ul>

2. Adjusted the Super Art gauge gain after the 3rd hit on Punish Counter as it was more than a normal hit. The value was changed from 100 to 50.
3. Fixed an issue where Rashid's Drive Gauge would increase when a hit after the 3rd hit landed as a Punish Counter.
4. Adjusted the Drive Gauge increase when parrying this move from 12,000 to 10,000.

><h4>Yoga Arch (↓↘→+Kick)</h4>
<p>
Fixed an issue where Initial Scaling and Combo Scaling would be applied when the opponent is only hit by the detonation from the projectile landing on the ground.
</p>

><h4>Overdrive Eagle Spike (air current boosted) (↓↙←+2 Kicks)</h4>
<p>
Fixed an issue where if Ysaar is placed behind the opponent and Rashid performs Overdrive Eagle Spike, the Eagle Spike would not hit the opponent and go through them instead.
</p>

><h4>Overdrive Arabian Skyhigh (↓↙←+2 Kicks during a forward jump)</h4>
<p>
Fixed an issue where Rashid's Drive Gauge would increase when this attack was blocked.
</p>

><h4>Tempest Moon (air current boosted) (→+Kick during Run)</h4>
<p>
Made the following adjustments to Drive Gauge increase on parry.

<ul>
<li>1st hit: From 10000 to 5000</li>
<li>2nd - 3rd hit: From 5000 to 2500</li>
</ul>
</p>

><h4>Drive Impact</h4>
<p>
Fixed an issue where under certain conditions, when the Drive Impact hit cutscene occurs, the opponent would not take any damage.
</p>

><h4>Super Art gauge gain on block</h4>
<p>
The amount of Super Art gauge gained on block for the following attacks was not half of the amount gained on hit, so they have been adjusted.

■ Flapping Spin (→+Medium P)<br>From 500 to 250

■ Spinning Mixer (air current boosted) (↓↘→+Punch)<br>Light: From 550 to 400<br>Medium: From 350 to 225 (When the opponent blocks this standing)<br>Heavy: From 50 to 55

■ Eagle Spike (↓↙←+Kick)<br>Medium: From 500 to 550<br>Heavy: From 500 to 600<br>Overdrive: From 500 to 250 (Only when the opponent is in Burnout)

■【Eagle Spike (air current boosted) (↓↙←+K)<br>Medium/Heavy: From 500 to 600

■ Assault Nail (↓↙←+Punch, →Kick, Kick)<br>From 250 to 150

■ Arabian Skyhigh (↓↙←+Kick during a forward jump)<br>From 500 to 250

■ Light/Medium/Heavy Arabian Cyclone (↓↙←+Punch)<br>From 600 to 300

■ Tempest Moon (→+Kick during Run)<br>From 600 to 300
</p>

><h4>Shared adjustment: Chip damage during Burnout</h4>
<p>
The amount of chip damage done when an opponent blocks the following attacks during Burnout has been adjusted.

■ Assault Nail (↓↙←+Punch, →Kick, Kick)<br>From 200 to 150

■ Arabian Skyhigh (↓↙←+Kick during a forward jump)<br>Light: From 200 to 150<br>Medium: From 225 to 175<br>Heavy: From 250 to 200

■ Overdrive Arabian Cyclone (↓↙←+2 Punches)<br>From 200+25 to 100+100

■ Medium Whirlwind Shot (↓↘→+Medium Kick)<br>1st hit fully charged: From 150 to 100

■ Spinning Mixer (air current boosted) (↓↘→+Punch)<br>Heavy: From 25 to 31<br>Overdrive 1st and 2nd hit: From 75 to 50<br>Overdrive 3rd hit and after: From 100 to 25
</p>

><h4>Shared adjustment: Gauge gain on Perfect Parry</h4>
<p>
The Drive Gauge increase from a Perfect Parry of the following moves has been adjusted.

<ul>
<li>Jumping Heavy Punch</li>
<li>Flapping Spin (→+Medium P)</li>
<li>Tempest Moon (→+Kick during Run)</li>
<li>Light/Medium/Overdrive Spinning Mixer (↓↘→+Punch)</li>
<li>Arabian Cyclone (↓↙←+Punch)</li>
<li>Ysaar</li>
</ul>
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-09-27-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong> - <strong><a href="/patch-history/docs/street-fighter-6/" style="text-decoration: none;">back to patch list</a></strong> 

<br>

---