<div class="markdown-content" id="problem-content">
<p>What is the time complexity of the following code :</p>
<div class="language-cpp highlighter-rouge"><pre class="highlight"><code>    <span class="kt">int</span> <span class="n">a</span> <span class="o">=</span> <span class="mi">0</span><span class="p">;</span>
    <span class="k">for</span> <span class="p">(</span><span class="n">i</span> <span class="o">=</span> <span class="mi">0</span><span class="p">;</span> <span class="n">i</span> <span class="o">&lt;</span> <span class="n">N</span><span class="p">;</span> <span class="n">i</span><span class="o">++</span><span class="p">)</span> <span class="p">{</span>
        <span class="k">for</span> <span class="p">(</span><span class="n">j</span> <span class="o">=</span> <span class="n">N</span><span class="p">;</span> <span class="n">j</span> <span class="o">&gt;</span> <span class="n">i</span><span class="p">;</span> <span class="n">j</span><span class="o">--</span><span class="p">)</span> <span class="p">{</span>
            <span class="n">a</span> <span class="o">=</span> <span class="n">a</span> <span class="o">+</span> <span class="n">i</span> <span class="o">+</span> <span class="n">j</span><span class="p">;</span>
        <span class="p">}</span>
    <span class="p">}</span>
</code></pre>
</div>
</div>