# 2023-12-01 - SF6 PATCHNOTES
---
<br>

<h3 id="top">General Changes</h3>
<strong><a href="/patch-history/docs/street-fighter-6/" style="text-decoration: none;">back to patch list</a></strong>
<br>
<br>

><h4>Assisted Combos</h4>
<p>
Fixed an issue that caused the Assisted Combo input buffer start timing to be 1 frame slower than expected.

With this fix, another issue that caused Chun-Li and Kimberly's Assisted Combos to not continue when attempting a jump cancel at the same time a button was pressed is also fixed.
</p>

><h4>Taunt</h4>
<p>
There was an issue that caused a Taunt to be performed when canceling into a special move from a normal attack, etc., when the player mistakenly hit other buttons at the same time. It has been fixed so that special moves cannot be canceled by Taunts on the 1st frame of the attack.
</p>

><h4>Perfect Parry</h4>
<p>
Fixed an issue where invincibility time was shortened when specific actions were taken after a successful Perfect Parry.
</p>

><h4>Perfect Parry</h4>
<p>

1. Changed the input buffer time when recovering from 4 frames to 7 frames.

2. Fixed an issue where if the opponent performs a Super Art, if certain attacks are input immediately after the screen darkens, once the screen transition is finished, the move will be performed.
</p>

<!-- Section Index -->
<h3>Specific character updates this patch</h3>
<table class="character-table-style">
<tbody>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#jamie">Jamie</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#marisa">Marisa</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#jp">JP</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#juri">Juri</a></td>
    </tr>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#dee-jay">Dee Jay</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#cammy">Cammy</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#ryu">Ryu</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#e.-honda">E. Honda</a></td>
    </tr>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#blanka">Blanka</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#guile">Guile</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#chun-li">Chun-Li</a></td>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#rashid">Rashid</a></td>
    </tr>
    <tr>
        <td><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#a.k.i.">A.K.I.</a></td>
    </tr>
</tbody>
</table>

---

<br>

<h2 id="jamie">Jamie</h2>

<br>

><h4>Tensei Kick (↓+2 Kicks)</h4>
<p>
Can no longer be canceled by taunts on the 1st frame of the attack.
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="marisa">Marisa</h2>

<br>

><h4>Javelin of Marisa (Super Art Level 2)</h4>
<p>
Fixed an issue where the attack start up is 1 frame faster when the button is released with specific timing.
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="jp">JP</h2>

<br>

><h4>Air Throw</h4>
<p>
Fixed an issue where if a mid-air throw was attempted after warping via Departure: Window, JP would not have the Punish Counter/Forced Knockdown property attached to him.
</p>

><h4>Bylina (→+Heavy Kick)</h4>
<p>

1. Fixed an issue where if the 2nd attack was blocked low, it could not be canceled.

2. Fixed an issue where if the 2nd attack's active part on hit caused the cancel to be 1 frame slower.
</p>

><h4>Embrace (↓↙←+Kick)</h4>
<p>
Fixed an issue where the attack would not hit an opponent facing backward.
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="juri">Juri</h2>

<br>

><h4>Feng Shui Engine (Super Art level 2)</h4>
<p>
Fixed an issue where while Feng Shui Engine is active, Drive Gauge recovery amount was different from normal depending on time elapsed.

■ On ground (Normal)<br>Every frame: changed from 50 to 40

■ Mid-air (Normal, Burnout)<br>Every frame: changed from 10 to 20
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="dee-jay">Dee Jay</h2>

<br>

><h4>Speedy Maracas (↓↓+2 Punches)</h4>
<p>

1. Fixed an issue where a Punish Counter property was added after the 2nd frame of the technique when the command was input by plinking the Punch buttons, causing the game to recognize it as a canceled activation.

2. During Modern controls, Speedy Maracas could not be performed if the player attempted to plink the command as Down+Medium Attack > Heavy Attack.
*Plinking: Quickly pressing two or more buttons exactly one frame apart

3. Fixed an issue where the technique would not end even if the button was released when the player had 1 bar of Super Art gauge or less.

4. Fixed an issue when using Modern controls where the button required to continue the technique was different depending on the amount of Super Art gauge.
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="cammy">Cammy</h2>

<br>

><h4>Fatal Leg Twister (↓↘→+Punch > Light Punch+Light Kick)</h4>
<p>
Fixed an issue where a mid-air opponent would look they were being thrown when specific attacks hit.
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="ryu">Ryu</h2>

<br>

><h4>Collarbone Breaker (→+Medium Punch)</h4>
<p>
The amount of Drive Gauge obtained by the opponent when 2nd attack was blocked was changed from 625 to 1250.

Please note that if the 1st attack is blocked, the 2nd attack is considered a high attack.
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="e.-honda">E. Honda</h2>

<br>

><h4>Ultimate Killer Head Ram (Super Art Level 2)</h4>
<p>
Fixed an issue where if you performed the attack with the SP Button while using Modern controls, the charge time would be 5 frames longer.
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="blanka">Blanka</h2>

<br>

><h4>Rock Crusher (→+Medium Punch)</h4>
<p>
The amount of Drive Gauge obtained by the opponent when 2nd attack was blocked was changed from 1250 to 625.

Please note that if the 1st attack is blocked, the 2nd attack is considered a high attack.
</p>

><h4>Standing Heavy Punch</h4>
<p>

1. Fixed an issue where Blanka's recovery would be extended when this attack collides with an opponent's Drive Parry, Perfect Parry or super armor.<br>*The extended recovery when this attack misses is by design.

2. Fixed an issue where the special move input buffer timing was earlier than expected when Super Art 2 is active.
</p>

><h4>Standing Light Kick</h4>
<p>
Fixed an issue where while Lightning Beast is active, the hurtbox in front of the character before an attack starts gets hit by an opponent's cross-up attack.
</p>

><h4>Standing Medium Kick</h4>
<p>
Fixed an issue where while Lightning Beast is active, the special move cancel input buffer timing is earlier.
</p>

><h4>Crouching Light Punch</h4>
<p>
Fixed an issue where while Lightning Beast is active, the hurtbox in front of the character before an attack starts gets hit by an opponent's cross-up attack.
</p>

><h4>Crouching Medium Punch</h4>
<p>
Fixed an issue where while Lightning Beast is active, the hurtbox at the feet is smaller than normal.
</p>

><h4>Jumping Medium Punch</h4>
<p>
Fixed an issue where while Lightning Beast is active, the collision pushbox would not expand when the attack hits.
</p>

><h4>Overdrive Rolling Attack (Charge ←, →+2 Punches)</h4>
<p>
Fixed an issue where while Lightning Beast is active, the input buffer to cancel into Rolling Cannon would not work.
</p>

><h4>Heavy Rolling Attack (Charge ←, →+Heavy Punch)</h4>
<p>
Fixed an issue where while Lightning Beast is active, the bounce back distance became shorter when the attack was Perfect Parried.
</p>

><h4>Vertical Rolling Attack (Charge ↓,↑+Kick)</h4>
<p>
Fixed an issue where while Lightning Beast is active, the input buffer to cancel into Rolling Cannon would not work.
</p>

><h4>Overdrive Backstep Rolling Attack (↓↙←+2 Kicks)</h4>
<p>
Fixed an issue where while Lightning Beast is active, the active frames of the first attack would be 2 frames shorter.
</p>

><h4>Lightning Beast (Super Art Level 2)</h4>
<p>
Fixed an issue where while Lightning Beast is active, Drive Gauge recovery amount was different from normal depending on time elapsed.

■ On ground (Normal)<br>Every frame: changed from 50 to 40

■ Mid-air (Normal, Burnout)<br>Every frame: changed from 10 to 20
</p>


<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="guile">Guile</h2>

<br>

><h4>Solid Puncher (Super Art Level 2)</h4>
<p>
Fixed an issue where while Solid Puncher is active, Drive Gauge recovery amount was different from normal depending on time elapsed.

■ On ground (Normal)<br>Every frame: changed from 50 to 40

■ Mid-air (Normal, Burnout)<br>Every frame: changed from 10 to 20
</p>

><h4>Backward Throw</h4>
<p>
Fixed an issue where the animation during a throw was off when performed on big characters.
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="chun-li">Chun-Li</h2>

<br>

><h4>Lotus Fist (↓↙←+Punch > Heavy Punch)</h4>
<p>
The amount of Drive Gauge obtained by the opponent when 2nd attack was blocked was changed from 1250 to 2500.

Please note that if the 1st attack is blocked, the 2nd attack is considered a high attack.
</p>

><h4>Jumping Medium Punch</h4>
<p>
Fixed an issue where the 1st attack was considered a high attack between the 3rd and 4th active frames.
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="rashid">Rashid</h2>

<br>

><h4>Ysaar (Super Art Level 2)</h4>
<p>

1. Fixed an issue where if you performed a boostable special move on the final state of the tornado, you could not boost a special move again afterwards.

2. Fixed an issue where if you kicked the tornado during its final state with Arabian Cyclone, it would move at the same speed as before it was kicked.
</p>

<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong>

<br>

<h2 id="a.k.i.">A.K.I.</h2>

<br>

><h4>Crouching Heavy Kick</h4>
<p>
Fixed an issue where the attack was given a low hit property from frames 2 - 5. This has been fixed to a high hit property.
</p>

><h4>Chi Wen (→+Heavy Punch)</h4>
<p>
Fixed an issue where A.K.I.'s recovery would increase when her techniques are Perfect Parried.
</p>

><h4>Light Serpent Lash (↓↘→+Light Punch)</h4>
<p>
Fixed an issue where A.K.I.'s recovery would increase when her techniques are Perfect Parried.
</p>

><h4>Medium Serpent Lash (↓↘→+ Medium Punch)</h4>
<p>
Fixed an issue where a move would not be performed if Down was input during a successful command input when using Modern controls.
</p>

><h4>Medium Snake Step (Neutral+SP)</h4>
<p>
Fixed an issue where Medium Snake Step would be performed when certain commands other than the SP Button were input when using Modern controls.
</p>

><h4>Overdrive Snake Step (Assist+Neutral+SP)</h4>
<p>
When using Modern controls, pressing the SP Button by itself performed Snake Step. However, the canceled version of Overdrive Snake Step would be performed after Nightshade Pulse even if you were holding a direction input.

Due to this, if the player attempted to repeatedly press the button while inputting Overdrive Nightshade Pulse, Overdrive Snake Step would unintentionally be performed. Due to this, the canceled version of Overdrive Snake Step can only be performed with no direction input.
</p>

><h4>Entrapment (↓+2 Punches > Light Punch+Light Kick)</h4>
<p>

1. Fixed an issue where the hit effect would not be displayed on Punish Counter.

2. Fixed an issue where a mid-air opponent would look they were being thrown when specific attacks hit.
</p>

><h4>Overdrive Cruel Fate (↓↙←+2 Kicks)</h4>
<p>
Fixed an issue where immediately after A.K.I. jumps over the opponent, the command input would be the opposite of the original direction.
</p>


<strong><a href="/patch-history/docs/street-fighter-6/2023-12-01-sf6-patchnotes#top" style="text-decoration: none;">return to top</a></strong> - <strong><a href="/patch-history/docs/street-fighter-6/" style="text-decoration: none;">back to patch list</a></strong> 

