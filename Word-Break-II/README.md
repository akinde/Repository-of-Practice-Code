<div class="markdown-content" id="problem-content">
<p>Given a string <strong>A</strong> and a dictionary of words <strong>B</strong>, add spaces in <strong>A</strong> to construct a sentence where each word is a valid dictionary word.</p>
<p>Return all such possible sentences.</p>
<p><strong>Note :</strong> Make sure the strings are sorted in your result.</p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument is a string, A.
The second argument is an array of strings, B.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return a vector of strings representing the answer as described in the problem statement.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= len(A) &lt;= 50
1 &lt;= len(B) &lt;= 25
1 &lt;= len(B[i]) &lt;= 20
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = "b"
    B = ["aabbb"]

Output 1:
    []

Input 1:
    A = "catsanddog",
    B = ["cat", "cats", "and", "sand", "dog"]

Output 1:
    ["cat sand dog", "cats and dog"]
</code></pre>
</div>

</div>