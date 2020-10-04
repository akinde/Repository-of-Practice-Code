<div class="markdown-content" id="problem-content">
<p>Given a string s, partition s such that every string of the partition is a palindrome.</p>
<p>Return all possible palindrome partitioning of s.</p>
<p>For example, given <code class="highlighter-rouge">s = "aab"</code>,<br/>
Return</p>
<div class="highlighter-rouge"><pre class="highlight"><code>  [
    ["a","a","b"]
    ["aa","b"],
  ]
</code></pre>
</div>
<blockquote>
<p><strong>Ordering the results in the answer :</strong></p>
<p>Entry i will come before Entry j if :</p>
<ul>
<li>len(Entryi[0]) &lt; len(Entryj[0]) OR</li>
<li>(len(Entryi[0]) == len(Entryj[0]) AND len(Entryi[1]) &lt; len(Entryj[1])) OR<br/>
*<br/>
*<br/>
*</li>
<li>(len(Entryi[0]) == len(Entryj[0]) AND … len(Entryi[k] &lt; len(Entryj[k]))</li>
</ul>
</blockquote>
<p>In the given example,<br/>
<code class="highlighter-rouge">["a", "a", "b"]</code> comes before <code class="highlighter-rouge">["aa", "b"]</code> because <code class="highlighter-rouge">len("a") &lt; len("aa")</code></p>

</div>