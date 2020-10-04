<div class="markdown-content" id="problem-content">
<p>Given any source point, <strong>(C, D)</strong> and destination point, <strong>(E, F)</strong> on a chess board, we need to find whether Knight can move to the destination or not.</p>
<p><img alt="Knight's movements on a chess board" src="http://i.imgur.com/lmKL4AU.jpg"/></p>
<p>The above figure details the movements for a knight ( <strong>8</strong> possibilities ).</p>
<p>If yes, then what would be the <strong>minimum</strong> number of steps for the knight to move to the said point.<br/>
If knight can not move from the source point to the destination point, then return <strong>-1</strong>.</p>
<p><strong>Note:</strong> A knight cannot go out of the board.</p>
<p><br/></p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument of input contains an integer A.
The second argument of input contains an integer B.
    =&gt; The chessboard is of size A x B.
The third argument of input contains an integer C.
The fourth argument of input contains an integer D.
    =&gt; The Knight is initially at position (C, D).
The fifth argument of input contains an integer E.
The sixth argument of input contains an integer F.
    =&gt; The Knight wants to reach position (E, F).
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>If it is possible to reach the destination point, return the minimum number of moves.
Else return -1.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= A, B &lt;= 500
</code></pre>
</div>
<p><strong>Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = 8
    B = 8
    C = 1
    D = 1
    E = 8
    F = 8
    
Output 1:
    6

Explanation 1:
    The size of the chessboard is 8x8, the knight is initially at (1, 1) and the knight wants to reach position (8, 8).
    The minimum number of moves required for this is 6.
</code></pre>
</div>

</div>