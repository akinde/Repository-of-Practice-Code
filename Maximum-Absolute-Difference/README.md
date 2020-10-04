<div class="markdown-content" id="problem-content">
<p>You are given an array of N integers, A<sub>1</sub>, A<sub>2</sub> ,…, A<sub>N</sub>. Return maximum value of <code class="highlighter-rouge">f(i, j)</code> for all 1 ≤ <em>i, j</em> ≤ N.<br/>
<code class="highlighter-rouge">f(i, j)</code> is defined as <code class="highlighter-rouge">|A[i] - A[j]| + |i - j|</code>, where |x| denotes absolute value of x.</p>
<p><strong>For example</strong>,</p>
<div class="highlighter-rouge"><pre class="highlight"><code>A=[1, 3, -1]

f(1, 1) = f(2, 2) = f(3, 3) = 0
f(1, 2) = f(2, 1) = |1 - 3| + |1 - 2| = 3
f(1, 3) = f(3, 1) = |1 - (-1)| + |1 - 3| = 4
f(2, 3) = f(3, 2) = |3 - (-1)| + |2 - 3| = 5

So, we return 5.
</code></pre>
</div>

</div>