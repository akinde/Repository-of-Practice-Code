<div class="markdown-content" id="problem-content">
<p>Given a string <strong>A</strong>, we may represent it as a binary tree by partitioning it to two non-empty substrings recursively.</p>
<p>Below is one possible representation of <strong>A = “great”</strong>:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>
    great
   /    \
  gr    eat
 / \    /  \
g   r  e   at
           / \
          a   t
 
</code></pre>
</div>
<p>To scramble the string, we may choose any non-leaf node and swap its two children.</p>
<p>For example, if we choose the node “gr” and swap its two children, it produces a scrambled string “rgeat”.</p>
<div class="highlighter-rouge"><pre class="highlight"><code>    rgeat
   /    \
  rg    eat
 / \    /  \
r   g  e   at
           / \
          a   t
</code></pre>
</div>
<p>We say that “rgeat” is a scrambled string of “great”.</p>
<p>Similarly, if we continue to swap the children of nodes “eat” and “at”, it produces a scrambled string “rgtae”.</p>
<div class="highlighter-rouge"><pre class="highlight"><code>    rgtae
   /    \
  rg    tae
 / \    /  \
r   g  ta  e
       / \
      t   a
</code></pre>
</div>
<p>We say that “rgtae” is a scrambled string of “great”.</p>
<p><br/></p>
<p>Given two strings <strong>A</strong> and <strong>B</strong> of the same length, determine if <strong>B</strong> is a scrambled string of <strong>S</strong>.</p>
<p><br/></p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument of input contains a string A.
The second argument of input contains a string B.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer, 0 or 1:
    =&gt; 0 : False
    =&gt; 1 : True
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= len(A), len(B) &lt;= 50
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = "we"
    B = "we"

Output 1:
    1

Input 2:
    A = "phqtrnilf"
    B = "ilthnqrpf"
    
Output 2:
    0
</code></pre>
</div>

</div>