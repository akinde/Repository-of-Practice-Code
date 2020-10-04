<div class="markdown-content" id="problem-content">
<p>Given <strong>A</strong>, <strong>B</strong>, <strong>C</strong>, find whether <strong>C</strong> is formed by the interleaving of <strong>A</strong> and <strong>B</strong>.</p>
<p><strong>Input Format:</strong>*</p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument of input contains a string, A.
The second argument of input contains a string, B.
The third argument of input contains a string, C.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer, 0 or 1:
    =&gt; 0 : False
    =&gt; 1 : True
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= length(A), length(B), length(C) &lt;= 150
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = "aabcc"
    B = "dbbca"
    C = "aadbbcbcac"

Output 1:
    1
    
Explanation 1:
    "aa" (from A) + "dbbc" (from B) + "bc" (from A) + "a" (from B) + "c" (from A)

Input 2:
    A = "aabcc"
    B = "dbbca"
    C = "aadbbbaccc"

Output 2:
    0

Explanation 2:
    It is not possible to get C by interleaving A and B.
</code></pre>
</div>

</div>