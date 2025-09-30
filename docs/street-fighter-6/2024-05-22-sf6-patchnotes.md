# 2024-05-22 - SF6 PATCHNOTES
---
<br>

<h3 id="top">General Changes</h3>
<strong><a href="/patch-history/docs/street-fighter-6/" style="text-decoration: none;">back to patch list</a></strong>
<br>
<br>

<h4>Overall Direction</h4>
<p>
In terms of game balance, while each character has received some buffs and nerfs, in terms of nerfs we primarily focused on the following points.

1. <h4>Weaken moves that were difficult to deal with and provided easy results
<p>
For example, for attacks that could be canceled into special moves, had good range and short recovery, we decided to adjust them by adding recovery, expanding their hurtbox, etc.

While those attacks are part of a character’s identity, if they proved too difficult for characters to deal with, interactions would end up in stalemates, or they would end up being the best answer to all situations, so we wanted to improve those situations.
</p>

2. <h4>Weaken moves that proved to be too oppressive
<p>
Continuing with the last balance update, techniques that were able to limit the opponent’s movements too much were weakened.
</p>

3. <h4>Retooling low risk/high return moves
<p>
There were many cases where the game system allows for weak attacks to pick up easy returns, while Perfect Parries could turn the tide of the match quickly, so these areas have been slightly adjusted with the idea of reeling things back a little.
</p>

><h4>Modern Controls
<p>
We have changed how Assisted Combos work when the player doesn’t have enough Drive or Super Art gauge. Additionally, some characters had difficult to use Assisted Combo routes, so we also changed those. There are some characters who have had the first attack of an Assisted Combo or their practical use changed, but we feel that in the long term these changes will benefit players using this control scheme.
</p>

><h4>Drive Reversals
<p>
Without an invincible attack, it proved difficult to deal with strong wake-up pressure, so now all characters can perform a Drive Reversal on their wake-up recovery as a way to deal with this. This technique is useful against throws or big attacks, but may be difficult to use against attacks with slow start-up or light attacks, etc.

Additionally, we have made an adjustment when blocking a Drive Reversal so the post-guard situation is more universal across the board. Some Drive Reversals proved to be a little difficult to counterattack if you blocked them, so we have made adjustments so that if you block them, your counterattack should work in most situations.
</p>

><h4>Drive and Perfect Parry
<p>
As noted above, we have looked at adjusting the risk/return for Perfect Parry. We felt that the risk of looking to score a Perfect Parry while out of throw range gave too high of a return, and depending on the situation, it proved more beneficial to get the Perfect Parry instead of going on the attack, so by increasing its overall length and expanding the throw hitbox, we’re looking to make it easier to take risks in these situations. Additionally, in order for Perfect Parries to not change the course of the match too much, after a successful Perfect Parry, the player will receive less meter gain.

For Drive Parries, the hurtbox after the Perfect Parry window has passed (frame 3 and later) is expanding, allowing it to absorb attacks from further away. After absorbing an attack, the time before the Drive gauge begins to replenish has also been shortened, making Drive Parry a more effective tactic primarily against projectiles.
</p>

><h4>Reworking Successful Command Inputs
We’ve made some changes with the aim of reducing the number of missed or accidental special moves.

1. <h4>Adjusted special move input recognition frames
<p>
For every command we made adjustments so special moves will come out less often if you complete a command, and then press a button slightly afterwards.
</p>

2. <h4>Adjusted ↓↘→ or ↓↙← in mid-air
<p>
Mid-air commands often require the player to perform the inputs quickly, and certain inputs tended to miss, so we have relaxed the input requirements.
</p>

3. <h4>Adjusted ↓↓ commands
<p>
This is an adjustment to avoid accidental Cancel Drive Rushes. During sequences such as ↓+ Light Punch > Neutral + Medium Punch + Medium Kick > ↓+ Light Punch, ↓↓ commands should no longer come out by accident.
</p>

4. <h4>Pressing Medium, Heavy attacks at the same time will not perform transition techniques.
<p>
This change is primarily aimed at techniques that are cancelable or are target combo starters, and special moves that have transition attacks or low recovery, etc.

We’ve made changes so that with Cancel Drive Rush and Drive Impact, once their recovery is over and players go for an immediate Drive Rush, etc. mistaken inputs would not unintentionally perform transition techniques. Please note that this adjustment is only when the player presses both buttons at exactly the same time.
</p>

><h4>Back Throws
<p>
One way of reducing the return a player gets from a Perfect Parry that we have made is an adjustment to how back throws are handled when performed with your back to the corner. Characters who could perform a back throw into the corner, and then repeatedly throw opponents in any situation will now have a harder time doing so.
</p>

<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td>Input Recognition</td><td>Adjustment</td><td><p>The Input Recognition Frame, which is the number of frames within which you must press the attack button after a special move command is inputted in order for the game to recognize you are performing a special move, has been adjusted per command.

1. For ↓↘→ or ↓↙← commands while standing on the ground, the Input Recognition Frame has been changed from 11 to 9 frames.

This means the attack button must be pressed within 9 frames of the final → or ← command being input for it to be recognized and have the special move be performed.

For ↓↘→ or ↓↙← commands while in the air, the Input Recognition Frame remains at 11 frames.

2. For ←↙↓↘→ or →↘↓↙← commands, the Input Recognition Frame has been changed from 12 frames to 9 frames.</p></td></tr>
    <tr><td>Mid-air ↓↘→ and ↓↙← Command Moves</td><td>Adjustment</td><td><p>Considering the fastest possible input necessary for instant aerial commands, the input difficulty has been eased slightly, and ↓↙← + K commands can now be performed using any downward direction (↙ or ↓ or ↘) followed by ↙← + K.
This can be performed by inputting ↙ > Neutral > ↙ > ←+Kick
</p></td></tr>
    <tr><td>↓↓+ Button Commands</td><td>Adjustment</td><td><p>If Medium Punch+Medium Kick are input between a double Down tap, no command will be performed.

This adjustment was made so that if you immediately double tap Down after a Cancel Drive Rush from a crouching attack, a double Down command move will not be performed by accident.</p></td></tr>
    <tr><td>Jump Landing Hurtboxes</td><td>Adjustment</td><td><p>The following characters have had their hurtbox while landing from a jump moved upwards to match other characters, as it was previously lower and caused unanticipated attacks to hit them.

Chun-Li, Dhalsim, Lily, A.K.I.</p></td></tr>
    <tr><td>Stun Timing Adjustments</td><td>Bug Fix</td><td><p>Fixed an issue where if an opponent in Burnout blocks a Drive Impact a certain distance away from the corner of the screen, and the player performs a technique just before stun occurs, no combo scaling would be applied on the combo after the stun.</p></td></tr>
    <tr><td>Drive Parry</td><td>Adjustment</td><td><p>
1. Throw hurtbox has been expanded while the technique is being performed.
2. Hurtbox from the 3rd frame and later has been expanded
3. The shortest possible active parry hitbox time has changed from 8 frames to 12 frames.
4. Recovery after the active frames has changed from 29 frames to 33 frames.
5. After absorbing an attack, the time until the Drive Gauge starts to auto regenerate has changed from 60 frames to 20 frames.</p></td></tr>
    <tr><td>Perfect Parry</td><td>Adjustment</td><td><p>The overall gauge fluctuation from a counter attack after a Perfect Parry has been reduced. This adjustment is not just for the first attack, but affects all attacks until the combo ends.

1. Super Art gauge increase has changed from 100% to 80% for both the attacker and damage-taker.
2. Drive gauge increase for the attacker has changed from 100% to 50%
3. Drive gauge decrease for the damage-taker has changed from 100% to 50%</p></td></tr>
    <tr><td>Drive Rush</td><td>Adjustment</td><td><p>Expanded the attack and throw hurtboxes of the Parry Drive Rush so that they're no longer smaller than the ones for a Drive Parry.</p></td></tr>
    <tr><td>Drive Impact</td><td>Adjustment</td><td><p>Buffer input window has changed from 5 frames to 10 frames to ensure easier movement immediately after the recovery ends for cases where the Punish Counter cutscene is not triggered.</p></td></tr>
    <tr><td>Drive Reversal</td><td>Adjustment</td><td><p>

1. Recovery on block has changed from -8 to -6 frames
2. Attack hitbox has expanded downward so techniques with a low profile can no longer avoid this attack.
3. Pushback distance on close-range block is now almost equal for all characters.

Note: Certain character updates to pushback on block, collision pushboxes, hurtboxes and distance traveled are being made.</td></tr>
    <tr><td></td><td>Bug Fix</td><td>Damage no longer increases on counter hit.</td></tr>
    <tr><td>Recovery Drive Reversal</td><td>Adjustment</td><td><p>Drive Reversal can now be performed during the recovery from a knockdown.
While the command is still the same (→+HP+HK), you can simply perform it early and hold down the input to perform the technique on recovery.
Note: This version of the Drive Reversal will not darken the screen or stop time, and the attack start-up is 18 frames, which is 2 frames faster than the normal Drive Reversal.</p></td></tr>
    <tr><td>Light Attack (Standing/Crouching)</td><td>Adjustment</td><td><p>Initial scaling has changed from 10% to 20%</p></td></tr>
    <tr><td>Cross-Up Capable Jumping Light Attacks</td><td>Adjustment</td><td><p>
Because every character has a different hit and block recovery against their opponent, we've matched the longest advantage time, so some character's jumping weak attack on block or guard will have an additional 1 frame of recovery.

This change applies to Luke, Jamie, Marisa, Lily, Juri, Ryu, E. Honda, Guile, Ken and A.K.I.</p></td></tr>
</tbody>
</table>

<!-- Section Index -->
<h3>Specific character updates this patch</h3>
<table class="character-table-style">
<tbody>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#luke">Luke</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#jamie">Jamie</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#manon">Manon</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#kimberly">Kimberly</a></td>
    </tr>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#marisa">Marisa</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#lily">Lily</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#jp">JP</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#juri">Juri</a></td>
    </tr>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#dee-jay">Dee Jay</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#cammy">Cammy</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#ryu">Ryu</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#e.-honda">E. Honda</a></td>
    </tr>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#blanka">Blanka</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#guile">Guile</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#ken">Ken</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#chun-li">Chun-Li</a></td>
    </tr>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#zangief">Zangief</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#dhalsim">Dhalsim</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#rashid">Rashid</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#a.k.i.">A.K.I.</a></td>
    </tr>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#ed">Ed</a></td>
    </tr>
</tbody>
</table>

---

<h2 id="luke">Luke</h2>

><h4>Adjustment summary

<p>
While Luke's strong anti-air and poke moves formed a core part of his characteristics, they also had very few gaps, leading to matches losing momentum and coming to a standstill. To remedy this, we've weakened some of his interception techniques. To balance this out and expand Luke's offensive options, his forward advancing normals, such as Standing Heavy Kick, have been bolstered and made easier to use.

For Luke's other overall balance adjustments, we've also overhauled some combo parts. While the damage across the board has dropped, combos utilizing Standing Heavy Punch and DDT should see some hefty returns with more damage than they've been able to dish out in the past.

In addition, combo links such as 'Overdrive Flash Knuckle to Heavy Rising Uppercut' or 'Crouching Heavy Punch to Perfect Medium Flash Knuckle' have been adjusted so they have less chances of failing, meaning it's now easier to create some tricky combos for those willing to take up the challenge.
</p>

<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td>Assisted Combo 1</td><td>Adjustment</td><td><p>Combo has now changed to the following.
- When Super Art gauge is empty
Crouching Light Kick > Crouching Light Punch > Overdrive Flash Knuckle > Medium Rising Uppercut
- During Burnout
Crouching Light Kick > Crouching Light Punch > Light Flash Knuckle</p></td></tr>
    <tr><td>Assisted Combo 2</td><td>Adjustment</td><td><p>       

1. Changed so that Overdrive Flash Knuckle cancels into Super Art 2 from the second hit.

2. Combo has now changed to the following.
- When Super Art gauge is less than 2 bars
Crouching Medium Punch > Overdrive Flash Knuckle > Medium Rising Uppercut
- During Burnout
Crouching Medium Punch > Light Flash Knuckle</p></td></tr>
    <tr><td>Assisted Combo 3</td><td>Adjustment</td><td><p>Combo has now changed to the following.
- When Super Art gauge is full
Standing Heavy Punch > Overdrive Sand Blast > Pale Rider
- When Super Art gauge is less than 3 bars
Standing Heavy Punch > Overdrive Sand Blast > Fatal Shot
- During Burnout when Super Art gauge is full
Standing Heavy Punch > Medium Sand Blast > Pale Rider</p></td></tr>
    <tr><td>Scrapper(Backwards Throw)</td><td>Universal Adjustment</td><td><p>Distance increased between characters when the opponent is thrown into the corner.</p></td></tr>
    <tr><td>Standing Medium Kick</td><td>Adjustment</td><td><p>
1. Start up changed from 7 to 8 frames.
2. Recovery changed from 20 to 19 frames.</p></td></tr>
    <tr><td>Standing Heavy Punch</td><td>Adjustment</td><td><p>
    
1. Advantage on hit changed from -1 to +1 frame.
2. Collision pushbox on hit has been expanded upward.
Note: This adjustment has been made to make it more difficult for Luke to swap sides when hitting an opponent in the air.</p></td></tr>
    <tr><td>Standing Heavy Kick</td><td>Adjustment</td><td><p>
1. Active frames changed from 6 to 7 frames.
2. Recovery changed from 17 to 16 frames.
3. Forward attack hitbox reduced during active frames 1 - 2.
4. Camera shake added if the attack is blocked on the final active frame.
Note: This was added to make it easier to understand when Luke has an advantage.</p></td></tr>
    <tr><td>Crouching Light Punch</td><td>Adjustment</td><td><p>Forward attack hitbox reduced.</p></td></tr>
    <tr><td>Crouching Medium Punch</td><td>Adjustment</td><td><p>
1. Initial scaling of 15% added.
2. Forward attack hitbox reduced.</p></td></tr>
    <tr><td>Crouching Medium Kick</td><td>Adjustment</td><td><p>The body hurtbox has been expanded forward during frames 19 - 29, only for when the attack misses.</p></td></tr>
    <tr><td>Crouching Heavy Punch</td><td>Adjustment</td><td><p>
1. Combo scaling changed from 10% to 15%
2. Attack hitbox reduced to make it harder to hit opponents directly above Luke.
3. Attack hitbox on the 1st active frame has been expanded forward.
4. Upper body hurtbox during frames 7 - 8 of the technique has been expanded.
5. The central axis of the character now moves according to the visual appearance of the technique.
Note: There may be some side effects to this, such as Luke moving forward slightly when canceling into a special move, or finding himself more susceptible to cross-ups.</p></td></tr>
    <tr><td>Jumping Heavy Punch</td><td>Adjustment</td><td><p>Hurtbox has been expanded downward from the 9th frame of the technique.
Note: This expanded hurtbox is invincible to projectiles.</p></td></tr>
    <tr><td>Jumping Heavy Kick</td><td>Adjustment</td><td><p>
Hurtbox has been expanded downward from the 10th frame of the technique.
Note: This expanded hurtbox is invincible to projectiles.</p></td></tr>
    <tr><td>Outlaw Kick (← + Heavy Kick)</td><td>Adjustment</td><td><p>
1. Advantage on Punish Counter has changed from 19 to 17 frames.
2. Pushback on Punish Counter has been increased.</p></td></tr>
    <tr><td>Nose Breaker (Crouching Medium Kick > ↓ + Heavy Punch)</td><td>Universal Adjustment</td><td><p>When using Classic controls, pressing Heavy Kick at the same time will cause the second attack to not come out.</p></td></tr>
    <tr><td>Fatal Shot (↓↘→ + Two Punches > Two Punches)</td><td>Adjustment</td><td><p>
1. Damage changed from 700 to 1000.
2. Super Art gauge increase changed from 400 to 1000.
3. Drive gauge decrease changed from 2000 to 7000 on Punish Counter.</p></td></tr>
    <tr><td>Medium Flash Knuckle (↓↙← + Medium Punch)</td><td>Adjustment</td><td><p>Pressing the button rapidly after this attack is performed will make it harder for the hold button version to be performed by accident.</p></td></tr>
    <tr><td>Charged Medium Flash Knuckle (↓↙← + Medium Punch (Hold))</td><td>Adjustment</td><td><p>Reduced recovery by 4 frames when this attack hits super armor.</p></td></tr>
    <tr><td>Perfect/Charged Heavy Flash Knuckle (↓↙← + Heavy Punch (Hold))</td><td>Adjustment</td><td><p>Increased knockdown time by 1 frame on hit.</p></td></tr>
    <tr><td>Overdrive Flash Knuckle (↓↙← + Two Punches)</td><td>Adjustment</td><td><p>Increased knockdown time by 10 frames on hit.</p></td></tr>
    <tr><td>DDT (↓↙← + Two Punches > Two Punches)</td><td>Adjustment</td><td><p>
1. Damage changed from 2000 to 2500.
2. Super Art gauge increase changed from 1500 to 3000.</p></td></tr>
    <tr><td>Normal/Overdrive No Chaser (↓↘→ + Kick/Two Kicks > Punch)</td><td>Adjustment</td><td><p>
1. Active frames changed from 7 to 10 frames.
2. Recovery changed from 19 to 16 frames.</p></td></tr>
    <tr><td>SA3/CA Pale Rider</td><td>Adjustment</td><td><p>
1. Attack hitbox during a combo on an opponent has been expanded upward.
2. Invincibility no longer extends when performing the attack from long range.</p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="jamie">Jamie</h2>

><h4>Adjustment summary

<p>
Jamie had a unique characteristic of being able to have both close-range oppressive power coupled with the ability to break down opponents when his drink level was raised, but there were times when it was difficult for him to raise his drink level to unlock that damage potential with the limited tools available at the start of a match. For this update, we've looked at giving him more ways to raise his drink level and to increase its benefits, so he can show more of his characteristics.

For normal attacks, the advantage on hit for Crouching Medium Punch now allows him to cancel into Overdrive Swagger Step for a combo, etc. This change compensates the short range on the normal attack with a good return, with the added benefit of giving him a chance to raise his drink level.

For special moves, Heavy Swagger Step can no longer be punished even when blocked up close, making it a strong attack with lower risk when canceled into.

The final attack of Bitter Strikes, which is unlocked with drink level, can be canceled into Cancel Drive Rush even if the last attack is blocked, so you can perform that move and cancel into Crouching Light Punch to force the opponent to block it, creating a frame advantage situation to continue your offense.

Finally, Jamie has received a lot of adjustments to make him easier to play, such as Super Art level 1's better start-up, but also received some downward adjustments, such as to his Crouching Heavy Kick, which was difficult for some characters to deal with when they blocked it.
</p>

<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td>Assisted Combo 2</td><td>Adjustment</td><td><p>

1. At Drink level 4 Overdrive Freeflow Strikes > The Devil's Song cancel timing is hard set to the 2nd attack.

2. Combo has now changed to the following.
- Basic
Standing Medium Kick > Overdrive Freeflow Strikes > The Devil's Song > Senei Kick > Ransui Haze > Medium Swagger Step > Swagger Hermit Punch
- Super Art gauge is less than 2 bars
Standing Medium Kick > Overdrive Freeflow Strikes 1 > Overdrive Freeflow Strikes 2 > Overdrive Freeflow Strikes 3
- During Burnout
Standing Medium Kick > Heavy Freeflow Strikes 1 > Freeflow Strikes 2 > Freeflow Strikes 3</p></td></tr>
    <tr><td>Assisted Combo 3</td><td>Adjustment</td><td><p>Combo has now changed to the following during Burnout.
Standing Heavy Kick > Medium Swagger Step > Getsuga Saiho</p></td></tr>
    <tr><td>Wheel Punch (Backward Throw)</td><td>Universal Adjustment</td><td><p>
1. Increased distance after hit.
2. Advantage after hit changed from +38 to +26 frames</p></td></tr>
    <tr><td>Standing Medium Punch</td><td>Adjustment</td><td><p>Advantage on block changed from +1 to +2.</p></td></tr>
    <tr><td>Standing Medium Kick</td><td>Adjustment</td><td><p>Advantage on hit changed from +1 to +2</p></td></tr>
    <tr><td>Crouching Medium Punch</td><td>Adjustment</td><td><p>
1. Advantage on hit changed from +3 to +5.
2. Advantage on block changed from ±0 to -1.</p></td></tr>
    <tr><td>Crouching Medium Kick</td><td>Adjustment</td><td><p>Hurtbox on the feet expanded upwards between frames 18 - 27 only when the attack misses.</p></td></tr>
    <tr><td>Crouching Heavy Kick</td><td>Adjustment</td><td><p>
1. When the first attack is blocked, the second attack changes to a high attack.
2. Recovery changed from 28 to 29 frames when the attack is blocked.
3. Disadvantage on block changed from -10 to -11.
4. Reduced combo count additional value for the first attack.</p></td></tr>
    <tr><td>Jumping Heavy Kick</td><td>Adjustment</td><td><p>Hurtbox present around the feet on the last frame of start-up removed.</p></td></tr>
    <tr><td>Tensei Kick (↓ + Two Kicks)</td><td>Bug Fix</td><td><p>Fixed an issue where Luminous Dive Kick could not be performed using simple inputs after a jump cancel when The Devil's Song was active during Drink level 1 - 3 while using Modern controls.</p></td></tr>
    <tr><td>Drink Level 4 Hermit's Elbow (← + Heavy Punch)</td><td>Adjustment</td><td><p>Pushback reduced.</p></td></tr>
    <tr><td>Falling Star Kick (→ + Medium Kick)</td><td>Adjustment</td><td><p>
1. Cancel window for Full Moon Kick extended by 1 frame.
2. Added 1 frame of hitstop and blockstun.</p></td></tr>
    <tr><td>Bitter Strikes (Light Punch > Light Kick > Medium Punch)</td><td>Adjustment</td><td><p>
1. Expanded the first attack's hitbox forward.
2. The cancel timing when using a Drive Rush on the second attack is now 1 frame earlier.
3. 2 frames of recovery added to the defender on block for the second attack.
4. Recovery when only the second attack is blocked changed from 21 to 23 frames.
Note: Advantage on block has not changed.</p></td></tr>
    <tr><td>Immediate Ransui Haze (→ + Heavy Kick > ← + Heavy Kick > Heavy Punch)</td><td>Adjustment</td><td><p>
1. Damage changed from 700 to 850.
2. Combo scaling of 20% added.
3. Start-up changed from 17 to 15 frames.
4. Total technique frame length changed from 48 to 46 frames.
5. Extended Ransui Haze buffer input grace period.</p></td></tr>
    <tr><td>Drink Level 0-3 Normal Freeflow Strikes (↓↘→ + Punch > → + Punch > → + Punch)</td><td>Adjustment</td><td><p>
1. Drive gauge increase from the three attacks changed from 700 to 1500.
2. Drive gauge decrease when blocking the three attacks changed from 1500 to 2500.
3. Input buffer start period when going to the third attack changed from frame 2 to frame 7.</p></td></tr>
    <tr><td></td><td>Universal Adjustment</td><td><p>While using Classic controls, attack will not be performed after the second attack if Medium or Heavy Kick are pressed at the same time.</p></td></tr>
    <tr><td>Drink Level 4 Normal Freeflow Strikes (↓↘→ + Punch > → + Punch > → + Punch)</td><td>Adjustment</td><td><p>
1. Hitbox for the 1st hit of the first attack expanded forward.
2. Drive gauge increase for the first attack changed from 1400 (700x2) to 3000 (1500x2).
3. Drive gauge increase for the second attack changed from 1400 (700x2) to 1000 (500x2).
4. Drive gauge increase for the third attack changed from 2100 (700x3) to 1500 (500x3).
5. Input buffer start period when going to the third attack changed from frame 2 to frame 7.</p></td></tr>
    <tr><td></td><td>Universal Adjustment</td><td><p>While using Classic controls, attack will not be performed after the second attack if Medium or Heavy Kick are pressed at the same time.</p></td></tr>
    <tr><td>Drink Level 4 Medium/Heavy Freeflow Strikes (↓↘→ + Medium/Heavy Punch > → + Punch > → + Punch)</td><td>Bug Fix</td><td><p>Fixed an issue where the input buffer starting frame for the next attack differed from other strengths.</p></td></tr>
    <tr><td>Drink Level 0-3 Overdrive Freeflow Strikes (↓↘→ + Two Punches > → + Punch > → + Punch)</td><td>Adjustment</td><td><p>
1. Advantage when the first attack hits changed from ±0 to +1.
2. Drive gauge reduction when blocking the three attacks changed from 1500 to 2500.
3. Hits after the second attack are no longer subject to combo scaling.
4. Input buffer start period when going to the third attack changed from frame 2 to frame 7.</p></td></tr>
    <tr><td></td><td>Universal Adjustment</td><td><p>While using Classic controls, attack will not be performed after the second attack if Medium or Heavy Kick are pressed at the same time.</p></td></tr>
    <tr><td>Drink Level 4 Overdrive Freeflow Strikes (↓↘→ + Two Punches > → + Punch > → + Punch)</td><td>Adjustment</td><td><p>
1. Hitbox for the 1st hit of the first attack expanded forward.
2. Hits after the second attack are no longer subject to combo scaling.
3. Input buffer start period when going to the third attack changed from frame 2 to frame 7.</p></td></tr>
    <tr><td></td><td>Universal Adjustment</td><td><p>While using Classic controls, attack will not be performed after the second attack if Medium or Heavy Kick are pressed at the same time.</p></td></tr>
    <tr><td>Normal Freeflow Kicks (↓↘→ + Punch > → + Kick > → + Kick)</td><td>Adjustment</td><td><p>
1. Drive gauge increase for the second and third attack increased from 700 to 1000.
2. Drive gauge reduction when blocking the three attacks changed from 1500 to 2500.
3. Input buffer start period when going to the third attack changed from frame 2 to frame 7.</p></td></tr>
    <tr><td></td><td>Universal Adjustment</td><td><p>While using Classic controls, attack will not be performed after the second attack if Medium or Heavy Kick are pressed at the same time.</p></td></tr>
    <tr><td>Overdrive Freeflow Kicks (↓↘→ + Two Punches > → + Kick > → + Kick)</td><td>Adjustment</td><td><p></p>
1. Drive gauge reduction when blocking the three attacks changed from 1500 to 2500.
2. Input buffer start period when going to the third attack changed from frame 2 to frame 7.</td></tr>
    <tr><td></td><td>Universal Adjustment</td><td><p>While using Classic controls, attack will not be performed after the second attack if Medium or Heavy Kick are pressed at the same time.</p></td></tr>
    <tr><td>Heavy Swagger Step (↓↙← + Heavy Punch)</td><td>Adjustment</td><td><p>
1. Recovery changed from 17 to 16 frames.
2. Disadvantage on block changed from -5 to -3 frames.
3. Increased knockdown time by 2 frames on hit.</p></td></tr>
    <tr><td>Overdrive Swagger Step (↓↙← + Two Punches)</td><td>Adjustment</td><td><p>Increased knockdown time by 3 frames when attack hits a mid-air opponent.</p></td></tr>
    <tr><td>Light Arrow Kick (→↓↘ + Light Kick)</td><td>Adjustment</td><td><p>
1. Initial scaling of 30% added.
2. Start-up changed from 6 to 5 frames.
3. Transition attack hitbox after initial hit expanded forward.</p></td></tr>
    <tr><td>Normal/Overdrive Luminous Dive Kick (↓↙← + Kick/Two Kicks during a forward jump)</td><td>Adjustment</td><td><p>
1. Pushback on block reduced.
2. Hurtbox around the feet now comes out on the 6th frame of the technique instead of the 10th.
3. Reduced the hurtbox around the feet from the 13th frame of the technique.</p></td></tr>
    <tr><td>Normal/Overdrive Bakkai (↓↘→ + Kick/Two Kicks)</td><td>Adjustment</td><td><p>Projectile invincibility has been extended until the final attack's active frames are finished.</p></td></tr>
    <tr><td>Normal Tenshin (→↘↓↙← + Kick)</td><td>Bug Fix</td><td><p>Fixed an issue where the internal combo count starting value would be added even though the opponent was standing on the ground after the hit.</p></td></tr>
    <tr><td>Overdrive Tenshin (→↘↓↙← + Two Kicks)</td><td>Adjustment</td><td><p>
1. Removed Immediate Scaling.
2. Added Intial Scaling of 30%
Note: Tweaked the attack so that combo scaling is applied from the first follow-up attack.</p></td></tr>
    <tr><td>Normal/Overdrive Swagger Hermit Punch (↓↙← + Punch/Two Punches > → + Punch)</td><td>Universal Adjustment</td><td><p>While using Classic controls, attack will not be performed if Medium or Heavy Kick are pressed at the same time.</p></td></tr>
    <tr><td>SA1 Breakin'</td><td>Adjustment/Bug Fix</td><td><p>
1. Start-up changed from 10 to 8 frames.
2. Added a new hitbox from frames 8 - 10 of the technique.
3. Attack hitbox for the first and second attack that is only applied when an opponent is in a combo has been expanded.
4. Reduced forward movement when the screen darkens, and increased forward movement after the screen transition is over.
5. The 1st frame of the technique was completely invincible, and this has been changed to be only strike and throw invincible.</p></td></tr>
    <tr><td>SA3/CA Getsuga Saiho</td><td>Adjustment</td><td><p>Collision pushbox at the beginning of the technique has been expanded upwards, making it more difficult for Jamie to pass underneath airborne opponents.</p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="manon">Manon</h2>

><h4>Adjustment summary

<p>
Manon's options to close in on an opponent were lacking, and her attack options after she got close were a little weak. Considering the adjustments made to Drive Reversal, we expected that she would have a harder time raising her Medal level. For that reason we've given her more striking pressure, and made it easier for her options to hit.

Additionally, we changed the Modern controls so that ↓↙← + Attack will now perform Dégagé. There was some input overlap with Dégagé and her Manège Doré command throw, so we felt it would be difficult to have both in Modern controls and decided to just go with Manège Doré, but Manon not having access to all her Dégagé variations for combos and the neutral game proved to be too much of a disadvantage for her, so now she can use both.

We also made it more difficult for Manège Doré to accidentally come out when inputting Dégagé by changing its input success criteria. Details can be found in the character specific adjustment list, but please note that this also affects Classic controls as well.
</p>

<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td>Modern Controls</td><td>Adjustment</td><td><p>Dégagé can now be performed with ↓↙←+Attack.</p></td></tr>
    <tr><td>Assisted Combo 2</td><td>Adjustment</td><td><p>Combo has now changed to the following during Burnout.

Standing Medium Kick > Heavy Rond-point</p></td></tr>
    <tr><td>Assisted Combo 3</td><td>Adjustment</td><td><p>Combo has now changed to the following.
- Basic
Révérence > Overdrive Renversé > Grand Fouetté > Révérence > Heavy Renversé > Pas de Deux
- During Burnout
Révérence > Heavy Rond-point</p></td></tr>
    <tr><td>Uchi Mata (Backwards Throw)</td><td>Universal Adjustment</td><td><p>Increased distance after hit.</p></td></tr>
    <tr><td>Drive Impact</td><td>Bug Fix</td><td><p>Fixed an issue where if both players are Manon and perform a Drive Impact at the same time, a clash would not occur.</p></td></tr>
    <tr><td>Standing Medium Punch</td><td>Adjustment</td><td><p>Adjusted À Terre's transition timing from frames 7 - 13 to frames 11 - 13.</p></td></tr>
    <tr><td>Standing Medium Kick</td><td>Adjustment</td><td><p>Pushback on hit reduced.</p></td></tr>
    <tr><td>Standing Heavy Kick</td><td>Adjustment</td><td><p>Input buffer will now be read from 8 frames before recovery ends.</p></td></tr>
    <tr><td>Crouching Light Punch</td><td>Adjustment</td><td><p>Advantage on hit changed from +2 to +3 frames.</p></td></tr>
    <tr><td>Crouching Medium Punch</td><td>Adjustment</td><td><p>Hurtbox expanded forward from frames 21 - 22 when the attack misses.</p></td></tr>
    <tr><td>Crouching Light Kick</td><td>Adjustment</td><td><p>

1. Downward hitbox reduced.
Note: Adjustment made so this attack does not hit attacks with invincibility around the feet.
2. Pushback on hit and block reduced.</p></td></tr>
    <tr><td>Crouching Medium Kick</td><td>Adjustment</td><td><p>
1. Advantage on hit changed from +2 to +3 frames.
2. Pushback on hit reduced.</p></td></tr>
    <tr><td>Tomoe Derrière (↘ + Heavy Kick)</td><td>Adjustment</td><td><p>Increased combo count upper limit.</p></td></tr>
    <tr><td>À Terre (Medium Punch > Medium Kick)</td><td>Universal Adjustment</td><td><p>While using Classic controls, attack will not be performed if Medium Punch is pressed at the same time as the second input.</p></td></tr>
    <tr><td>En Haut (← + Medium Kick > Medium Kick)</td><td>Adjustment</td><td><p>
1. Pushback on the first attack reduced.
2. Ground bound effect added when the second attack hits an airborne opponent.
3. Added a new attack hitbox to the second attack that is only applied when an opponent is in a combo, making it easier to hit opponents that are above Manon.</p></td></tr>
    <tr><td>Révérence (← + Heavy Punch)</td><td>Adjustment</td><td><p>
1. Advantage on block changed from -3 to +1.
2. Pushback on hit reduced.</p></td></tr>
    <tr><td>Normal Grand Fouetté (↓↘→ + Punch > Kick)</td><td>Adjustment</td><td><p>Camera shake added during Punish Counter.</p></td></tr>
    <tr><td>Overdrive Grand Fouetté (↓↘→ + Two Punches > Kick)</td><td>Adjustment</td><td><p>Start-up changed from 11 to 10 frames.</p></td></tr>
    <tr><td>Normal Rond-point (↓↘→ + Kick)</td><td>Adjustment</td><td><p>The second attack can no longer be canceled into Super Art 3/Critical Art.</p></td></tr>
    <tr><td>Heavy Rond-point (↓↘→ + Heavy Kick)</td><td>Adjustment</td><td><p>The horizontal blowback when the second attack hits an airborne opponent has been reduced.</p></td></tr>
    <tr><td>Overdrive Rond-point (↓↘→ + Two Kicks)</td><td>Adjustment</td><td><p>
1. The first attack can now be canceled into Super Art 2/3/Critical Art.
2. Damage distribution changed from 400+400 to 500+300.
Note: If only the second attack hits, the damage remains at 400
3. The attack hitbox for only when an opponent is standing on the ground has been expanded forward.</p></td></tr>
    <tr><td>Normal/Overdrive Manège Doré (→↘↓↙← + Punch/Two Punches)</td><td>Adjustment</td><td><p>
1. The attack's input recognition frames have been shortened overall.
2. Attack will no longer be performed with a ↘↓↙← input.
3. After performing a forward input, the attack will no longer be performed if it next goes through a neutral or back input.</p></td></tr>
    <tr><td>SA1 Arabesque</td><td>Adjustment / Bug Fix</td><td><p>
1. Added a new attack hitbox that is only applied when an opponent is in a combo, making it easier to hit opponents that are above Manon.
2. The 1st frame of the technique was completely invincible, and this has been changed to be only strike and throw invincible.</p></td></tr>
    <tr><td>SA2 Étoile</td><td>Adjustment</td><td><p>
1. Final attack damage changed from 850 to 950.
2. Added a new attack hitbox to the third attack that is only applied when an opponent is in a combo, making it easier to hit opponents that are below Manon.
3. Expanded the collision pushbox upward during frames 58 - 80.</p></td></tr>
    <tr><td>SA3/CA Pas de Deux</td><td>Adjustment</td><td><p>
1. Damage now changes depending on Manon's Medal level.
Super Art 3
Medal level 1: 4000
Medal level 2: 4100
Medal level 3: 4200
Medal level 4: 4400
Medal level 5: 4600

Critical Art
Medal level 1: 4500
Medal level 2: 4600
Medal level 3: 4700
Medal level 4: 4900
Medal level 5: 5100

2. Hurtbox expanded forward between frames 9 - 62 when the attack msises.</p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="kimberly">Kimberly</h2>

><h4>Adjustment summary

<p>
Kimberly already has a lot of offensive potential going for her, so this time we've made changes to expand some of her neutral game options and increase the utility of some moves.

With some tweaks to its active frames, Light Vagabond Edge should now be on the receiving end of counters less. Until now Kimberly hasn't had many tools available to her in the neutral game, with very few forward reaching moves, but with this change she now has a viable option to tag opponents from an even greater range than her go-to Standing Medium Kick.

In addition to this we've added new avenues for certain Super Arts that were hard to work in, and made certain Special Moves easier to use. One example is Overdrive Nue Twister. It's now easier to weave it into some lethal combos, but we've also counter-balanced its boosts with some additional combo scaling to reign in its combo damage potential a bit.
</p>

<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td>Assisted Combo 2</td><td>Adjustment</td><td><p>Combo has now changed to the following.

- When Super Art gauge has less than 1 bar

Standing Medium Kick > Overdrive Vagabond Edge > Jump cancel > Jumping Medium Punch > Aerial Bushin Senpukyaku

- During Burnout

Standing Medium Kick > Medium Vagabond Edge</p></td></tr>
    <tr><td>Bell Ringer(Backwards Throw)</td><td>Universal Adjustment</td><td><p>Distance increased between characters when the opponent is thrown into the corner.</p></td></tr>
    <tr><td>Standing Light Kick</td><td>Adjustment</td><td><p>Reduced pushback.</p></td></tr>
    <tr><td>Standing Medium Kick</td><td>Adjustment</td><td><p>Super Art gauge increase changed from 500 to 700.</p></td></tr>
    <tr><td>Crouching Medium Punch</td><td>Adjustment</td><td><p>
1. Damage changed from 450 to 500.
2. Pushback reduced.</p></td></tr>
    <tr><td>Bushin Tiger Fangs (Medium Punch > Heavy Punch)</td><td>Universal Adjustment</td><td><p>When using Classic controls, pressing Heavy Kick at the same time as the second input will cause the second attack to not come out.</p></td></tr>
    <tr><td>Bushin Prism Strikes (Light Punch > Medium Punch)</td><td>Universal Adjustment</td><td><p>When using Classic controls, pressing Medium Kick at the same time as the second input will cause the second attack to not come out.</p></td></tr>
    <tr><td>Normal/Overdrive Sprint (↓↘→ + Kick/Two Kicks)</td><td>Adjustment</td><td><p>Adjusted Kimberly's behavior so that she will not automatically transition into Arc Step when she comes in contact with the opponent if forward is being held in Classic controls or the SP button is being held in Modern Controls.</p></td></tr>
    <tr><td>Normal/Overdrive Bushin Hojin Kick (↓↘→ + Kick/Two Kicks > Kick, after Arc Step)</td><td>Bug Fix</td><td><p>Added a new attack hitbox that is only applied when an opponent is in a combo, and fixed an issue where Bushin Hojin Kick would not combo properly after Arc Steps hits from a distance.</p></td></tr>
    <tr><td>Overdrive Torso Cleaver (↓↘→ + Two Kicks > Light Kick)</td><td>Adjustment</td><td><p>Opponent's Drive gauge reduction on block changed from 4000 to 6000.</p></td></tr>
    <tr><td>Light Vagabond Edge (↓↘→ + Light Punch)</td><td>Adjustment</td><td><p>
1. Active frames changed from 2 to 3 frames.
2. Recovery changed from 22 to 21 frames.
3. Disadvantage on block changed from -6 to -5 frames.
4. Updated so attack range does not change during active frames 1 - 2.

Note: Properties tweaked so attack can hit easier on active frame 3.</p></td></tr>
    <tr><td>Normal Bushin Senpukyaku (↓↙← + Kick)</td><td>Adjustment</td><td><p>
1. Anti-air invincibility timing has changed from when the hitbox first appears to now occur 1 frame before the hitbox appears.
2. From frame 1 of the technique until the attack hitbox appears, the hurtbox on the head is reduced downwards.</p></td></tr>
    <tr><td>Medium/Heavy Bushin Senpukyaku (↓↙← + Medium/Heavy Kick)</td><td>Bug Fix</td><td><p>Fixed an issue where the hitbox on the third attack should have expanded if the first or second attack hit, but did not on counter or Punish Counter.</p></td></tr>
    <tr><td>Normal/Overdrive Bushin Senpukyaku (↓↙← + Kick/Two Kicks)</td><td>Bug Fix</td><td><p>Fixed an issue where damage was reduced when landing a hit during the active frames of the first attack.</p></td></tr>
    <tr><td>Overdrive Bushin Senpukyaku (↓↙← + Two Kicks)</td><td>Adjustment</td><td><p>
1. Can be canceled into Super Art 2 during the fourth attack.
2. Damage changed for the second, third, and fourth attacks from 180 to 200.
3. First attack's hitbox expanded forward.
4. Added more time to the fourth attack's blowback.
5. Increased combo count limit.</p></td></tr>
    <tr><td>Overdrive Nue Twister (↓↘→ + Punch, during a jump)</td><td>Adjustment</td><td><p>
1. Changed combo scaling from 10% to 20%
2. Increased combo count limit.</p></td></tr>
    <tr><td>Hidden Variable (↓↙← + Punch/Two Punches)</td><td>Adjustment</td><td><p>Changed attack activation priority so that Hidden Variable has higher priority than Bushin Senpukyaku.
Note: This also applies to the Overdrive version.</p></td></tr>
    <tr><td>SA1 Bushin Beats/Bushin Thunderous Beats</td><td>Adjustment / Bug Fix</td><td><p>
1. Adjusted so that Shuriken Bomb stocks are only used when the follow-up command is input after the attack's initial hit. The follow-up command is as follows.
Classic: Hold Kick button
Modern: Hold Light Attack, SP, or Heavy Attack

2. Start-up changed from 12 to 10 frames.
3. Collision pushbox expanded upwards.
4. The 1st frame of the technique was completely invincible, and this has been changed to be only strike and throw invincible.
5. The seventh attack's Drive gauge reduction is 4100 no matter if the follow-up is used or not.</p></td></tr>
    <tr><td>SA1 Bushin Thunderous Beats</td><td>Adjustment</td><td><p>
Damage on the final attack changed from 200 to 400.
<br>Drive gauge reduction on the final attack changed from 4000 to 1.
Note: This adjustment was made to ensure that the opponent's Drive gauge recovery doesn't start earlier than intended.</p></td></tr>
    <tr><td>SA2 Bushin Scramble/Soaring Bushin Scramble</td><td>Adjustment / Bug Fix</td><td><p>

Damage changed from 2600 to 2800.
<br> Attack hitbox expanded.
<br> A hurtbox was added as the 1st frame of the technique was completely invincible.
<br>Note: Kimberly moves during the screen transition, so the property of avoiding attacks close to the ground has not changed.
<br>Fixed an issue where the Drive gauge would recover during the cutscene when used in a combo that utilized Drive Rush.</p></td></tr>
    <tr><td>SA3/CA Bushin Ninjastar Cypher</td><td>Adjustment</td><td><p>Added a new attack hitbox that is only applied when an opponent is in a combo, allowing Kimberly to hit opponents in front of her easier.</p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="marisa">Marisa</h2>

><h4>Adjustment summary

<p>
Marisa's staggering damage output from her strikes is a central core of her character, but the relentless assaults possible after landing her command throw, as well as her powerful table-turning counterattacks, made for a combination that was a little too potent at turning matches completely on their head. With this in mind, we've made her strikes more powerful, to let those traits truly shine, and then we've decreased the advantage frames of her command throw, Enfold, as well as those for her SA3 on hit. We've also adjusted the counter-attack focused moves Scutum and Overdrive Gladius to dial down their damage potential.

In terms of the boosts to her strikes, each of her charged attacks now have greater advantage on contact, with the tweaks meaning that they'll also no longer leave any openings to counters on block. Falx Crusher, which was previously very situational, has also been improved on, which should make it a more attractive option when the moment presents itself and you're after a big return.

In order to ease one of Marisa's weaknesses, where it could be hard to hit retreating opponents with her attacks, we've made adjustments to some moves, such as making it so that the proximity block triggers for Marisa's Standing Heavy Kick and Crouching Heavy Kick activate from the start of the moves to stop retreating opponents in their tracks. This combined with the other buffs to strikes should put them back in the spotlight on the offensive front.
</p>

<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td>Assisted Combo 2</td><td>Adjustment</td><td><p>Combo has now changed to the following during Burnout.
Medium Two Hitter > Medium Gladius</p></td></tr>
    <tr><td>Marisa Style</td><td>Adjustment</td><td><p>It is now harder for the hold button version of heavy attacks to be performed by accident when rapidly pressing the heavy attack button after one of these techniques are performed.</p></td></tr>
    <tr><td>Ponte Milvio (Backwards Throw)</td><td>Universal Adjustment</td><td><p>Distance increased between characters when the opponent is thrown into the corner.</p></td></tr>
    <tr><td>Drive Reversal</td><td>Bug Fix</td><td><p>Fixed an issue where the advantage on this move when forcing an opponent in Burnout to block it differed from other characters.</p></td></tr>
    <tr><td>Jumping Heavy Attacks (Charged/While Charging)</td><td>Adjustment</td><td><p>Landing recovery reduced by 3 frames.</p></td></tr>
    <tr><td>Charged Standing Heavy Punch</td><td>Adjustment</td><td><p>

1. Recovery on hit and block changed from 22 to 21 frames.
2. Advantage on hit changed from +6 to +7 frames.
3. Advantage on block changed from +3 to +4 frames.
</p></td></tr>
    <tr><td>Normal/Charged Standing Heavy Kick</td><td>Adjustment</td><td><p>

1. Proximity block trigger startup changed from 4 frames prior to the end of the attack startup to the 2nd frame of the technique.
2. Removed the hurtbox around the feet that appeared before the non-hold version's hitbox appeared.</p></td></tr>
    <tr><td>Crouching Medium Punch</td><td>Adjustment</td><td><p>Expanded the hurtbox around the feet between frames 21 - 26 of the technique.</p></td></tr>
    <tr><td>Normal/Charged Crouching Heavy Punch</td><td>Adjustment</td><td><p>Proximity block trigger startup changed from 4 frames prior to the end of the attack startup to the 2nd frame of the technique.</p></td></tr>
    <tr><td>Charged Crouching Heavy Punch</td><td>Adjustment</td><td><p>Disadvantage on block changed from -5 to -3 frames.</p></td></tr>
    <tr><td>Normal/Charged Crouching Heavy Kick</td><td>Adjustment</td><td><p>Proximity block trigger startup changed from 4 frames prior to the end of the attack startup to the 2nd frame of the technique.</p></td></tr>
    <tr><td>Charged Crouching Heavy Kick</td><td>Adjustment</td><td><p>
1. Recovery on hit and block changed from 23 to 20 frames.
2. Advantage on hit changed from +32 to +35 frames.
3. Disadvantage on block changed from -6 to -3 frames.
4. Changed the opponent's damage reaction when hit while in the air.</p></td></tr>
    <tr><td>Jumping Heavy Punch</td><td>Adjustment</td><td><p>Active frames changed from 5 to 7 frames.</p></td></tr>
    <tr><td>Light Two Hitter (Light Punch > Light Punch)</td><td>Adjustment</td><td><p>Combo scaling changed from 25% to 15%</p></td></tr>
    <tr><td>Falx Crusher (→ + Heavy Kick > → + Heavy Kick)</td><td>Adjustment</td><td><p>1. Increased forward movement before attack startup.
2. Increased juggle state time on hit.
3. Increased upward juggle state on hit.
4. Increased combo count's initial value.
5. Reduced combo count's additional value.
6. Input buffer time changed from 5 frames to 9 frames.</p></td></tr>
    <tr><td></td><td>Universal AdjustmentAdjustment</td><td><p>When using Classic controls, pressing Heavy Punch at the same time as the second input will cause the second attack to not come out.</p></td></tr>
    <tr><td>Overdrive Normal/Charged Gladius (↓↘→ + Two Punches)</td><td>Adjustment</td><td><p>Initial scaling of 30% added.</p></td></tr>
    <tr><td>Overdrive Quadriga (↓↘→ + Two Kicks)</td><td>Adjustment</td><td><p>
1. Pushback increased.
2. Input buffer time changed from 5 to 10 frames.</p></td></tr>
    <tr><td>Normal/Overdrive Phalanx (→↓↘ + Punch/Two Punches)</td><td>Adjustment</td><td><p>Cannot recover backwards on Punish Counter.</p></td></tr>
    <tr><td>Overdrive Phalanx (→↓↘ + Two Punches)</td><td>Adjustment</td><td><p>Advantage on block changed from +2 to +4 frames.</p></td></tr>
    <tr><td>Normal/Overdrive Scutum (↓↙← + Kick/Two Kicks)</td><td>Adjustment</td><td><p>
1. Now capable of breaking super armor.
2. Disadvantage on block changed from -5 to -3 frames.</p></td></tr>
    <tr><td>Enfold (↓↙← + Kick > Light Punch + Light Kick)</td><td>Adjustment</td><td><p>Advantage on hit changed from +20 to +18 frames.</p></td></tr>
    <tr><td>SA1 Javelin of Marisa</td><td>Adjustment / Bug Fix</td><td><p>
Attack hitbox on successful counter expanded downwards.
<br>Fixed an issue where the Drive gauge would recover during the cutscene when used in a combo that utilized Drive Rush.
<br>The 1st frame of the technique was completely invincible, and this has been changed to be only strike and throw invincible.</p></td></tr>
    <tr><td>SA2 Meteorite</td><td>Adjustment / Bug Fix</td><td><p>
Adjusted so the pushback is not applied to the second attack when it hits in the air.
<br>Second attack's hitbox expanded forward.
<br>Collision pushbox when jumping in the air expanded downwards.
<br>Fixed an issue where the Drive gauge would recover during the cutscene when used in a combo that utilized Drive Rush.</p></td></tr>
    <tr><td>SA3 Goddess of the Hunt</td><td>Adjustment</td><td><p>Advantage on hit changed from +19 to +14 frames.</p></td></tr>
    <tr><td>CA Goddess of the Hunt</td><td>Adjustment</td><td><p>
Changed distance from opponent after the attack hits so that it matches Super Art 3.
Advantage on hit changed from +19 to +14 frames.</p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="lily">Lily</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="jp">JP</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="juri">Juri</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="dee-jay">Dee Jay</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="cammy">Cammy</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="ryu">Ryu</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="e.-honda">E. Honda</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="blanka">Blanka</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="guile">Guile</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="ken">Ken</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="chun-li">Chun-Li</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="zangief">Zangief</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="dhalsim">Dhalsim</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="rashid">Rashid</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="a.k.i.">A.K.I.</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<h2 id="ed">Ed</h2>
<table class="table-style">
<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>
<tbody>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
    <tr><td></td><td></td><td><p></p></td></tr>
</tbody>
</table>

<strong><a href="/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes/patch-history/docs/street-fighter-6/2024-05-22-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong> - <strong><a href="/patch-history/docs/street-fighter-6/" style="text-decoration: none;">back to patch list</a></strong> 

