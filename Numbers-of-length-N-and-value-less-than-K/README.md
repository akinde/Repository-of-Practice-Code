<div class="markdown-content" id="problem-content">
<p>Given a set of digits (A) in sorted order, find how many numbers of  length B are possible whose value is less than number C.</p>
<blockquote>
<p><strong>NOTE:</strong>  All numbers can only have digits from the given set.</p>
</blockquote>
<hr/>
<p><strong>Examples:</strong></p>
<div class="language-ruby highlighter-rouge"><pre class="highlight"><code>	<span class="no">Input</span><span class="p">:</span>
	  <span class="mi">0</span> <span class="mi">1</span> <span class="mi">5</span>  
	  <span class="mi">1</span>  
	  <span class="mi">2</span>  
	<span class="no">Output</span><span class="p">:</span>  
	  <span class="mi">2</span> <span class="p">(</span><span class="mi">0</span> <span class="n">and</span> <span class="mi">1</span> <span class="n">are</span> <span class="n">possible</span><span class="p">)</span>  

	<span class="no">Input</span><span class="p">:</span>
	  <span class="mi">0</span> <span class="mi">1</span> <span class="mi">2</span> <span class="mi">5</span>  
	  <span class="mi">2</span>  
	  <span class="mi">21</span>  
	<span class="no">Output</span><span class="p">:</span>
	  <span class="mi">5</span> <span class="p">(</span><span class="mi">10</span><span class="p">,</span> <span class="mi">11</span><span class="p">,</span> <span class="mi">12</span><span class="p">,</span> <span class="mi">15</span><span class="p">,</span> <span class="mi">20</span> <span class="n">are</span> <span class="n">possible</span><span class="p">)</span>
</code></pre>
</div>
<p><strong>Constraints</strong>:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>    1 &lt;= B &lt;= 9, 0 &lt;= C &lt;= 1e9 &amp; 0 &lt;= A[i] &lt;= 9
</code></pre>
</div>

</div>