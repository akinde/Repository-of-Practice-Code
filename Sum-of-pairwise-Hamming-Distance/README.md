<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Hamming distance between two non-negative integers is defined as the number of positions at which the corresponding bits are different.</p>
<p>Given an array <strong>A</strong> of N non-negative integers, find the sum of hamming distances of all pairs of integers in the array. Return the answer modulo 1000000007.</p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= |A| &lt;= 200000</p>
<p>1 &lt;= A[i] &lt;= 10<sup>9</sup></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First and only argument is array A.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return one integer, the answer to the problem.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p><p></p><p></p><p></p><p></p>
<pre> A = [1]
</pre>
<p></p>
<p></p>
<p>Input 2:</p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p><p></p><p></p>
<pre> A = [2, 4, 6]
</pre>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p><p></p><p></p><p></p><p></p>
<pre> 0
</pre>
<p></p>
<p></p>
<p>Output 2:</p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p><p></p><p></p>
<pre> 8
</pre>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p><p></p><p></p><p></p><p></p>
<pre> No pairs are formed.
</pre>
<p></p>
<p></p>
<p>Explanation 2:</p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p><p></p><p></p>
<pre> We return, f(2, 2) + f(2, 4) + f(2, 6) + f(4, 2) + f(4, 4) + f(4, 6) + f(6, 2) + f(6, 4) + f(6, 6) = 8
</pre>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/></p>

</div>