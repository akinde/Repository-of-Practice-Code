<div class="markdown-content" id="problem-content">
<p>Given an array <code class="highlighter-rouge">S</code> of <code class="highlighter-rouge">n</code> integers, are there elements <code class="highlighter-rouge">a, b, c, and d</code> in <code class="highlighter-rouge">S</code> such that <code class="highlighter-rouge">a + b + c + d = target</code>? Find all unique quadruplets in the array which gives the sum of target.</p>
<blockquote>
<p><strong>Note:</strong></p>
<ul>
<li>Elements in a quadruplet (a,b,c,d) must be in non-descending order. (ie, a ≤ b ≤ c ≤ d)</li>
<li>The solution set must not contain duplicate quadruplets.</li>
</ul>
</blockquote>
<p><strong>Example :</strong> <br/>
Given array <code class="highlighter-rouge">S = {1 0 -1 0 -2 2}</code>, and <code class="highlighter-rouge">target = 0</code><br/>
A solution set is:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>    (-2, -1, 1, 2)
    (-2,  0, 0, 2)
    (-1,  0, 0, 1)
</code></pre>
</div>
<p>Also make sure that the solution set is lexicographically sorted.<br/>
<code class="highlighter-rouge">Solution[i] &lt; Solution[j] iff Solution[i][0] &lt; Solution[j][0] OR (Solution[i][0] == Solution[j][0] AND ... Solution[i][k] &lt; Solution[j][k])</code></p>

</div>