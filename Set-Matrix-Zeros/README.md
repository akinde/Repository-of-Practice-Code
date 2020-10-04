<div class="markdown-content" id="problem-content">
<p>Given a matrix, <strong>A</strong> of size <strong>M x N</strong> of <strong>0s and 1s</strong>. If an element is <strong>0</strong>, set its entire row and column to <strong>0</strong>.</p>
<p><strong>Note:</strong> This will be evaluated on the extra memory used. Try to minimize the space and time complexity.</p>
<p><br/></p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first and the only argument of input contains a 2-d integer matrix, A, of size M x N.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return a 2-d matrix that satisfies the given conditions.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= N, M &lt;= 1000
0 &lt;= A[i][j] &lt;= 1
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    [   [1, 0, 1],
        [1, 1, 1], 
        [1, 1, 1]   ]

Output 1:
    [   [0, 0, 0],
        [1, 0, 1],
        [1, 0, 1]   ]

Input 2:
    [   [1, 0, 1],
        [1, 1, 1],
        [1, 0, 1]   ]

Output 2:
    [   [0, 0, 0],
        [1, 0, 1],
        [0, 0, 0]   ]
</code></pre>
</div>

</div>