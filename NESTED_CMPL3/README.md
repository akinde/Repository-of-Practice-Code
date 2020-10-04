<div class="markdown-content" id="problem-content">
<p>What is time complexity of following code :</p>
<div class="language-cpp highlighter-rouge"><pre class="highlight"><code>        <span class="kt">int</span> <span class="n">count</span> <span class="o">=</span> <span class="mi">0</span><span class="p">;</span>
        <span class="k">for</span> <span class="p">(</span><span class="kt">int</span> <span class="n">i</span> <span class="o">=</span> <span class="n">N</span><span class="p">;</span> <span class="n">i</span> <span class="o">&gt;</span> <span class="mi">0</span><span class="p">;</span> <span class="n">i</span> <span class="o">/=</span> <span class="mi">2</span><span class="p">)</span> <span class="p">{</span>
            <span class="k">for</span> <span class="p">(</span><span class="kt">int</span> <span class="n">j</span> <span class="o">=</span> <span class="mi">0</span><span class="p">;</span> <span class="n">j</span> <span class="o">&lt;</span> <span class="n">i</span><span class="p">;</span> <span class="n">j</span><span class="o">++</span><span class="p">)</span> <span class="p">{</span>
                <span class="n">count</span> <span class="o">+=</span> <span class="mi">1</span><span class="p">;</span>
            <span class="p">}</span>
        <span class="p">}</span>
</code></pre>
</div>
</div>