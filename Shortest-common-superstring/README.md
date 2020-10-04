<div class="markdown-content" id="problem-content">
<p>Given a set of strings, <strong>A</strong> of length <strong>N</strong>.</p>
<p>Return the length of smallest string which has all the strings in the set as substring.</p>
<p><br/></p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first and the only argument has an array of strings, A.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer representing the minimum possible length of the resulting string.
</code></pre>
</div>
<p><strong>Constraints</strong>:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= N &lt;= 18
1 &lt;= A[i] &lt;= 100
</code></pre>
</div>
<p><strong>Example</strong>:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = ["aaaa", "aa"]

Output 1:
    4

Explanation 1:
    Shortest string: "aaaa"

Input 2:
    A = ["abcd", "cdef", "fgh", "de"]

Output 2:
    8

Explanation 2:
    Shortest string: "abcdefgh"
</code></pre>
</div>

</div>