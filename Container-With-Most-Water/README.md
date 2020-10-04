<div class="markdown-content" id="problem-content">
<p>Given <strong>n non-negative integers <code class="highlighter-rouge">a1, a2, ..., an</code>,</strong><br/>
where each represents a point at coordinate <code class="highlighter-rouge">(i, ai)</code>.<br/>
<code class="highlighter-rouge">'n'</code> vertical lines are drawn such that the two endpoints of line <code class="highlighter-rouge">i</code> is at <code class="highlighter-rouge">(i, ai)</code> and <code class="highlighter-rouge">(i, 0)</code>.</p>
<p>Find two lines, which together with x-axis forms a container, such that the container contains the most water.</p>
<p>Your program should return an integer which corresponds to the maximum area of water that can be contained ( Yes, we know maximum area instead of maximum volume sounds weird. But this is 2D plane we are working with for simplicity ).</p>
<blockquote>
<p><strong>Note:</strong> You may not slant the container.</p>
</blockquote>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input : [1, 5, 4, 3]
Output : 6

Explanation : 5 and 3 are distance 2 apart. So size of the base = 2. Height of container = min(5, 3) = 3. 
So total area = 3 * 2 = 6
</code></pre>
</div>

</div>