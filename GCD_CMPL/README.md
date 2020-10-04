<div class="markdown-content" id="problem-content">
<p>In the following C++ function, let n &gt;= m.</p>
<div class="language-cpp highlighter-rouge"><pre class="highlight"><code>    <span class="kt">int</span> <span class="nf">gcd</span><span class="p">(</span><span class="kt">int</span> <span class="n">n</span><span class="p">,</span> <span class="kt">int</span> <span class="n">m</span><span class="p">)</span> <span class="p">{</span>
            <span class="k">if</span> <span class="p">(</span><span class="n">n</span><span class="o">%</span><span class="n">m</span> <span class="o">==</span><span class="mi">0</span><span class="p">)</span> <span class="k">return</span> <span class="n">m</span><span class="p">;</span>
            <span class="k">if</span> <span class="p">(</span><span class="n">n</span> <span class="o">&lt;</span> <span class="n">m</span><span class="p">)</span> <span class="n">swap</span><span class="p">(</span><span class="n">n</span><span class="p">,</span> <span class="n">m</span><span class="p">);</span>
            <span class="k">while</span> <span class="p">(</span><span class="n">m</span> <span class="o">&gt;</span> <span class="mi">0</span><span class="p">)</span> <span class="p">{</span>
                <span class="n">n</span> <span class="o">=</span> <span class="n">n</span><span class="o">%</span><span class="n">m</span><span class="p">;</span>
                <span class="n">swap</span><span class="p">(</span><span class="n">n</span><span class="p">,</span> <span class="n">m</span><span class="p">);</span>
            <span class="p">}</span>
            <span class="k">return</span> <span class="n">n</span><span class="p">;</span>
    <span class="p">}</span>
</code></pre>
</div>
<p>What is the time complexity of the above function assuming <code class="highlighter-rouge">n &gt; m</code>?</p>
</div>