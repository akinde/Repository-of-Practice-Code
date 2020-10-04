<div class="markdown-content" id="problem-content">
<p>The demons had captured the princess <strong>(P)</strong> and imprisoned her in the bottom-right corner of a dungeon. The dungeon consists of <code class="highlighter-rouge">M x N</code> rooms laid out in a 2D grid. Our valiant knight <strong>(K)</strong> was initially positioned in the top-left room and must fight his way through the dungeon to rescue the princess.</p>
<p>The knight has an initial health point represented by a positive integer. If at any point his health point drops to 0 or below, he dies immediately.</p>
<p>Some of the rooms are guarded by demons, so the knight loses health (negative integers) upon entering these rooms; other rooms are either empty (0’s) or contain magic orbs that increase the knight’s health (positive integers).</p>
<p>In order to reach the princess as quickly as possible, the knight decides to move only rightward or downward in each step.</p>
<p><strong>Write a function to determine the knight’s minimum initial health so that he is able to rescue the princess.</strong></p>
<p>For example, given the dungeon below, the initial health of the knight must be at least 7 if he follows the optimal path</p>
<p><code class="highlighter-rouge">RIGHT-&gt; RIGHT -&gt; DOWN -&gt; DOWN</code>.</p>
<p><img alt="Dungeon Princess: Example 1" src="http://i.imgur.com/5a6Neu4.png"/></p>
<p><br/><br/>
<strong>Input arguments to function:</strong><br/>
Your function will get  an M*N matrix (2-D array) as input which represents the 2D grid as described in the question. Your function should return an integer corresponding to the knight’s minimum initial health required. <br/>
<br/><br/></p>
<blockquote>
<p><strong>Note:</strong></p>
<ul>
<li>The knight’s health has no upper bound.</li>
<li>Any room can contain threats or power-ups, even the first room the knight enters and the bottom-right room where the princess is imprisoned.</li>
</ul>
</blockquote>

</div>