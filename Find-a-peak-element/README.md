<div class="markdown-content" id="problem-content">
<p>Given an array of integers <strong>A</strong>, find and return the <strong>peak element</strong> in it.<br/>
An array element is peak if it is NOT smaller than its neighbors. <br/>
For corner elements, we need to consider only one neighbor. <br/>
For example, for input array {5, 10, 20, 15}, 20 is the only peak element.</p>
<p>Following corner cases give better idea about the problem.</p>
<div class="highlighter-rouge"><pre class="highlight"><code>1) If input array is sorted in strictly increasing order, the last element is always a peak element. 
For example, 5 is peak element in {1, 2, 3, 4, 5}.
2) If input array is sorted in strictly decreasing order, the first element is always a peak element. 
10 is the peak element in {10, 9, 8, 7, 6}.
</code></pre>
</div>
<p><strong>Note:</strong> It is guranteed that the answer is unique.</p>
<p><br/><br/>
<strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The only argument given is the integer array A.
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return the peak element.
</code></pre>
</div>
<p><strong>Constraints</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= length of the array &lt;= 100000
1 &lt;= A[i] &lt;= 10^9 
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [1, 2, 3, 4, 5]
Output 1:
    5

Input 2:
    A = [5, 17, 100, 11]
Output 2:
    100
</code></pre>
</div>

</div>