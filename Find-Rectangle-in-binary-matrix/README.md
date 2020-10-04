<div class="markdown-content" id="problem-content">
<p>Given a binary matrix of integers <strong>A</strong> of size <strong>N x M</strong> consisting of only <strong>0</strong> or <strong>1</strong>.<br/>
you need to check whether there exists a square or rectangle in a square whose all four corners are <strong>1</strong>. <br/>
All four corners need to be distinct.</p>
<p>If there exists such rectangle or square return 1, else return 0.</p>
<p><br/><br/>
<strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument given is the integer matrix A.
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code> Return 1 if there exists such rectangle/square whose all four corners are 1 else return 0.
</code></pre>
</div>
<p><strong>Constraints</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= N, M &lt;= 200
0 &lt;= A[i] &lt;= 1
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [   [0, 1, 1]
            [0, 1, 1]
            [0, 1, 0]   ]
Output 1:
    1
    Explanation 1:
    [ [1, 1]
      [1, 1] ]
      There exists a square whose all corners are 1.

Input 2:
    A = [   [0, 1, 1]
            [0, 0, 1]
            [0, 1, 0]   ]
Output 2:
    0
</code></pre>
</div>

</div>