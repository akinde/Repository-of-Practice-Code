<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>There are <strong>A</strong> coins (Assume A is even) in a line.</p>
<p>Two players take turns to take a coin from one of the ends of the line until there are no more coins left.</p>
<p>The player with the larger amount of money wins, Assume that you go first.</p>
<p>Return the <strong>maximum amount</strong> of money you can win.</p>
<p><strong>NOTE:</strong></p>
<li> You can assume that opponent is clever and plays optimally.</li></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= length(A) &lt;= 500</p>
<p>1 &lt;= A[i] &lt;= 10<sup>5</sup></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>The first and the only argument of input contains an integer array <strong>A</strong>.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return an integer representing the maximum amount of money you can win.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p>
<pre>
 A = [1, 2, 3, 4]
</pre>
<p>Input 2:</p>
<pre>
 A = [5, 4, 8, 10]
</pre></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p>
<pre>
 6
</pre>
<p>Output 2:</p>
<pre>
 15
</pre></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p>
<pre>
 You      : Pick 4
 Opponent : Pick 3
 You      : Pick 2
 Opponent : Pick 1</pre></div></p>
<p>Total money with you : 4 + 2 = 6

<p>Explanation 2:</p>
<pre>
 You      : Pick 10
 Opponent : Pick 8
 You      : Pick 5
 Opponent : Pick 4</pre></p>
<p>Total money with you : 10 + 5 = 15
</p></div>