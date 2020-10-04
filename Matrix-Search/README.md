<div class="markdown-content" id="problem-content">
<p>Given a matrix of integers <strong>A</strong> of size <strong>N x M</strong> and an integer <strong>B</strong>.</p>
<p>Write an efficient algorithm that searches for integar <strong>B</strong> in matrix <strong>A</strong>.</p>
<p>This matrix <strong>A</strong> has the following properties:</p>
<blockquote>
<ol>
<li>Integers in each row are sorted from left to right.</li>
<li>The <strong>first integer</strong> of each row is greater than or equal to the <strong>last integer</strong> of the previous row.</li>
</ol>
</blockquote>
<p>Return <strong>1</strong> if <strong>B</strong> is present in <strong>A</strong>, else return <strong>0</strong>.</p>
<p><strong>Note:</strong> Rows are numbered from top to bottom and columns are numbered from left to right.</p>
<p><br/><br/>
<strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument given is the integer matrix A.
The second argument given is the integer B.
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return 1 if B is present in A, else return 0.
</code></pre>
</div>
<p><strong>Constraints</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= N, M &lt;= 1000
1 &lt;= A[i][j], B &lt;= 10^6
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = 
    [ [1,   3,  5,  7],
      [10, 11, 16, 20],
      [23, 30, 34, 50]  ]
    B = 3
Output 1:
    1

Input 2:
    A = [   [5, 17, 100, 111]
            [119, 120,  127,   131]    ]
    B = 3
Output 2:
    0
</code></pre>
</div>

</div>