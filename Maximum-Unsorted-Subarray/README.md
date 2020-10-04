<div class="markdown-content" id="problem-content">
<p>You are given an array (zero indexed) of <strong>N</strong> non-negative integers, <strong>A<sub>0</sub></strong>, <strong>A<sub>1</sub></strong> ,…, <strong>A<sub>N-1</sub></strong>.<br/>
Find the minimum sub array <strong>A<sub>l</sub></strong>, <strong>A<sub>l+1</sub></strong> ,…, <strong>A<sub>r</sub></strong> so if we sort(in ascending order) that sub array, then the whole array should get sorted.<br/>
If <strong>A</strong> is already sorted, output <strong>-1</strong>.</p>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:

A = [1, 3, 2, 4, 5]

Return: [1, 2]

Input 2:

A = [1, 2, 3, 4, 5]

Return: [-1]
</code></pre>
</div>
<p>In the above example(Input 1), if we sort the subarray <strong>A<sub>1</sub></strong>, <strong>A<sub>2</sub></strong>, then whole array <strong>A</strong> should get sorted.</p>

</div>