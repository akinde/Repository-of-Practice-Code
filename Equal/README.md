<div class="markdown-content" id="problem-content">
<p>Given an array A of integers, find the index of values that satisfy <code class="highlighter-rouge">A + B = C + D</code>, where <code class="highlighter-rouge">A,B,C &amp; D</code> are integers values in the array</p>
<p><strong>Note:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1) Return the indices `A1 B1 C1 D1`, so that 
  A[A1] + A[B1] = A[C1] + A[D1]
  A1 &lt; B1, C1 &lt; D1
  A1 &lt; C1, B1 != D1, B1 != C1 

2) If there are more than one solutions, 
   then return the tuple of values which are lexicographical smallest. 

Assume we have two solutions
S1 : A1 B1 C1 D1 ( these are values of indices int the array )  
S2 : A2 B2 C2 D2

S1 is lexicographically smaller than S2 iff
  A1 &lt; A2 OR
  A1 = A2 AND B1 &lt; B2 OR
  A1 = A2 AND B1 = B2 AND C1 &lt; C2 OR 
  A1 = A2 AND B1 = B2 AND C1 = C2 AND D1 &lt; D2
</code></pre>
</div>
<p><strong>Example:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input: [3, 4, 7, 1, 2, 9, 8]
Output: [0, 2, 3, 5] (O index)
</code></pre>
</div>
<p>If no solution is possible, return an empty list.</p>

</div>