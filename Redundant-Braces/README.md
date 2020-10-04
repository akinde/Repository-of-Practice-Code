<div class="markdown-content" id="problem-content">
<p>Given a string <strong>A</strong> denoting an expression. It contains the following operators <strong>’+’, ‘-‘, ‘*’, ‘/’</strong>.</p>
<p>Chech whether <strong>A</strong> has redundant braces or not.</p>
<p>Return <strong>1</strong> if <strong>A</strong> has redundant braces, else return <strong>0</strong>.</p>
<p><strong>Note</strong>: <strong>A</strong> will be always a valid expression.</p>
<p><br/><br/>
<strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The only argument given is string A.
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return 1 if string has redundant braces, else return 0.
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = "((a + b))"
Output 1:
    1
    Explanation 1:
        ((a + b)) has redundant braces so answer will be 1.

Input 2:
    A = "(a + (a + b))"
Output 2:
    0
    Explanation 2:
        (a + (a + b)) doesn't have have any redundant braces so answer will be 0.
</code></pre>
</div>

</div>