<div class="markdown-content" id="problem-content">
<p>What is the time complexity of the following code :</p>
<div class="language-cpp highlighter-rouge"><pre class="highlight"><code>        <span class="kt">int</span> <span class="n">j</span> <span class="o">=</span> <span class="mi">0</span><span class="p">;</span>
        <span class="k">for</span><span class="p">(</span><span class="kt">int</span> <span class="n">i</span> <span class="o">=</span> <span class="mi">0</span><span class="p">;</span> <span class="n">i</span> <span class="o">&lt;</span> <span class="n">n</span><span class="p">;</span> <span class="o">++</span><span class="n">i</span><span class="p">)</span> <span class="p">{</span>
            <span class="k">while</span><span class="p">(</span><span class="n">j</span> <span class="o">&lt;</span> <span class="n">n</span> <span class="o">&amp;&amp;</span> <span class="n">arr</span><span class="p">[</span><span class="n">i</span><span class="p">]</span> <span class="o">&lt;</span> <span class="n">arr</span><span class="p">[</span><span class="n">j</span><span class="p">])</span> <span class="p">{</span>
                <span class="n">j</span><span class="o">++</span><span class="p">;</span>
            <span class="p">}</span>
        <span class="p">}</span>
</code></pre>
</div>
</div>