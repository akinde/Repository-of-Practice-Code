<div class="markdown-content" id="problem-content">
<p>There are <strong>A</strong> cities numbered from <strong>1 to A</strong>. You have already visited <strong>M</strong> cities, the indices of which are given in an array <strong>B</strong> of M integers.</p>
<p>If a city with index <strong>i</strong> is visited, you can visit either the city with index <strong>i-1 (i &gt;= 2)</strong> or the city with index <strong>i+1 (i &lt; A)</strong> if they are not already visited. <br/> Eg: if N = 5 and array M consists of [3, 4], then in the first level of moves, you can either visit 2 or 5.</p>
<p>You keep visiting cities in this fashion until all the cities are not visited. <br/> Find the number of ways in which you can visit all the cities <strong>modulo 10^9+7</strong>.</p>
<p><strong>Input Format</strong></p>
<div class="highlighter-rouge">
<pre class="highlight"><code>The 1st argument given is an integer A, i.e total number of cities.
The 2nd argument given is an integer array B, where B[i] denotes ith city you already visited.
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge">
<pre class="highlight"><code>Return an Integer X % (1e9 + 7), number of ways in which you can visit all the cities.
</code></pre>
</div>
<p><strong>Constraints</strong></p>
<div class="highlighter-rouge">
<pre class="highlight"><code>1 &lt;= A &lt;= 1000
1 &lt;= M &lt;= A
1 &lt;= B[i] &lt;= A
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge">
<pre class="highlight"><code>Input:
    A = 5
    B = [2, 5]
Output:
    6
   
Explanation:
    All possible ways to visit remaining cities are :
    1. 1 -&gt; 3 -&gt; 4
    2. 1 -&gt; 4 -&gt; 3
    3. 3 -&gt; 1 -&gt; 4
    4. 3 -&gt; 4 -&gt; 1
    5. 4 -&gt; 1 -&gt; 3
    6. 4 -&gt; 3 -&gt; 1
</code></pre>
</div>

</div>