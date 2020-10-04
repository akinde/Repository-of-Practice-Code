<div class="markdown-content" id="problem-content">
<p>Given a string <strong>A</strong> and a dictionary of words <strong>B</strong>, determine if <strong>A</strong> can be segmented into a space-separated sequence of one or more dictionary words.</p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument is a string, A.
The second argument is an array of strings, B.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return 0 / 1 ( 0 for false, 1 for true ) for this problem.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= len(A) &lt;= 6500
1 &lt;= len(B) &lt;= 10000
1 &lt;= len(B[i]) &lt;= 20
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = "myinterviewtrainer",
    B = ["trainer", "my", "interview"]

Output 1:
    1

Explanation 1:
    Return 1 ( corresponding to true ) because "myinterviewtrainer" can be segmented as "my interview trainer".
    
Input 2:
    A = "a"
    B = ["aaa"]

Output 2:
    0

Explanation 2:
    Return 0 ( corresponding to false ) because "a" cannot be segmented as "aaa".
</code></pre>
</div>

</div>