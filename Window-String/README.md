<div class="markdown-content" id="problem-content">
<p>Given a string <code class="highlighter-rouge">S</code> and a string <code class="highlighter-rouge">T</code>, find the minimum window in <code class="highlighter-rouge">S</code> which will contain all the characters in <code class="highlighter-rouge">T</code> in linear time complexity.<br/>
Note that when the count of a character C in <code class="highlighter-rouge">T</code> is N, then the count of C in minimum window in <code class="highlighter-rouge">S</code> should be at least N.</p>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>S = "ADOBECODEBANC"
T = "ABC"
</code></pre>
</div>
<p>Minimum window is <code class="highlighter-rouge">"BANC"</code></p>
<blockquote>
<p><strong>Note:</strong></p>
<ul>
<li>If there is no such window in S that covers all characters in T, return the empty string <code class="highlighter-rouge">''</code>.</li>
<li>If there are multiple such windows, return the first occurring minimum window ( with minimum start index ).</li>
</ul>
</blockquote>

</div>