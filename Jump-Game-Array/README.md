<div class="markdown-content" id="problem-content">
<p>Given an array of non-negative integers, <strong>A</strong>, you are initially positioned at the first index of the array.</p>
<p>Each element in the array represents your maximum jump length at that position.</p>
<p>Determine if you are able to reach the last index.<br/>
<br/></p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first and the only argument of input will be an integer array A.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer, representing the answer as described in the problem statement.
    =&gt; 0 : If you cannot reach the last index.
    =&gt; 1 : If you can reach the last index.
</code></pre>
</div>
<p><strong>Constraints:</strong><br/>
    1 &lt;= len(A) &lt;= 1e6<br/>
    0 &lt;= A[i] &lt;= 30</p>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [2,3,1,1,4]

Output 1:
    1

Explanation 1:
    Index 0 -&gt; Index 2 -&gt; Index 3 -&gt; Index 4 -&gt; Index 5

Input 2:
    A = [3,2,1,0,4]

Output 2:
    0

Explanation 2:
    There is no possible path to reach the last index.
</code></pre>
</div>

</div>