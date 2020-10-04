<div class="markdown-content" id="problem-content">
<p>There are <strong>N</strong> children standing in a line. Each child is assigned a rating value.</p>
<p>You are giving candies to these children subjected to the following requirements:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>1. Each child must have at least one candy.
2. Children with a higher rating get more candies than their neighbors.
</code></pre>
</div>
<p>What is the minimum candies you must give?</p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first and the only argument contains N integers in an array A.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer, representing the minimum candies to be given.
</code></pre>
</div>
<p><strong>Example:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [1, 2]

Output 1:
    3

Explanation 1:
    The candidate with 1 rating gets 1 candy and candidate with rating cannot get 1 candy as 1 is its neighbor. 
    So rating 2 candidate gets 2 candies. In total, 2 + 1 = 3 candies need to be given out.

Input 2:
    A = [1, 5, 2, 1]

Output 2:
    7

Explanation 2:
    Candies given = [1, 3, 2, 1]
</code></pre>
</div>

</div>