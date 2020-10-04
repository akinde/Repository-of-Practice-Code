<div class="markdown-content" id="problem-content">
<p>Rearrange a given array so that <code class="highlighter-rouge">Arr[i]</code> becomes <code class="highlighter-rouge">Arr[Arr[i]]</code> with <code class="highlighter-rouge">O(1)</code> extra space.</p>
<p><strong>Example:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input : [1, 0]
Return : [0, 1]
</code></pre>
</div>
<blockquote>
<p>Lets say <code class="highlighter-rouge">N</code> = <code class="highlighter-rouge">size of the array</code>. Then, following holds true :</p>
<ul>
<li><strong>All elements in the array are in the range <code class="highlighter-rouge">[0, N-1]</code></strong></li>
<li><strong><code class="highlighter-rouge">N * N</code> does not overflow for a signed integer</strong></li>
</ul>
</blockquote>

</div>