<div class="markdown-content" id="problem-content">
<p>Given an array of integers <strong>A</strong> of size <strong>N</strong> and an integer <strong>B</strong>.</p>
<p>array <strong>A</strong> is rotated at some pivot unknown to you beforehand.</p>
<p><strong>(i.e., 0 1 2 4 5 6 7  might become 4 5 6 7 0 1 2 ).</strong></p>
<p>You are given a target value <strong>B</strong> to search. If found in the array, return its index, otherwise return <strong>-1</strong>.</p>
<p>You may assume no duplicate exists in the array.</p>
<p><strong>NOTE:-</strong> Array <strong>A</strong> was sorted in non-decreasing order before rotation.</p>
<blockquote>
<ul>
<li><strong>NOTE :</strong> Think about the case when there are duplicates. Does your current solution work? How does the time complexity change?*</li>
</ul>
</blockquote>
<p><strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument given is the integer array A.
The second argument given is the integer B.
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return index of B in array A, otherwise return -1
</code></pre>
</div>
<p><strong>Constraints</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= N &lt;= 1000000
1 &lt;= A[i] &lt;= 10^9
all elements in A are disitinct.
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [4, 5, 6, 7, 0, 1, 2, 3]
    B = 4
Output 1:
    0
Explanation 1:
 Target 4 is found at index 0 in A.


Input 2:
    A = [5, 17, 100, 3]
    B = 6
Output 2:
    -1
</code></pre>
</div>

</div>