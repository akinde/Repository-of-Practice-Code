<div class="markdown-content" id="problem-content">
<p>Given a string <strong>A</strong> representating json object. Return an array of string denoting json object with proper indentaion.</p>
<p>Rules for proper indentaion:</p>
<ul>
<li>Every inner brace should increase one indentation to the following lines.</li>
<li>Every close brace should decrease one indentation to the same line and the following lines.</li>
<li><strong>The indents can be increased with an additional ‘\t’</strong></li>
</ul>
<p><strong>Note</strong>:</p>
<ol>
<li>
<p><code class="highlighter-rouge">[]</code> and <code class="highlighter-rouge"><span class="p">{}</span></code> are only acceptable braces in this case.</p>
</li>
<li>
<p>Assume for this problem that space characters can be done away with.</p>
</li>
</ol>
<p><br/><br/>
<strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The only argument given is the integer array A.
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return a list of strings, where each entry corresponds to a single line. The strings should not have "\n" character in them.
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = "{A:"B",C:{D:"E",F:{G:"H",I:"J"}}}"
Output 1:
    { 
        A:"B",
        C: 
        { 
            D:"E",
            F: 
            { 
                G:"H",
                I:"J"
            } 
        } 
    }

Input 2:
    A = ["foo", {"bar":["baz",null,1.0,2]}]
Output 2:
   [
        "foo", 
        {
            "bar":
            [
                "baz", 
                null, 
                1.0, 
                2
            ]
        }
    ]
</code></pre>
</div>

</div>