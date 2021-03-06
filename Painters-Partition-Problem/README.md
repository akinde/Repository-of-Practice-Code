<div class="markdown-content" id="problem-content">
<p>Given 2 integers <strong>A</strong> and <strong>B</strong> and an array of integars <strong>C</strong> of size <strong>N</strong>.</p>
<p>Element <strong>C[i]</strong> represents length of <strong>ith</strong> board.</p>
<p>You have to paint all <strong>N</strong> boards <strong>[C0, C1, C2, C3 … CN-1]</strong>. There are <strong>A</strong> painters available and each of them takes <strong>B</strong> units of time to paint <code class="highlighter-rouge">1 unit</code> of board.</p>
<p>Calculate and return minimum time required to paint all boards under the constraints that <strong>any painter will only paint contiguous sections of board.</strong></p>
<blockquote>
<ul>
<li>2 painters cannot share a board to paint. That is to say, a board<br/>
cannot be painted partially by one painter, and partially by another.</li>
<li>A painter will only paint contiguous boards. Which means a<br/>
configuration where painter 1 paints board 1 and 3 but not 2 is<br/>
invalid.</li>
</ul>
</blockquote>
<p>Return the ans % 10000003</p>
<p><br/><br/>
<strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument given is the integer A.
The second argument given is the integer B.
The third argument given is the integer array C.
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return minimum time required to paint all boards under the constraints that any painter will only paint contiguous sections of board % 10000003.
</code></pre>
</div>
<p><strong>Constraints</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;=A &lt;= 1000
1 &lt;= B &lt;= 10^6
1 &lt;= C.size() &lt;= 10^5
1 &lt;= C[i] &lt;= 10^6
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = 2
    B = 5
    C = [1, 10]
Output 1:
    50
Explanation 1:
    Possibility 1:- same painter paints both blocks, time taken = 55units
    Possibility 2:- Painter 1 paints block 1, painter 2 paints block 2, time take = max(5, 50) = 50
    There are no other distinct ways to paint boards.
    ans = 50%10000003

Input 2:
    A = 10
    B = 1
    C = [1, 8, 11, 3]
Output 2:
    11
</code></pre>
</div>

</div>