<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>A message containing letters from A-Z is being encoded to numbers using the following mapping:</p>
<pre>
 'A' -&gt; 1
 'B' -&gt; 2
 ...
 'Z' -&gt; 26
</pre>
<p>Given an encoded message <strong>A</strong> containing digits, determine the total number of ways to decode it modulo <strong>10<sup>9</sup> + 7</strong>.</p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= |A| &lt;= 10<sup>5</sup></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>The first and the only argument is a string <strong>A</strong>.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return a single integer denoting the total number of ways to decode it modulo <strong>10<sup>9</sup> + 7</strong>.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p>
<pre>
 A = "8"
</pre>
<p>Input 2:</p>
<pre>
 A = "12"
</pre></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p>
<pre>
 1
</pre>
<p>Output 2:</p>
<pre>
 2
</pre></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p>
<pre>
 Given encoded message "8", it could be decoded as only "H" (8).
 The number of ways decoding "8" is 1.
</pre>
<p>Explanation 2:</p>
<pre>
 Given encoded message "12", it could be decoded as "AB" (1, 2) or "L" (12).
 The number of ways decoding "12" is 2.
</pre></div><br/><br/></p>

</div>