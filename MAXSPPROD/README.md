<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>You are given an array <strong>A</strong> containing <strong>N</strong> integers. The special product of each <strong>i<sup>th</sup></strong> integer in this array is defined as the product of the following:</p><p></p>
<ol><li><strong>LeftSpecialValue:</strong> For an index <strong>i</strong>, it is defined as the index <strong>j</strong> such that <strong>A[j]&gt;A[i]</strong> and <strong>(i&gt;j)</strong>. If multiple <strong>A[j]'s</strong> are present in multiple positions, the LeftSpecialValue is the maximum value of <strong>j</strong>.</li>
<li><strong>RightSpecialValue:</strong> For an index <strong>i</strong>, it is defined as the index <strong>j</strong> such that <strong>A[j]&gt;A[i]</strong> and <strong>(j&gt;i)</strong>. If multiple <strong>A[j]'s</strong> are present in multiple positions, the RightSpecialValue is the minimum value of <strong>j</strong>.</li></ol>
<p>Write a program to find the maximum special product of any integer in the array.</p>
<p><strong>NOTE: </strong> As the answer can be large, output your answer modulo 10<sup>9</sup> + 7.</p>
<p></p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= N &lt;= 10<sup>5</sup><br/> 
1 &lt;= A[i] &lt;= 10<sup>9</sup></p></div><br><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First and only argument is an integer array A.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return an integer denoting the maximum special product of any integer.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p>
<pre> A = [1, 4, 3, 4]</pre>
<p>Input 2:</p>
<pre> A = [10, 7, 100]</pre>
<p></p></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p>
<pre> 3</pre>
<p>Output 2:</p>
<pre> 0</pre>
<p></p></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p>
<pre> For A[2] = 3, LeftSpecialValue is 1 and RightSpecialValue is 3.
 So, the ans is 1*3 = 3.
 </pre>
<p>Explanation 2:</p>
<pre> There is not any integer having maximum special product &gt; 0. So, the ans is 0.</pre>
<p></p></div><br/><br/></br></p>

</div>