<div class="markdown-content" id="problem-content">
<p>Given two words <strong>A</strong> and <strong>B</strong>, and a dictionary, <strong>C</strong>, find the length of <strong>shortest</strong> transformation sequence from <strong>A</strong> to <strong>B</strong>, such that:</p>
<ul>
<li>You must change exactly <strong>one</strong> character in every transformation.</li>
<li>Each intermediate word must exist in the dictionary.</li>
</ul>
<p><strong>Note:</strong></p>
<ol>
<li>Return <strong>0</strong> if there is no such transformation sequence.</li>
<li>All words have the same length.</li>
<li>All words contain only lowercase alphabetic characters.</li>
</ol>
<p><br/></p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument of input contains a string, A.
The second argument of input contains a string, B.
The third argument of input contains an array of strings, C.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer representing the minimum number of steps required to change string A to string B.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= length(A), length(B), length(C[i]) &lt;= 25
1 &lt;= length(C) &lt;= 5e3
</code></pre>
</div>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = "hit"
    B = "cog"
    C = ["hot", "dot", "dog", "lot", "log"]

Output 1:
    5

Explanation 1:
    "hit" -&gt; "hot" -&gt; "dot" -&gt; "dog" -&gt; "cog"
</code></pre>
</div>

</div>