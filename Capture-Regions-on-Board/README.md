<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given a 2D character matrix <strong>A</strong> of size <code>N x M</code>, containing <code>'X'</code> and <code>'O'</code>, capture all regions surrounded by <code>'X'</code>.</p><p></p><p></p>
<p>A region is captured by flipping all <code>'O'</code>s into <code>'X'</code>s in that surrounded region.</p>
<p></p>
<p></p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= N, M &lt;= 10<sup>3</sup></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First and only argument 2D character matrix <strong>A</strong> of size <code>N X M</code>.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Make changes to the the input only as matrix is passed by reference.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p><p></p>
<pre> A = [  [X, X, X, X],
        [X, O, O, X],
        [X, X, O, X],
        [X, O, X, X]
     ]
</pre>
<p></p>
<p></p></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p><p></p>
<pre> A = [  [X, X, X, X],
        [X, X, X, X],
        [X, X, X, X],
        [X, O, X, X]
     ]
</pre>
<p></p>
<p></p></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p><p></p>
<pre> 'O' in (4,2) is not surrounded by X from below.
</pre>
<p></p>
<p></p></div><br/><br/></p>

</div>