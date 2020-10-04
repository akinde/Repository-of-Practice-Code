<div class="markdown-content" id="problem-content">
<p>Given two strings <strong>A</strong> and <strong>B</strong>, find the minimum number of steps required to convert <strong>A</strong> to <strong>B</strong>. (each operation is counted as 1 step.)</p>
<p>You have the following 3 operations permitted on a word:</p>
<ul>
<li>Insert a character</li>
<li>Delete a character</li>
<li>Replace a character</li>
</ul>
<p><br/></p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument of input contains a string, A.
The second argument of input contains a string, B.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer, representing the minimum number of steps required.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= length(A), length(B) &lt;= 450
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = "abad"
    B = "abac"

Output 1:
    1

Explanation 1:
    Operation 1: Replace d with c.

Input 2:
    A = "Anshuman"
    B = "Antihuman"

Output 2:
    2

Explanation 2:
    =&gt; Operation 1: Replace s with t.
    =&gt; Operation 2: Insert i.
</code></pre>
</div>

</div>