<div class="markdown-content" id="problem-content">
<p>There are <strong>A</strong> islands and there are <strong>M</strong> bridges connecting them. Each bridge has some <strong>cost</strong> attached to it.</p>
<p>We need to find bridges with <strong>minimal cost</strong> such that all islands are connected.</p>
<p>It is guaranteed that input data will contain <strong>at least one</strong> possible scenario in which all islands are connected with each other.</p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument contains an integer, A, representing the number of islands.
The second argument contains an 2-d integer matrix, B, of size M x 3:
    =&gt; Island B[i][0] and B[i][1] are connected using a bridge of cost B[i][2].
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer representing the minimal cost required.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= A, M &lt;= 6e4
1 &lt;= B[i][0], B[i][1] &lt;= A
1 &lt;= B[i][2] &lt;= 1e3
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = 4
    B = [   [1, 2, 1]
            [2, 3, 4]
            [1, 4, 3]
            [4, 3, 2]
            [1, 3, 10]  ]

Output 1:
    6

Explanation 1:
    We can choose bridges (1, 2, 1), (1, 4, 3) and (4, 3, 2), where the total cost incurred will be (1 + 3 + 2) = 6.

Input 2:
    A = 4
    B = [   [1, 2, 1]
            [2, 3, 2]
            [3, 4, 4]
            [1, 4, 3]   ]

Output 2:
    6

Explanation 2:
    We can choose bridges (1, 2, 1), (2, 3, 2) and (1, 4, 3), where the total cost incurred will be (1 + 2 + 3) = 6.
</code></pre>
</div>

</div>