<div class="markdown-content" id="problem-content">
<p>Given a set of candidate numbers <code class="highlighter-rouge">(C)</code> and a target number <code class="highlighter-rouge">(T)</code>, find all unique combinations in <code class="highlighter-rouge">C</code> where the candidate numbers sums to <code class="highlighter-rouge">T</code>.</p>
<p>The same repeated number may be chosen from <code class="highlighter-rouge">C</code> unlimited number of times.</p>
<blockquote>
<p><strong>Note:</strong></p>
<ul>
<li>All numbers (including target) will be positive integers.</li>
<li>Elements in a combination (a1, a2, … , ak) must be in non-descending order. (ie, a1 ≤ a2 ≤ … ≤ ak).</li>
<li>The combinations themselves must be sorted in ascending order.</li>
<li>CombinationA &gt; CombinationB iff (a<sub>1</sub> &gt; b<sub>1</sub>) OR (a<sub>1</sub> = b<sub>1</sub> AND a<sub>2</sub> &gt; b<sub>2</sub>) OR … (a<sub>1</sub> = b<sub>1</sub> AND a<sub>2</sub> = b<sub>2</sub> AND … a<sub>i</sub> = b<sub>i</sub> AND a<sub>i+1</sub> &gt; b<sub>i+1</sub>)</li>
<li>The solution set must not contain duplicate combinations.</li>
</ul>
</blockquote>
<p><strong>Example</strong>, <br/>
Given candidate set <code class="highlighter-rouge">2,3,6,7</code> and target <code class="highlighter-rouge">7</code>,<br/>
A solution set is:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>[2, 2, 3]
[7]
</code></pre>
</div>
<blockquote>
<p><strong>Warning :</strong> DO NOT USE LIBRARY FUNCTION FOR GENERATING COMBINATIONS.<br/>
Example : itertools.combinations in python.<br/>
<em>If you do, we will disqualify your submission retroactively and give you penalty points.</em></p>
</blockquote>

</div>