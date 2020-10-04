<div class="markdown-content" id="problem-content">
<p>Given a number <strong>A</strong>, return number of ways you can draw <strong>A</strong> chords in a circle with <strong>2 x A</strong> points such that no <strong>2</strong> chords intersect.</p>
<p>Two ways are different if there exists a chord which is present in one way and not in other.</p>
<p>Return the answer modulo <strong>10<sup>9</sup> + 7</strong>.</p>
<p><br/></p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first and the only argument contains the integer A.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer answering the query as described in the problem statement.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= A &lt;= 1000
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = 1

Output 1:
    1

Explanation 1:
    If points are numbered 1 to 2 in clockwise direction, then different ways to draw chords are:
    {(1-2)} only.
    So, we return 1.

Input 2:
    A = 2

Output 2:
    2

Explanation 2:
    If points are numbered 1 to 4 in clockwise direction, then different ways to draw chords are:
    {(1-2), (3-4)} and {(1-4), (2-3)}.
    So, we return 2.
</code></pre>
</div>

</div>