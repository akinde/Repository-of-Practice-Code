<div class="markdown-content" id="problem-content">
<p>There is a rectangle with left bottom as <code class="highlighter-rouge"> (0, 0)</code> and right up as <code class="highlighter-rouge">(x, y)</code>. There are <code class="highlighter-rouge">N circles</code> such that their centers are inside the <code class="highlighter-rouge">rectangle</code>.<br/>
Radius of each circle is <code class="highlighter-rouge">R</code>. Now we need to find out if it is possible that we can move from <code class="highlighter-rouge">(0, 0)</code> to <code class="highlighter-rouge">(x, y)</code> without touching any <code class="highlighter-rouge">circle.</code></p>
<p><b>Note : </b> We can move from any cell to any of its <code class="highlighter-rouge">8 adjecent neighbours</code> and we cannot move outside the boundary of the rectangle at any point of time.<br/>
<br/><br/>
<strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1st argument given is an Integer x.
2nd argument given is an Integer y.
3rd argument given is an Integer N, number of circles.
4th argument given is an Integer R, radius of each circle.
5th argument given is an Array A of size N, where A[i] = x cordinate of ith circle
6th argument given is an Array B of size N, where B[i] = y cordinate of ith circle
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return YES or NO depending on weather it is possible to reach cell (x,y) or not starting from (0,0).
</code></pre>
</div>
<p><strong>Constraints</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>0 &lt;= x, y, R &lt;= 100
1 &lt;= N &lt;= 1000
Center of each circle would lie within the grid
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input:
    x = 2
    y = 3
    N = 1
    R = 1
    A = [2]
    B = [3]
Output:
    NO
   
Explanation:
    There is NO valid path in this case
</code></pre>
</div>

</div>