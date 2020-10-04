<div class="markdown-content" id="problem-content">
<p>Given a binary tree</p>
<div class="language-cpp highlighter-rouge"><pre class="highlight"><code>    <span class="k">struct</span> <span class="n">TreeLinkNode</span> <span class="p">{</span>
      <span class="n">TreeLinkNode</span> <span class="o">*</span><span class="n">left</span><span class="p">;</span>
      <span class="n">TreeLinkNode</span> <span class="o">*</span><span class="n">right</span><span class="p">;</span>
      <span class="n">TreeLinkNode</span> <span class="o">*</span><span class="n">next</span><span class="p">;</span>
    <span class="p">}</span>
</code></pre>
</div>
<p>Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to <code class="highlighter-rouge">NULL</code>.</p>
<p>Initially, all next pointers are set to <code class="highlighter-rouge">NULL</code>.</p>
<blockquote>
<p><strong>Note:</strong></p>
<ul>
<li>You may only use constant extra space.</li>
</ul>
</blockquote>
<p><strong>Example :</strong></p>
<p>Given the following binary tree,</p>
<div class="highlighter-rouge"><pre class="highlight"><code>         1
       /  \
      2    3
     / \  / \
    4  5  6  7
</code></pre>
</div>
<p>After calling your function, the tree should look like:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>         1 -&gt; NULL
       /  \
      2 -&gt; 3 -&gt; NULL
     / \  / \
    4-&gt;5-&gt;6-&gt;7 -&gt; NULL
</code></pre>
</div>
<blockquote>
<p><strong>Note 1:</strong>  that using recursion has memory overhead and does not qualify for constant space.<br/>
<strong>Note 2:</strong> The tree need not be a perfect binary tree.</p>
</blockquote>

</div>