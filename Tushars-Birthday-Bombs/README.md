<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>It’s Tushar’s birthday today and he has <strong>N</strong> friends.</p>
<p>Friends are numbered <strong>[0, 1, 2, ...., N-1]</strong> and <strong>i<sup>th</sup></strong> friend have a positive strength <strong>B[i]</strong>.</p>
<p>Today being his birthday, his friends have planned to give him birthday bombs (kicks).</p>
<p>Tushar's friends know Tushar's pain bearing limit and would hit accordingly.</p>
<p>If Tushar’s resistance is denoted by <strong>A (&gt;=0)</strong> then find the lexicographically smallest order of friends to kick Tushar so that the cumulative kick strength (sum of the strengths of friends who kicks) doesn’t exceed his resistance capacity and total no. of kicks hit are maximum.</p>
<p>Also note that each friend can kick unlimited number of times (If a friend hits x times, his strength will be counted x times)</p>
<p>Return the lexicographically smallest array of maximum length where the ith index represents the index of the friend who will hit.</p>
<p><strong>NOTE:</strong></p>
<li> [a1, a2, ...., am] is lexicographically smaller than [b1, b2, .., bm]  if a1 &lt; b1 or (a1 = b1 and a2 &lt; b2) ... .</li>
<li> Input cases are such that the length of the answer does not exceed 100000.</li></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= N &lt;= 100</p>
<p>1 &lt;= A &lt;= 15 * 10<sup>6</sup><p>
<p>1 &lt;= B[i] &lt;= 10<sup>5</sup></p></p></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>The first argument contains an integer, A of length N.</p>
<p>The second argument contains an array of integers B.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return an array of integer, as described in the problem statement.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p>
<pre>
 A = 12
 B = [3, 4]
</pre>
<p>Input 2:</p>
<pre>
 A = 11
 B = [6, 8, 5, 4, 7]
</pre></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p>
<pre>
 [0, 0, 0, 0]
</pre>
<p>Output 2:</p>
<pre>
 [0, 2]
</pre></div><br/><br/></p>

</div>