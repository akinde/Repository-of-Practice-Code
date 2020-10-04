<div class="markdown-content" id="problem-content">
<p>Find the <strong>longest increasing subsequence</strong> of a given array of integers, <strong>A</strong>.</p>
<p>In other words, find a subsequence of array in which the subsequence’s elements are in strictly increasing order, and in which the subsequence is as long as possible. <br/>
This subsequence is not necessarily contiguous, or unique.<br/>
In this case, we only care about the <strong>length</strong> of the longest increasing subsequence.<br/>
<br/></p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first and the only argument is an integer array A.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer representing the length of the longest increasing subsequence.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= length(A) &lt;= 2500
1 &lt;= A[i] &lt;= 2000
</code></pre>
</div>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [1, 2, 1, 5]

Output 1:
    3
    
Explanation 1:
    The sequence : [1, 2, 5]

Input 2:
    A = [0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15]
    
Output 2:
    6

Explanation 2:
    The sequence : [0, 2, 6, 9, 13, 15] or [0, 4, 6, 9, 11, 15] or [0, 4, 6, 9, 13, 15]
</code></pre>
</div>

</div>