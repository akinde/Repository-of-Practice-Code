<div class="markdown-content" id="problem-content">
<p>On a <strong>N * M</strong> chessboard, where rows are numbered from 1 to N and columns from 1 to M, there are queens at some cells. Return a <strong>N * M</strong>  array A, where A[i][j] is number of queens that can attack cell (i, j). While calculating answer for cell (i, j), assume there is no queen at that cell.</p>
<p><strong>Notes:</strong></p>
<ol>
<li>Queen is able to move any number of squares vertically, horizontally or diagonally on a chessboard. A queen cannot jump over another queen to attack a position.</li>
<li>You are given an array of N strings, each of size M. Each character is either a <code class="highlighter-rouge">1</code> or <code class="highlighter-rouge">0</code>  denoting if there is a queen at that position or not, respectively.</li>
<li>Expected time complexity is worst case O(N*M).</li>
</ol>
<p><strong>For example</strong>,</p>
<div class="highlighter-rouge"><pre class="highlight"><code>Let chessboard be,
[0 1 0]
[1 0 0]
[0 0 1]

where a 1 denotes a queen at that position.

Cell (1, 1) is attacked by queens at (2, 1), (1,2) and (3,3).
Cell (1, 2) is attacked by queen at (2, 1). Note that while calculating this, we assume that there is no queen at (1, 2).
Cell (1, 3) is attacked by queens at (3, 3) and (1, 2).
and so on...

Finally, we return matrix
[3, 1, 2]
[1, 3, 3]
[2, 3, 0]

</code></pre>
</div>

</div>