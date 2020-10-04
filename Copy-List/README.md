<div class="markdown-content" id="problem-content">
<p>A linked list is given such that each node contains an additional random pointer which could point to any node in the list or <code class="highlighter-rouge">NULL</code>.</p>
<p>Return a deep copy of the list.</p>
<p><strong>Example</strong></p>
<p>Given list</p>
<div class="highlighter-rouge"><pre class="highlight"><code>   1 -&gt; 2 -&gt; 3
</code></pre>
</div>
<p>with random pointers going from</p>
<div class="highlighter-rouge"><pre class="highlight"><code>  1 -&gt; 3
  2 -&gt; 1
  3 -&gt; 1
</code></pre>
</div>
<p>You should return a deep copy of the list. The returned answer should not contain the same node as the original list, but a copy of them. The pointers in the returned list should not link to any node in the original input list.</p>

</div>