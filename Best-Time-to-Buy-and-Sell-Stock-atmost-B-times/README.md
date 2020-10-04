<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given an array of integers <strong>A</strong> of size <strong>N</strong> in which i<sup>th</sup> element is the price of the stock on day <strong>i</strong>.</p><p></p><p></p>
<p>You can complete atmost <strong>B</strong> transactions.</p>
<p>Find the <strong>maximum profit</strong> you can achieve.</p>
<p><strong>NOTE:</strong> You may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).</p>
<p></p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= N &lt;= 500</p><p></p>
<p>0 &lt;= A[i] &lt;= 10<sup>6</sup></p>
<p>0 &lt;= B &lt;= 10<sup>9</sup></p>
<p></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>The First argument given is the integer array <strong>A</strong>.</p><p></p>
<p>The Second argument is integer <strong>B</strong>.</p>
<p></p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return the <strong>maximum profit</strong> you can achieve by doing atmost <strong>B</strong> transactions.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p>
<pre> A = [2, 4, 1]
 B = 2
</pre>
<p>Input 2:</p>
<pre> A = [3, 2, 6, 5, 0, 3]
 B = 2
</pre>
<p></p></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p>
<pre> 2
</pre>
<p>Output 2:</p>
<pre> 7
</pre>
<p></p></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p>
<pre> Buy on day 1 (price = 2) and sell on day 2 (price = 4), 
 Profit = 4 - 2 = 2
</pre>
<p>Explanation 2:</p>
<pre> Buy on day 2 (price = 2) and sell on day 3 (price = 6), profit = 6 - 2 = 4.
 Then buy on day 5 (price = 0) and sell on day 6 (price = 3), profit = 3 - 0 = 3.
</pre>
<p></p></div><br/><br/></p>

</div>