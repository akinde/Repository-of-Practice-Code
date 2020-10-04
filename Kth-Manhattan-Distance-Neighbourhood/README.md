<div class="markdown-content" id="problem-content">
<p>Given a matrix M of size nxm and an integer K, find the maximum element in the K manhattan distance neighbourhood for all elements in nxm matrix. <br/>
In other words, for every element M[i][j] find the maximum element M[p][q] such that <code class="highlighter-rouge">abs(i-p)+abs(j-q) &lt;= K</code>.</p>
<p><code class="highlighter-rouge">Note: Expected time complexity is O(N*N*K)</code></p>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= n &lt;= 300
1 &lt;= m &lt;= 300
1 &lt;= K &lt;= 300
0 &lt;= M[i][j] &lt;= 1000
</code></pre>
</div>
<p><strong>Example:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input:
M  = [[1,2,4],[4,5,8]] , K = 2

Output:
ans = [[5,8,8],[8,8,8]]

</code></pre>
</div>

</div>