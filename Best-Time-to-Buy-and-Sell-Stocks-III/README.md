<div class="markdown-content" id="problem-content">
<p>Say you have an array, <strong>A</strong>, for which the <strong>ith</strong> element is the price of a given stock on day <strong>i</strong>.</p>
<p>Design an algorithm to find the <strong>maximum</strong> profit. You may complete at most <strong>2</strong> transactions.</p>
<p>Return the maximum possible profit.</p>
<p><strong>Note:</strong> You may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).<br/>
<br/></p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first and the only argument is an integer array, A.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer, representing the maximum possible profit.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= length(A) &lt;= 7e5
1 &lt;= A[i] &lt;= 1e7
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [1, 2, 1, 2]

Output 1:
    2

Explanation 1: 
    Day 0 : Buy 
    Day 1 : Sell
    Day 2 : Buy
    Day 3 : Sell

Input 2:
    A = [7, 2, 4, 8, 7]

Output 2:
    6

Explanation 2:
    Day 1 : Buy
    Day 3 : Sell
</code></pre>
</div>

</div>