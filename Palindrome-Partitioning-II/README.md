<div class="markdown-content" id="problem-content">
<p>Given a string <strong>A</strong>, partition <strong>A</strong> such that every substring of the partition is a palindrome.</p>
<p>Return the <strong>minimum</strong> cuts needed for a palindrome partitioning of <strong>A</strong>.</p>
<p><br/></p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first and the only argument contains the string A.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer, representing the answer as described in the problem statement.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= length(A) &lt;= 501
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = "aba"

Output 1:
    0

Explanation 1:
    "aba" is already a palindrome, so no cuts are needed.

Input 2:
    A = "aab"
    
Output 2:
    1

Explanation 2:
    Return 1 since the palindrome partitioning ["aa","b"] could be produced using 1 cut.
</code></pre>
</div>

</div>