<div class="markdown-content" id="problem-content">
<p>Given <strong>N x M</strong> character matrix <strong>A</strong> of <code class="highlighter-rouge">O's</code> and <code class="highlighter-rouge">X's</code>, where <code class="highlighter-rouge">O</code> = <code class="highlighter-rouge">white</code>, <code class="highlighter-rouge">X</code> = <code class="highlighter-rouge">black</code>.<br/><br/>
Return the number of black shapes. A black shape consists of one or more adjacent <code class="highlighter-rouge">X's</code> (diagonals not included)</p>
<p><br/><br/>
<strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>    The First and only argument is a N x M character matrix.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>    Return a single integer denoting number of black shapes.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>    1 &lt;= N,M &lt;= 1000
    A[i][j] = 'X' or 'O'
</code></pre>
</div>
<p><strong>Example:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [ OOOXOOO
          OOXXOXO
          OXOOOXO  ]
Output 1:
    3
Explanation:
    3 shapes are  :
    (i)    X
         X X
    (ii)
          X
    (iii)
          X
          X
</code></pre>
</div>
<p><strong>Note:</strong> we are looking for connected shapes here.</p>
<div class="highlighter-rouge"><pre class="highlight"><code>XXX
XXX
XXX
</code></pre>
</div>
<p>is just <strong>one</strong> single connected black shape.</p>

</div>