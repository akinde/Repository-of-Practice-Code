<div class="markdown-content" id="problem-content">
<p>You are given two positive integers A and B. For all permutations of [1, 2, …, A], we create a BST. Count how many of these have height B.</p>
<p>Notes:</p>
<ol>
<li>Values of a permutation are sequentially inserted into the BST by general rules i.e in increasing order of indices.</li>
<li>Height of BST is maximum number of edges between root and a leaf.</li>
<li>Return answer modulo 10<sup>9</sup> + 7.</li>
<li>Expected time complexity is worst case O(N<sup>4</sup>).</li>
<li>1 ≤ N ≤ 50</li>
</ol>
<p>For example,</p>
<div class="highlighter-rouge"><pre class="highlight"><code>A = 3, B = 1

Two permutations [2, 1, 3] and [2, 3, 1] generate a BST of height 1.
In both cases the BST formed is

    2
   / \
  1   3  


Another example,
A = 3, B = 2
Return 4.

</code></pre>
</div>
<p>Next question, can you do the problem in O(N<sup>3</sup>)?</p>

</div>