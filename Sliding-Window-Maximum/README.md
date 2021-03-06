<div class="markdown-content" id="problem-content">
<p>Given an array of integers <strong>A</strong>.  There is a sliding window of size <strong>B</strong> which <br/>
is moving from the very left of the array to the very right. <br/>
You can only see the w numbers in the window. Each time the sliding window moves <br/>
rightwards by one position. You have to find the maximum for each window. <br/>
The following example will give you more clarity.</p>
<p>The array <strong>A</strong> is <code class="highlighter-rouge">[1 3 -1 -3 5 3 6 7]</code>, and <strong>B</strong> is 3.</p>
<table>
<tbody>
<tr>
<td><strong>Window position</strong></td>
<td><strong>Max</strong><br/></td>
</tr>
<tr>
<td>———————————-</td>
<td>————————-<br/></td>
</tr>
<tr>
<td><code class="highlighter-rouge">[1  3  -1] -3  5  3  6  7</code></td>
<td><code class="highlighter-rouge">3</code><br/></td>
</tr>
<tr>
<td><code class="highlighter-rouge">1 [3  -1  -3] 5  3  6  7</code></td>
<td><code class="highlighter-rouge">3</code><br/></td>
</tr>
<tr>
<td><code class="highlighter-rouge">1  3 [-1  -3  5] 3  6  7</code></td>
<td><code class="highlighter-rouge">5</code><br/></td>
</tr>
<tr>
<td><code class="highlighter-rouge">1  3  -1 [-3  5  3] 6  7</code></td>
<td><code class="highlighter-rouge">5</code><br/></td>
</tr>
<tr>
<td><code class="highlighter-rouge">1  3  -1  -3 [5  3  6] 7</code></td>
<td><code class="highlighter-rouge">6</code><br/></td>
</tr>
<tr>
<td><code class="highlighter-rouge">1  3  -1  -3  5 [3  6  7]</code></td>
<td><code class="highlighter-rouge">7</code><br/></td>
</tr>
</tbody>
</table>
<p>Return an array <strong>C</strong>, where <strong>C[i]</strong> is the maximum value of from <strong>A[i]</strong> to <strong>A[i+B-1]</strong>.</p>
<p><strong>Note</strong>: If <strong>B</strong> &gt; length of the array, return 1 element with the max of the array.</p>
<p><br/><br/>
<strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument given is the integer array A.
The second argument given is the integer B.
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an array C, where C[i] is the maximum value of from A[i] to A[i+B-1]
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [1, 3, -1, -3, 5, 3, 6, 7]
    B = 3
Output 1:
    C = [3, 3, 5, 5, 6, 7]
</code></pre>
</div>

</div>