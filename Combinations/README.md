<div class="markdown-content" id="problem-content">
<p>Given two integers <code class="highlighter-rouge">n</code> and <code class="highlighter-rouge">k</code>, return all possible combinations of <code class="highlighter-rouge">k</code> numbers out of <code class="highlighter-rouge">1 2 3 ... n</code>.</p>
<p>Make sure the combinations are <strong>sorted</strong>.</p>
<p>To elaborate,</p>
<ol>
<li>Within every entry, elements should be sorted. <code class="highlighter-rouge">[1, 4]</code> is a valid entry while <code class="highlighter-rouge">[4, 1]</code> is not.</li>
<li>Entries should be sorted within themselves.</li>
</ol>
<p><strong>Example :</strong><br/>
If <code class="highlighter-rouge">n = 4</code> and <code class="highlighter-rouge">k = 2</code>, a solution is:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>[
  [1,2],
  [1,3],
  [1,4],
  [2,3],
  [2,4],
  [3,4],
]
</code></pre>
</div>
<blockquote>
<p><strong>Warning :</strong> DO NOT USE LIBRARY FUNCTION FOR GENERATING COMBINATIONS.<br/>
Example : itertools.combinations in python.<br/>
<em>If you do, we will disqualify your submission retroactively and give you penalty points.</em></p>
</blockquote>

</div>