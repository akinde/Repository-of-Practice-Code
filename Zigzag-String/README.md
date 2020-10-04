<div class="markdown-content" id="problem-content">
<p>The string <code class="highlighter-rouge">"PAYPALISHIRING"</code> is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)</p>
<div class="highlighter-rouge"><pre class="highlight"><code>P.......A........H.......N
..A..P....L....S....I...I....G
....Y.........I........R
</code></pre>
</div>
<p>And then read line by line: <code class="highlighter-rouge">PAHNAPLSIIGYIR</code><br/>
Write the code that will take a string and make this conversion given a number of rows:</p>
<div class="language-cpp highlighter-rouge"><pre class="highlight"><code><span class="n">string</span> <span class="n">convert</span><span class="p">(</span><span class="n">string</span> <span class="n">text</span><span class="p">,</span> <span class="kt">int</span> <span class="n">nRows</span><span class="p">);</span>
<span class="n">convert</span><span class="p">(</span><span class="s">"PAYPALISHIRING"</span><span class="p">,</span> <span class="mi">3</span><span class="p">)</span> <span class="n">should</span> <span class="k">return</span> <span class="s">"PAHNAPLSIIGYIR"</span>
</code></pre>
</div>
<p>**Example 2 : **<br/>
ABCD, 2 can be written as</p>
<div class="highlighter-rouge"><pre class="highlight"><code>A....C
...B....D
</code></pre>
</div>
<p>and hence the answer would be <code class="highlighter-rouge">ACBD</code>.</p>

</div>