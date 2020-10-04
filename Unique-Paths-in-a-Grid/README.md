<div class="markdown-content" id="problem-content">
<p>Given a grid of size m * n, lets assume you are starting at <code class="highlighter-rouge">(1,1)</code> and your goal is to reach <code class="highlighter-rouge">(m,n)</code>. At any instance, if you are on <code class="highlighter-rouge">(x,y)</code>, you can either go to <code class="highlighter-rouge">(x, y + 1)</code> or <code class="highlighter-rouge">(x + 1, y)</code>.</p>
<p>Now consider if some obstacles are added to the grids. How many unique paths would there be?<br/>
An obstacle and empty space is marked as 1 and 0 respectively in the grid.</p>
<p><strong>Example :</strong><br/>
There is one obstacle in the middle of a 3x3 grid as illustrated below.</p>
<div class="highlighter-rouge"><pre class="highlight"><code>[
  [0,0,0],
  [0,1,0],
  [0,0,0]
]
</code></pre>
</div>
<p>The total number of unique paths is <code class="highlighter-rouge">2</code>.</p>
<blockquote>
<p><strong>Note:</strong> m and n will be at most 100.</p>
</blockquote>

</div>