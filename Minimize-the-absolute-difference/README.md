<div class="markdown-content" id="problem-content">
<p>Given three sorted arrays <code class="highlighter-rouge">A</code>, <code class="highlighter-rouge">B</code>  and <code class="highlighter-rouge">C</code>of not necessarily same sizes.</p>
<p>Calculate the <strong>minimum absolute difference</strong> between the maximum and minimum number from the triplet a, b, c such that a, b, c belongs arrays <code class="highlighter-rouge">A</code>, <code class="highlighter-rouge">B</code>, <code class="highlighter-rouge">C</code> respectively.<br/>
i.e. minimize <strong>| max(a,b,c) - min(a,b,c) |</strong>.</p>
<p><b>Example :</b></p>
<p>Input:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>A : [ 1, 4, 5, 8, 10 ]
B : [ 6, 9, 15 ]
C : [ 2, 3, 6, 6 ]
</code></pre>
</div>
<p>Output:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>1
</code></pre>
</div>
<p><strong>Explanation</strong>: We get the minimum difference for a=5, b=6, c=6 as <code class="highlighter-rouge">| max(a,b,c) - min(a,b,c) | = |6-5| = 1</code>.</p>

</div>