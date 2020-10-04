<div class="markdown-content" id="problem-content">
<p>Find the lowest common ancestor in an unordered binary tree given two values in the tree.</p>
<blockquote>
<p><strong>Lowest common ancestor :</strong> the lowest common ancestor (LCA) of two nodes <code class="highlighter-rouge">v</code> and <code class="highlighter-rouge">w</code> in a tree or directed acyclic graph (DAG) is the lowest (i.e. deepest) node that has both <code class="highlighter-rouge">v</code> and <code class="highlighter-rouge">w</code> as descendants.</p>
</blockquote>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>
        _______3______
       /              \
    ___5__          ___1__
   /      \        /      \
   6      _2_     0        8
         /   \
         7    4
</code></pre>
</div>
<p>For the above tree, the LCA of nodes <code class="highlighter-rouge">5</code> and <code class="highlighter-rouge">1</code> is <code class="highlighter-rouge">3</code>.</p>
<blockquote>
<p><strong>LCA</strong> = Lowest common ancestor</p>
</blockquote>
<p>Please note that LCA for nodes <code class="highlighter-rouge">5</code> and <code class="highlighter-rouge">4</code> is <code class="highlighter-rouge">5</code>.</p>
<blockquote>
<ul>
<li>You are given 2 values. Find the lowest common ancestor of the two nodes represented by <code class="highlighter-rouge">val1</code> and <code class="highlighter-rouge">val2</code></li>
<li>No guarantee that <code class="highlighter-rouge">val1</code> and <code class="highlighter-rouge">val2</code> exist in the tree. If one value doesn’t exist in the tree then return -1.</li>
<li>There are no duplicate values.</li>
<li>You can use extra memory, helper functions, and can modify the node struct but, you can’t add a parent pointer.</li>
</ul>
</blockquote>

</div>