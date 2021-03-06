<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>You are given an array <strong>A</strong> having N integers.</p><p></p>
<p>You have to perform the following steps in a given order.</p>
<p>1) generate all subarrays of A.</p>
<p>2) take the maximum element from each subarray of A and insert it into a new array G.</p>
<p>3) replace every element of G with the product of their divisors mod 1e9 + 7.</p>
<p>4) sort G in descending order</p>
<p>You now need to perform Q queries</p>
<p>In each query, you are given an integer K, where you have to find the Kth element in G.</p>
<p><strong>NOTE</strong> : Your solution will run on multiple test cases so do clear global variables after using them.</p>
<p></p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= N &lt;= 1e5</p><p></p>
<p>1 &lt;= A[i] &lt;= 1e5</p>
<p>1 &lt;= Q &lt;= 1e5</p>
<p>1 &lt;= k &lt;= (N * (N + 1))/2 </p>
<p></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>The first argument given is an Array A, having N integers.</p><p></p>
<p>The second argument given is an Array B, where B[i] is the ith query.</p>
<p></p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return an Array X, where X[i] will have the answer for the ith query.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre> A = [1, 2, 4]
B = [1, 2, 3, 4, 5, 6]
</pre>
<p></p>
<p></p>
<p>Input 2:</p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p><p></p><p></p>
<pre> A = [1, 3]
B = [1]
</pre>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre> [8, 8, 8, 2, 2, 1]
</pre>
<p></p>
<p></p>
<p>Output 2:</p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p><p></p><p></p>
<pre> [3]
</pre>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p><p></p><p></p><p></p><p></p><p></p></div></p>
<h2><pre> subarrays of A    maximum element</pre></h2>
<ol>
<li>[1]                          1</li>
<li>[1, 2]                       2</li>
<li>[1, 2, 4]                    4</li>
<li>[2]                          2</li>
<li>[2, 4]                       4</li>
<li>[4]                          4</li>
</ol>
<p>original
G = [1, 2, 4, 2, 4, 4]</p>
<p>after changing every element of G with product of their divisors
G = [1, 2, 8, 2, 8, 8]</p>
<p>after sorting G in descending order
G = [8, 8, 8, 2, 2, 1]</p>
<p>
<p></p>
<p></p>
<p>Explanation 2:</p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p><p></p><p></p>
<pre> Just perform given query.
</pre>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></p></div>