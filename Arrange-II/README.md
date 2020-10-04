<div class="markdown-content" id="problem-content">
<p>You are given a sequence of black and white horses, and a set of K stables numbered 1 to K. You have to accommodate the horses into the stables in such a way that the following <strong>conditions are satisfied:</strong></p>
<blockquote>
<ul>
<li>You fill the horses into the stables preserving the relative order of horses. For instance, you cannot put horse 1 into stable 2 and horse 2 into stable 1. You have to preserve the ordering of the horses.</li>
<li>No stable should be empty and no horse should be left unaccommodated.</li>
<li>Take the product (<code class="highlighter-rouge">number of white horses * number of black horses</code>) for each stable and take the sum of all these products. This value should be the minimum among all possible accommodation arrangements</li>
</ul>
</blockquote>
<p><strong>Example:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>
Input: {WWWB} , K = 2
Output: 0

Explanation:
We have 3 choices {W, WWB}, {WW, WB}, {WWW, B}
for first choice we will get 1*0 + 2*1 = 2.
for second choice we will get 2*0 + 1*1 = 1.
for third choice we will get 3*0 + 0*1 = 0.

Of the 3 choices, the third choice is the best option. 

</code></pre>
</div>
<p><strong>If a solution is not possible, then return -1</strong></p>

</div>