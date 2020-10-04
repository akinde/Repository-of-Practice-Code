<div class="markdown-content" id="problem-content">
<p>The set <code class="highlighter-rouge">[1,2,3,…,n]</code> contains a total of <code class="highlighter-rouge">n!</code> unique permutations.</p>
<p>By listing and labeling all of the permutations in order,<br/>
We get the following sequence (ie, for <code class="highlighter-rouge">n = 3</code> ) :</p>
<div class="highlighter-rouge"><pre class="highlight"><code>1. "123"
2. "132"
3. "213"
4. "231"
5. "312"
6. "321"
</code></pre>
</div>
<p>Given n and k, return the kth permutation sequence.</p>
<p>For example, given <code class="highlighter-rouge">n = 3, k = 4, ans = "231"</code></p>
<blockquote>
<p><strong>Good questions to ask the interviewer :</strong></p>
<ul>
<li>What if n is greater than 10. How should multiple digit numbers be represented in string?
      <blockquote>
<p>In this case, just concatenate the number to the answer.<br/>
 so if <code class="highlighter-rouge">n = 11, k = 1, ans = "1234567891011"</code></p>
</blockquote>
</li>
<li>Whats the maximum value of n and k?
      <blockquote>
<p>In this case, k will be a positive integer thats less than INT_MAX.<br/>
n is reasonable enough to make sure the answer does not bloat up a lot.</p>
</blockquote>
</li>
</ul>
</blockquote>

</div>