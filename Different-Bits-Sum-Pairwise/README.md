<div class="markdown-content" id="problem-content">
<p>We define <code class="highlighter-rouge">f(X, Y)</code> as number of different corresponding bits in binary representation of X and Y. For example, <code class="highlighter-rouge">f(2, 7)</code> = 2, since binary representation of 2 and 7 are <code class="highlighter-rouge">010</code> and <code class="highlighter-rouge">111</code>, respectively. The first and the third bit differ, so <code class="highlighter-rouge">f(2, 7)</code> = 2.</p>
<p>You are given an array of N positive integers, A<sub>1</sub>, A<sub>2</sub> ,…, A<sub>N</sub>. Find sum of f(A<sub>i</sub>, A<sub>j</sub>) for all pairs (i, j) such that 1 ≤ i, j ≤ N. Return the answer modulo 10<sup>9</sup>+7.</p>
<p>For example,</p>
<div class="highlighter-rouge"><pre class="highlight"><code>A=[1, 3, 5]

We return

f(1, 1) + f(1, 3) + f(1, 5) + 
f(3, 1) + f(3, 3) + f(3, 5) +
f(5, 1) + f(5, 3) + f(5, 5) =

0 + 1 + 1 +
1 + 0 + 2 +
1 + 2 + 0 = 8
</code></pre>
</div>

</div>