<div class="markdown-content" id="problem-content">
<p>Say you have an array, <strong>A</strong>, for which the <strong>ith</strong> element is the price of a given stock on day <strong>i</strong>.</p>
<p>Design an algorithm to find the <strong>maximum profit</strong>.</p>
<p>You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).</p>
<p>However, you may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).</p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first and the only argument is an array of integer, A.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer, representing the maximum possible profit.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= len(A) &lt;= 1e5
1 &lt;= A[i] &lt;= 1e7
</code></pre>
</div>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [1, 2, 3]

Output 1:
    2

Explanation 1:
    =&gt; Buy a stock on day 0.
    =&gt; Sell the stock on day 1. (Profit +1)
    =&gt; Buy a stock on day 1.
    =&gt; Sell the stock on day 2. (Profit +1)
    
    Overall profit = 2

Input 2:
    A = [5, 2, 10]

Output 2:
    8

Explanation 2:
    =&gt; Buy a stock on day 1.
    =&gt; Sell the stock on on day 2. (Profit +8)
    
    Overall profit = 8
</code></pre>
</div>

</div>