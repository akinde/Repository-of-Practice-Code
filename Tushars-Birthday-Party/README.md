<div class="markdown-content" id="problem-content">
<p>As it is Tushar’s Birthday on March 1st, he decided to throw a party to all his friends at TGI Fridays in Pune.<br/>
 Given are the eating capacity of each friend, filling capacity of each dish and cost of each dish. A friend is satisfied if the sum of the filling capacity of dishes he ate is equal to his capacity. Find the minimum cost such that all of Tushar’s friends are satisfied (reached their eating capacity).</p>
<p><strong>NOTE:</strong></p>
<ol>
<li>Each dish is supposed to be eaten by only one person. Sharing is not allowed.</li>
<li>Each friend can take any dish  unlimited number of times.</li>
<li>There always exists a dish with filling capacity 1 so that a solution always exists.</li>
</ol>
<p><strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Friends : List of integers denoting eating capacity of friends separated by space.
Capacity: List of integers denoting filling capacity of each type of dish.
Cost :    List of integers denoting cost of each type of dish.
</code></pre>
</div>
<p><strong>Constraints:</strong><br/>
 1 &lt;= Capacity of friend &lt;= 1000<br/>
1 &lt;= No. of friends &lt;= 1000<br/>
1 &lt;= No. of dishes &lt;= 1000</p>
<p><strong>Example:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input:
    2 4 6
    2 1 3
    2 5 3

Output:
    14

Explanation: 
    First friend will take 1st and 2nd dish, second friend will take 2nd dish twice.  Thus, total cost = (5+3)+(3*2)= 14
</code></pre>
</div>

</div>