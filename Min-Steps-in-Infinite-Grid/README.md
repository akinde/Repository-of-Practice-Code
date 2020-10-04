<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>You are in an infinite 2D grid where you can move in any of the 8 directions</p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre> (x,y) to 
    (x+1, y), 
    (x - 1, y), 
    (x, y+1), 
    (x, y-1), 
    (x-1, y-1), 
    (x+1,y+1), 
    (x-1,y+1), 
    (x+1,y-1) </pre>
<p>You are given a sequence of points and <strong>the order in which you need to cover the points.</strong>. Give the minimum number of steps in which you can achieve it. You start from the first point.</p>
<p><strong>NOTE: </strong>This question is intentionally left slightly vague. Clarify the question by trying out a few cases in the “See Expected Output” section.</p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given two integer arrays A and B, where A[i] is x coordinate and B[i] is y coordinate of ith point respectively.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return an Integer, i.e minimum number of steps.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre> A = [0, 1, 1]
 B = [0, 1, 2]</pre>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre> 2</pre>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre> Given three points are: (0, 0), (1, 1) and (1, 2).
 It takes 1 step to move from (0, 0) to (1, 1). It takes one more step to move from (1, 1) to (1, 2).</pre>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/></p>

</div>