<div class="markdown-content" id="problem-content">
<p><strong>N</strong> light bulbs are connected by a wire.</p>
<p>Each bulb has a switch associated with it, however due to faulty wiring, a switch also changes the state of all the bulbs to the right of current bulb.</p>
<p>Given an initial state of all bulbs, find the minimum number of switches you have to press to turn on all the bulbs.</p>
<p>You can press the same switch multiple times.</p>
<p><strong>Note :</strong> 0 represents the bulb is off and 1 represents the bulb is on.</p>
<p><br/></p>
<p><strong>Input Format:</strong></p>
<p>The first and the only argument contains an integer array A, of size N.</p>
<p><strong>Output Format:</strong></p>
<p>Return an integer representing the minimum number of switches required.</p>
<p><strong>Constraints:</strong></p>
<p>1 &lt;= N &lt;= 5e5<br/>
0 &lt;= A[i] &lt;= 1</p>
<p><strong>Example:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [1]

Output 1:
    0

Explanation 1:
    There is no need to turn any switches as all the bulbs are already on.

Input 2: 
    A = [0 1 0 1]

Output 2:
    4

Explanation 2:
	press switch 0 : [1 0 1 0]
	press switch 1 : [1 1 0 1]
	press switch 2 : [1 1 1 0]
	press switch 3 : [1 1 1 1]
</code></pre>
</div>

</div>