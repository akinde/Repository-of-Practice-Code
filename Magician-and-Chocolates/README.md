<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given <strong>N</strong> bags, each bag contains <strong>B<sub>i</sub></strong> chocolates. There is a kid and a magician. In one unit of time, kid chooses a random bag <strong>i</strong>, eats <strong>B<sub>i</sub></strong> chocolates, then the magician fills the <strong>ith</strong> bag with <strong>floor(B<sub>i</sub>/2)</strong> chocolates.</p><p></p><p></p><p></p><p></p><p></p><p></p>
<p>Find the maximum number of chocolates that kid can eat in <strong>A</strong> units of time.</p>
<p><strong>NOTE:</strong> </p>
<ol><li>floor() function returns the largest integer less than or equal to a given number.</li>
<li>Return your answer modulo <strong>10<sup>9</sup>+7</strong></li></ol>
</div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First argument is an integer A.<br/>
Second argument is an integer array B of size N.</p></div><br><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return an integer denoting the maximum number of chocolates that kid can eat in A units of time.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre> A = 3
 B = [6, 5]</pre>
<p>Input 2:</p>
<pre> A = 5
 b = [2, 4, 6, 8, 10]</pre>
</div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre> 14</pre>
<p>Output 2:</p>
<pre> 33</pre>
</div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre> At t = 1 kid eats 6 chocolates from bag 0, and the bag gets filled by 3 chocolates. 
 At t = 2 kid eats 5 chocolates from bag 1, and the bag gets filled by 2 chocolates. 
 At t = 3 kid eats 3 chocolates from bag 0, and the bag gets filled by 1 chocolate. 
 so, total number of chocolates eaten are 6 + 5 + 3 = 14</pre>
<p></p></div><br/><br/></br></p>

</div>