<div class="markdown-content" id="problem-content">
<p>Implement regular expression matching with support for <code class="highlighter-rouge">'.'</code> and <code class="highlighter-rouge">'*'</code>.</p>
<p><code class="highlighter-rouge">'.'</code> Matches any single character.<br/>
<code class="highlighter-rouge">'*'</code> Matches zero or more of the preceding element.</p>
<p>The matching should cover the entire input string (not partial).</p>
<p>The function prototype should be:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>int isMatch(const char *s, const char *p)
</code></pre>
</div>
<p>Some examples:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>isMatch("aa","a") → 0
isMatch("aa","aa") → 1
isMatch("aaa","aa") → 0
isMatch("aa", "a*") → 1
isMatch("aa", ".*") → 1
isMatch("ab", ".*") → 1
isMatch("aab", "c*a*b") → 1
</code></pre>
</div>
<p>Return <code class="highlighter-rouge">0 / 1</code> ( 0 for false, 1 for true ) for this problem</p>

</div>