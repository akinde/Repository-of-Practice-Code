<div class="markdown-content" id="problem-content">
<p>Write a bash script that finds all the <code class="highlighter-rouge">invalid</code> email addresses.</p>
<p>For simplicity, assume that a vaild email addresses has the following rules-</p>
<ul>
<li>Email should be of the form <code class="highlighter-rouge">local@domain.com</code></li>
<li>There can only be alphanumberic characters in the <code class="highlighter-rouge">local</code> part email address.</li>
<li>
<p>The following characters are valid in the <code class="highlighter-rouge">local</code> part of the email as long as they are not the first character.<br/>
<code class="highlighter-rouge">-</code>, <code class="highlighter-rouge">_</code>, <code class="highlighter-rouge">+</code>, <code class="highlighter-rouge">.</code></p>
</li>
<li>Email address can not start with a number.</li>
<li><code class="highlighter-rouge">Domain</code> name can only contain alphanumeric characters and <code class="highlighter-rouge">-</code>.</li>
<li><code class="highlighter-rouge">com</code> part can have atmost one <code class="highlighter-rouge">.</code>, for e.g. <code class="highlighter-rouge">co.uk</code> or <code class="highlighter-rouge">co.in</code> is valid but <code class="highlighter-rouge">as.df.gh</code> is invalid</li>
</ul>
<p><strong>Example:</strong></p>
<p>Assume that <code class="highlighter-rouge">input</code> has the following content:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>abc@example.co.uk
abc@example.com
abc&lt;&gt;@example.com
abc@example@gmail.com
</code></pre>
</div>
<p>Your script should output the following:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>abc&lt;&gt;@example.com
abc@example@gmail.com
</code></pre>
</div>

</div>