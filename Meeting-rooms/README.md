<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given an 2D integer array <strong>A</strong> of size <code>N x 2</code> denoting time intervals of different meetings.</p>
<p>Where:</p>
<li><strong>A[i][0]</strong> = start time of the i<sup>th</sup> meeting.</li>
<li><strong>A[i][1]</strong> = end time of the i<sup>th</sup> meeting.</li>
<p>Find the <strong>minimum number of conference rooms</strong> required so that all meetings can be done.</p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= N &lt;= 10<sup></sup></p>
<p>0 &lt;= A[i][0] &lt; A[i][1] &lt;= 2 * 10<sup>9</sup></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>The only argument given is the matrix <strong>A</strong>.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return the minimum number of conference rooms required so that all meetings can be done.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p>
<pre>
 A = [      [0, 30]
            [5, 10]
            [15, 20]
     ]<br/>
</pre>
<p>Input 2:</p>
<pre>
 A =  [     [1, 18]
            [18, 23]
            [15, 29]
            [4, 15]
            [2, 11]
            [5, 13]
      ]
</pre></div><br><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p>
<pre>
 2
</pre>
<p>Output 2:</p>
<pre>
 4
</pre></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p>
<pre>
 Meeting one can be done in conference room 1 form 0 - 30.
 Meeting two can be done in conference room 2 form 5 - 10.
 Meeting one can be done in conference room 2 form 15 - 20 as it is free in this interval.
</pre>
<p>Explanation 2:</p>
<pre>
 Meeting one can be done in conference room 1 from 1 - 18.
 Meeting five can be done in conference room 2 from 2 - 11.
 Meeting four can be done in conference room 3 from 4 - 15.
 Meeting six can be done in conference room 4 from 5 - 13.
 Meeting three can be done in conference room 2 from 15 - 29 as it is free in this interval.
 Meeting two can be done in conference room 4 from 18 - 23 as it is free in this interval.
</pre></div><br/><br/></br></p>

</div>