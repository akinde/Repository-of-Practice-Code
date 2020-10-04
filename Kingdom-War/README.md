<div class="markdown-content" id="problem-content">
<p>Two kingdoms are on a war right now, kingdom X and kingdom Y. As a war specialist of kingdom X, you scouted kingdom Y area.</p>
<p>A kingdom area is defined as a <strong>N x M grid</strong> with each cell denoting a village.<br/>
Each cell has a value which denotes the strength of each corresponding village.<br/>
The strength can also be <strong>negative</strong>, representing those warriors of your kingdom who were held hostages.</p>
<p>There’s also another thing to be noticed.</p>
<ul>
<li>The strength of any village on row larger than one (2&lt;=r&lt;=N) is stronger or equal to the strength of village which is exactly above it.</li>
<li>The strength of any village on column larger than one (2&lt;=c&lt;=M) is stronger or equal to the strength of vilage which is exactly to its left.<br/>
(stronger means having higher value as defined above).</li>
</ul>
<p>So your task is, find the <strong>largest sum of strength</strong> that you can erase by bombing <strong>one sub-matrix</strong> in the grid.</p>
<p><strong>Input format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>First line consists of 2 integers N and M denoting the number of rows and columns in the grid respectively.
The next N lines, consists of M integers each denoting the strength of each cell.

1 &lt;= N &lt;= 1500
1 &lt;= M &lt;= 1500
-200 &lt;= Cell Strength &lt;= 200
</code></pre>
</div>
<p>Output:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>The largest sum of strength that you can get by choosing one sub-matrix.
</code></pre>
</div>
<p><strong>Example:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input:
3 3
-5 -4 -1
-3 2 4
2 5 8

Output:
19

Explanation:
Bomb the sub-matrix from (2,2) to (3,3): 2 + 4 + 5 + 8 = 19
</code></pre>
</div>

</div>