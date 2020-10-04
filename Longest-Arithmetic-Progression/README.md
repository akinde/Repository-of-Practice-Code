<div class="markdown-content" id="problem-content">
<p>Find <strong>longest</strong> Arithmetic Progression in an integer array <strong>A</strong> of size <strong>N</strong>, and return its length.</p>
<p>More formally, find longest sequence of indices, <strong>0 &lt; i1 &lt; i2 &lt; … &lt; ik &lt; ArraySize(0-indexed)</strong> such that sequence <strong>A[i1], A[i2], …, A[ik]</strong> is an Arithmetic Progression.</p>
<p>Arithmetic Progression is a sequence in which all the differences between consecutive pairs are the same, i.e sequence <strong>B[0], B[1], B[2], …, B[m - 1]</strong> of length <strong>m</strong> is an Arithmetic Progression if and only if <strong>B[1] - B[0] == B[2] - B[1] == B[3] - B[2] == … == B[m - 1] - B[m - 2]</strong></p>
<p><strong>Note:</strong> The common difference can be positive, negative or 0.</p>
<p><br/></p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first and the only argument of input contains an integer array, A.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer, representing the length of the longest possible arithmetic progression.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= N &lt;= 1000
1 &lt;= A[i] &lt;= 1e9
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [3, 6, 9, 12]

Output 1:
    4

Explanation 1:
    [3, 6, 9, 12] form an arithmetic progression.

Input 2:
    A = [9, 4, 7, 2, 10]

Output 2:
    3

Explanation 2:
    [4, 7, 10] form an arithmetic progression.
</code></pre>
</div>

</div>