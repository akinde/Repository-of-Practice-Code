<div class="markdown-content" id="problem-content">
<p>Given a sorted array of integers <strong>A</strong>(0 based index) of size <strong>N</strong>, find the starting and ending position of a given integar <strong>B</strong> in array <strong>A</strong>.</p>
<p>Your algorithm’s runtime complexity must be in the order of <code class="highlighter-rouge">O(log n)</code>.</p>
<p>Return an array of size <strong>2</strong>, such that <strong>first element = starting position of B in A</strong> and <strong>second element = ending position of B in A</strong>, if <strong>B</strong> is not found in <strong>A</strong> return <strong>[-1, -1]</strong>.</p>
<p><br/><br/>
<strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument given is the integer array A.
The second argument given is the integer B.
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code> Return an array of size 2, such that first element = starting position of B in A and second element = ending position of B in A, if B is not found in A return [-1, -1].
</code></pre>
</div>
<p><strong>Constraints</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= N &lt;= 10^6
1 &lt;= A[i], B &lt;= 10^9
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [5, 7, 7, 8, 8, 10]
    B = 8
Output 1:
    [3, 4]
Explanation 1:
    First occurence of 8 in A is at index 3
    Second occurence of 8 in A is at index 4
    ans = [3, 4]

Input 2:
    A = [5, 17, 100, 111]
    B = 3
Output 2:
    [-1, -1]
</code></pre>
</div>

</div>