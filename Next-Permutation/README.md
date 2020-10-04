<div class="markdown-content" id="problem-content">
<p>Implement the <strong>next permutation</strong>, which rearranges numbers into the numerically next greater permutation of numbers for a given array <strong>A</strong> of size <strong>N</strong>.</p>
<p>If such arrangement is not possible, it must be rearranged as the lowest possible order <em>i.e., sorted in an ascending order</em>.</p>
<p><strong>Note:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1. The replacement must be in-place, do **not** allocate extra memory.
2. DO NOT USE LIBRARY FUNCTION FOR NEXT PERMUTATION. Use of Library functions will disqualify your submission retroactively and will give you penalty points.
</code></pre>
</div>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first and the only argument of input has an array of integers, A.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an array of integers, representing the next permutation of the given array.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= N &lt;= 5e5
1 &lt;= A[i] &lt;= 1e9
</code></pre>
</div>
<p><strong>Examples:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = [1, 2, 3]

Output 1:
    [1, 3, 2]

Input 2:
    A = [3, 2, 1]

Output 2:
    [1, 2, 3]

Input 3:
    A = [1, 1, 5]

Output 3:
    [1, 5, 1]

Input 4:
    A = [20, 50, 113]

Output 4:
    [20, 113, 50]
</code></pre>
</div>

</div>