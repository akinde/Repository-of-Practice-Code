<div class="markdown-content" id="problem-content">
<p>Given an array of  <span style=" background-color: rgba(0,0,0,0.04) ; color: #c7254e">positive</span> elements, you have to flip the sign of some of its elements such that the resultant sum of the elements of array should be <span style="background-color: rgba(0,0,0,0.04) ; color: #c7254e">minimum non-negative</span>(as close to zero as possible). Return the <span style="background-color: rgba(0,0,0,0.04) ; color: #c7254e">minimum</span> no. of elements whose sign needs to be flipped such that the resultant sum is minimum non-negative.</p>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code> 1 &lt;= n &lt;= 100
</code></pre>
</div>
<p>Sum of all the elements will not exceed 10,000.</p>
<p><strong>Example:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>A = [15, 10, 6]
</code></pre>
</div>
<p>ans = 1 (Here, we will flip the sign of 15 and the resultant sum will be 1 )</p>
<div class="highlighter-rouge"><pre class="highlight"><code>A = [14, 10, 4]
</code></pre>
</div>
<p>ans = 1 (Here, we will flip the sign of 14 and the resultant sum will be 0)</p>
<blockquote>
<p>Note that flipping the sign of 10 and 4 also gives the resultant sum 0 but flippings there are not minimum</p>
</blockquote>

</div>