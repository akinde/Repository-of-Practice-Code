<div class="markdown-content" id="problem-content">
<p>Given a 2D board and a word, find if the word exists in the grid.</p>
<p>The word can be constructed from letters of sequentially adjacent cell, where <code class="highlighter-rouge">"adjacent"</code> cells are those horizontally or vertically neighboring. The cell itself does not count as an adjacent cell. <br/>
The same letter cell may be used more than once.</p>
<p><strong>Example :</strong></p>
<p>Given board =</p>
<div class="highlighter-rouge"><pre class="highlight"><code>[
  ["ABCE"],
  ["SFCS"],
  ["ADEE"]
]
</code></pre>
</div>
<div class="highlighter-rouge"><pre class="highlight"><code>word = "ABCCED", -&gt; returns 1,
word = "SEE", -&gt; returns 1,
word = "ABCB", -&gt; returns 1,
word = "ABFSAB" -&gt; returns 1
word = "ABCD" -&gt; returns 0
</code></pre>
</div>
<p>Note that 1 corresponds to true, and 0 corresponds to false.</p>

</div>