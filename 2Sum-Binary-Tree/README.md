<div class="markdown-content" id="problem-content">
<p>Given a binary search tree T, where each node contains a positive integer, and an integer K, you have to find whether or not there exist two different nodes A and B such that A.value + B.value = K.</p>
<p>Return 1 to denote that two such nodes exist. Return 0, otherwise.</p>
<p><strong>Notes</strong></p>
<ul>
<li>Your solution should run in linear time and not take memory more than O(height of T).</li>
<li>Assume all values in BST are distinct.</li>
</ul>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1: 

T :       10
         / \
        9   20

K = 19

Return: 1

Input 2: 

T:        10
         / \
        9   20

K = 40

Return: 0
</code></pre>
</div>

</div>