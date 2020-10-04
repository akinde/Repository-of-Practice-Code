<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>You are given a 1D integer array <strong>B</strong> containing <strong>A</strong> integers.</p><p></p><p></p>
<p>Count the number of ways to split all the elements of the array into 3 contiguous parts so that the sum of elements in each part is the same.</p>
<p><strong>Such that :</strong> sum(B[1],..B[i]) = sum(B[i+1],...B[j]) = sum(B[j+1],...B[n]) </p>
<p></p>
<p></p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= A &lt;= 10<sup>5</sup></p><p></p><p></p>
<p>-10<sup>9</sup> &lt;= B[i] &lt;= 10<sup>9</sup></p>
<p></p>
<p></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First argument is an integer <strong>A</strong>.</p><p></p><p></p>
<p>Second argument is an 1D integer array <strong>B</strong> of size <strong>A</strong>.</p>
<p></p>
<p></p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return a single integer denoting the number of ways to split the array <strong>B</strong> into three parts with the same sum.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p><p></p>
<pre> A = 5
 B = [1, 2, 3, 0, 3]
</pre>
<p>Input 2:</p>
<pre> A = 4
 B = [0, 1, -1, 0]
</pre>
<p></p>
<p></p></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p><p></p>
<pre> 2
</pre>
<p>Output 2:</p>
<pre> 1
</pre>
<p></p>
<p></p></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p><p></p>
<pre> There are no 2 ways to make partitions -
 1. (1,2)+(3)+(0,3).
 2. (1,2)+(3,0)+(3).
</pre>
<p>Explanation 2:</p>
<pre> There is only 1 way to make partition -
 1. (0)+(-1,1)+(0).
</pre>
<p></p>
<p></p></div><br/><br/></p>

</div>