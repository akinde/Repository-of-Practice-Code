<div class="markdown-content" id="problem-content">
<p>What is the worst case time complexity of the following code :</p>
<div class="language-cpp highlighter-rouge"><pre class="highlight"><code><span class="cm">/* 
 * V is sorted 
 * V.size() = N
 * The function is initially called as searchNumOccurrence(V, k, 0, N-1)
 */</span>
<span class="kt">int</span> <span class="nf">searchNumOccurrence</span><span class="p">(</span><span class="n">vector</span><span class="o">&lt;</span><span class="kt">int</span><span class="o">&gt;</span> <span class="o">&amp;</span><span class="n">V</span><span class="p">,</span> <span class="kt">int</span> <span class="n">k</span><span class="p">,</span> <span class="kt">int</span> <span class="n">start</span><span class="p">,</span> <span class="kt">int</span> <span class="n">end</span><span class="p">)</span> <span class="p">{</span>
    <span class="k">if</span> <span class="p">(</span><span class="n">start</span> <span class="o">&gt;</span> <span class="n">end</span><span class="p">)</span> <span class="k">return</span> <span class="mi">0</span><span class="p">;</span>
    <span class="kt">int</span> <span class="n">mid</span> <span class="o">=</span> <span class="p">(</span><span class="n">start</span> <span class="o">+</span> <span class="n">end</span><span class="p">)</span> <span class="o">/</span> <span class="mi">2</span><span class="p">;</span>
    <span class="k">if</span> <span class="p">(</span><span class="n">V</span><span class="p">[</span><span class="n">mid</span><span class="p">]</span> <span class="o">&lt;</span> <span class="n">k</span><span class="p">)</span> <span class="k">return</span> <span class="n">searchNumOccurrence</span><span class="p">(</span><span class="n">V</span><span class="p">,</span> <span class="n">k</span><span class="p">,</span> <span class="n">mid</span> <span class="o">+</span> <span class="mi">1</span><span class="p">,</span> <span class="n">end</span><span class="p">);</span>
    <span class="k">if</span> <span class="p">(</span><span class="n">V</span><span class="p">[</span><span class="n">mid</span><span class="p">]</span> <span class="o">&gt;</span> <span class="n">k</span><span class="p">)</span> <span class="k">return</span> <span class="n">searchNumOccurrence</span><span class="p">(</span><span class="n">V</span><span class="p">,</span> <span class="n">k</span><span class="p">,</span> <span class="n">start</span><span class="p">,</span> <span class="n">mid</span> <span class="o">-</span> <span class="mi">1</span><span class="p">);</span>
    <span class="k">return</span> <span class="n">searchNumOccurrence</span><span class="p">(</span><span class="n">V</span><span class="p">,</span> <span class="n">k</span><span class="p">,</span> <span class="n">start</span><span class="p">,</span> <span class="n">mid</span> <span class="o">-</span> <span class="mi">1</span><span class="p">)</span> <span class="o">+</span> <span class="mi">1</span> <span class="o">+</span> <span class="n">searchNumOccurrence</span><span class="p">(</span><span class="n">V</span><span class="p">,</span> <span class="n">k</span><span class="p">,</span> <span class="n">mid</span> <span class="o">+</span> <span class="mi">1</span><span class="p">,</span> <span class="n">end</span><span class="p">);</span>
<span class="p">}</span>
</code></pre>
</div>
<blockquote>
<p><strong>NOTE</strong> : This question involves recursion which will be explained later in topic <em>Backtracking</em>. So, if you are not able to approach this question now, you can give it a try later.</p>
</blockquote>
</div>