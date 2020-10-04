<div class="markdown-content" id="problem-content">
<p>Given a string, find the rank of the string amongst its permutations sorted lexicographically. <br/>
Note that the characters might be repeated. If the characters are repeated, we need to look at the rank in unique permutations. <br/>
Look at the example for more details.</p>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input : 'aba'
Output : 2

The order permutations with letters 'a', 'a', and 'b' : 
aab
aba
baa
</code></pre>
</div>
<p>The answer might not fit in an integer, so return <code class="highlighter-rouge">your answer % 1000003</code></p>
<blockquote>
<p><strong>NOTE:</strong> 1000003 is a prime number<br/>
<strong>NOTE:</strong> Assume the number of characters in string &lt; 1000003</p>
</blockquote>

</div>