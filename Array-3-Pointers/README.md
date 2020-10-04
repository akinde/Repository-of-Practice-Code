<div class="markdown-content" id="problem-content">
<p>You are given 3 arrays A, B and C. All 3 of the arrays are sorted.</p>
<p>Find <code class="highlighter-rouge">i, j, k</code> such that :<br/>
<code class="highlighter-rouge">max(abs(A[i] - B[j]), abs(B[j] - C[k]), abs(C[k] - A[i]))</code> is minimized.<br/>
Return the minimum <code class="highlighter-rouge">max(abs(A[i] - B[j]), abs(B[j] - C[k]), abs(C[k] - A[i]))</code></p>
<p>**abs(x) is absolute value of x and is implemented in the following manner : **</p>
<div class="language-cpp highlighter-rouge"><pre class="highlight"><code>      <span class="k">if</span> <span class="p">(</span><span class="n">x</span> <span class="o">&lt;</span> <span class="mi">0</span><span class="p">)</span> <span class="k">return</span> <span class="o">-</span><span class="n">x</span><span class="p">;</span>
      <span class="k">else</span> <span class="k">return</span> <span class="n">x</span><span class="p">;</span>
</code></pre>
</div>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input : 
        A : [1, 4, 10]
        B : [2, 15, 20]
        C : [10, 12]

Output : 5 
         With 10 from A, 15 from B and 10 from C. 
</code></pre>
</div>

</div>