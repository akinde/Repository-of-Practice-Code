<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given a 2D integer array <strong>A</strong> of size <code>M x N</code>, you need to find a path from top left to bottom right which minimizes the sum of all numbers along its path.</p>
<p><strong>NOTE:</strong> You can only move either down or right at any point in time. </p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First and only argument is an 2D integer array <strong>A</strong> of size <code>M x N</code>.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return a single integer denoting the minimum sum of a path from cell (1, 1) to cell (M, N).</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p>
<pre>
 A = [  [1, 3, 2]
        [4, 3, 1]
        [5, 6, 1]
     ]
</pre></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p>
<pre>
 9
</pre></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p>
<pre>
 The path is 1 -&gt; 3 -&gt; 2 -&gt; 1 -&gt; 1
 So ( 1 + 3 + 2 + 1 + 1) = 8
</pre></div><br/><br/></p>

</div>