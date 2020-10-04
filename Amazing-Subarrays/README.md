<div class="markdown-content" id="problem-content">
<p>You are given a string <strong>S</strong>, and you have to find all the <strong>amazing substrings</strong> of <strong>S</strong>.</p>
<p>Amazing Substring is one that starts with a <strong>vowel</strong> (a, e, i, o, u, A, E, I, O, U).</p>
<p><strong>Input</strong></p>
<div class="highlighter-rouge">
<pre class="highlight"><code>Only argument given is string S.
</code></pre>
</div>
<p><strong>Output</strong></p>
<div class="highlighter-rouge">
<pre class="highlight"><code>Return a single integer X mod 10003, here X is number of Amazing Substrings in given string.
</code></pre>
</div>
<p><strong>Constraints</strong></p>
<div class="highlighter-rouge">
<pre class="highlight"><code>1 &lt;= length(S) &lt;= 1e6
S can have special characters
</code></pre>
</div>
<p><strong>Example</strong></p>
<div class="highlighter-rouge">
<pre class="highlight"><code>Input
    ABEC

Output
    6

Explanation
	Amazing substrings of given string are :
	1. A
	2. AB
	3. ABE
	4. ABEC
	5. E
	6. EC
	here number of substrings are 6 and 6 % 10003 = 6.
</code></pre>
</div>

</div>