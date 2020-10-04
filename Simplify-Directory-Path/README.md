<div class="markdown-content" id="problem-content">
<p>Given a string <strong>A</strong> representing an absolute path for a file (Unix-style).</p>
<p>Return the string A after simplifying the absolute path.</p>
<p><strong>Note</strong>:</p>
<ol>
<li>
<p>Absolute path always begin with <strong>’/’</strong> ( root directory ).</p>
</li>
<li>
<p>Path will not have whitespace characters.</p>
</li>
</ol>
<p><br/><br/>
<strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The only argument given is string A.
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return a string denoting the simplified absolue path for a file (Unix-style).
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = "/home/"
Output 1:
    "/home"

Input 2:
    A = "/a/./b/../../c/"
Output 2:
    "/c"
</code></pre>
</div>

</div>