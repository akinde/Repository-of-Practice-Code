<div class="markdown-content" id="problem-content">
<p>Given a binary tree containing digits from 0-9 only, each root-to-leaf path could represent a number.</p>
<p>An example is the root-to-leaf path <code class="highlighter-rouge">1-&gt;2-&gt;3</code> which represents the number <code class="highlighter-rouge">123</code>.</p>
<p>Find the total sum of all root-to-leaf numbers % 1003.</p>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>    1
   / \
  2   3
</code></pre>
</div>
<p>The root-to-leaf path <code class="highlighter-rouge">1-&gt;2</code> represents the number <code class="highlighter-rouge">12</code>.<br/>
The root-to-leaf path <code class="highlighter-rouge">1-&gt;3</code> represents the number <code class="highlighter-rouge">13</code>.</p>
<p>Return the sum = <code class="highlighter-rouge">(12 + 13) % 1003 = 25 % 1003 = 25</code>.</p>

</div>