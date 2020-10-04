<div class="markdown-content" id="problem-content">
<p>Given an array of non-negative integers, <strong>A</strong>, of length <strong>N</strong>, you are initially positioned at the first index of the array.</p>
<p>Each element in the array represents your maximum jump length at that position.</p>
<p>Return the <strong>minimum</strong> number of jumps required to reach the last index.</p>
<p>If it is not possible to reach the last index, return -1.</p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first and the only argument contains an integer array, A.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer, representing the answer as described in the problem statement.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= N &lt;= 1e6
0 &lt;= A[i] &lt;= 50000
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [2, 1, 1]

Output 1:
    1
    
Explanation 1:
    The shortest way to reach index 2 is
        Index 0 -&gt; Index 2
    that requires only 1 jump.

Input 2:
    A = [2,3,1,1,4]

Output 2:
    2

Explanation 2:
    The shortest way to reach index 4 is
        Index 0 -&gt; Index 1 -&gt; Index 4
    that requires 2 jumps.
</code></pre>
</div>

</div>