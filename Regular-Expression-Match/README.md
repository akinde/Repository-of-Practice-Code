<div class="markdown-content" id="problem-content">
<p>Implement wildcard pattern matching with support for ‘?’ and ‘*’ for strings <strong>A</strong> and <strong>B</strong>.</p>
<ul>
<li>’?’  : Matches any single character.</li>
<li>‘*’  : Matches any sequence of characters (including the empty sequence).</li>
</ul>
<p>The matching should cover the entire input string (not partial).</p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument of input contains a string A.
The second argument of input contains a string B.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return 0 or 1:
    =&gt; 0 : If the patterns do not match.
    =&gt; 1 : If the patterns match.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= length(A), length(B) &lt;= 9e4
</code></pre>
</div>
<p><strong>Examples :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = "aa"
    B = "a"

Output 1:
    0

Input 2:
    A = "aa"
    B = "aa"

Output 2:
    1

Input 3:
    A = "aaa"
    B = "aa"

Output 3:
    0
    
Input 4:
    A = "aa"
    B = "*"

Output 4:
    1

Input 5:
    A = "aa"
    B = "a*"

Output 5:
    1

Input 6:
    A = "ab"
    B = "?*"

Output 6:
    1

Input 7:
    A = "aab"
    B = "c*a*b"

Output 7:
    0
</code></pre>
</div>

</div>