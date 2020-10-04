<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given a string <strong>A</strong>, find length of the longest repeating sub-sequence such that the two subsequence don’t have same string character at same position,</p>
<p>i.e., any i’th character in the two subsequences shouldn’t have the same index in the original string.</p>
<p><strong>NOTE:</strong> Sub-sequence length should be greater than or equal to 2.</p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p> 1 &lt;= |A| &lt;= 100</p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>The first and the only argument of input contains a string <strong>A</strong>.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return an integer, 0 or 1:</p>
<pre>
    =&gt; 0 : False
    =&gt; 1 : True
</pre></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p>
<pre>
 A = "abab"
</pre>
<p>Input 2:</p>
<pre>
 A = "abba"
</pre></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p>
<pre>
 1
</pre>
<p>Output 2:</p>
<pre>
 0
</pre></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p>
<pre>
 "ab" is repeated.
</pre>
<p>Explanation 2:</p>
<pre>
 There is no repeating subsequence.
</pre></div><br/><br/></p>

</div>