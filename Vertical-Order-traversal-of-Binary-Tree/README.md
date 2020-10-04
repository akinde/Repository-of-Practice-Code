<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given a binary tree <strong>A</strong> consisting of <strong>N</strong> nodes, return a 2-D array denoting the vertical order traversal of <strong>A</strong>.</p><p></p><p></p>
<p>Go through the example and image for more details.</p>
<p><strong>NOTE:</strong></p>
<ul>
<li>If 2 or more Tree Nodes shares the same vertical level then the one with earlier occurence in the pre-order traversal of tree comes first in the output.</li>
<li>Row 1 of the output array will be the nodes on leftmost vertical line similarly last row of the output array will be the nodes on the rightmost vertical line.</li>
</ul>
<p></p>
<p></p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>0 &lt;= N &lt;= 10<sup>4</sup></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First and only argument is an pointer to root of the binary tree <strong>A</strong>.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return a 2D array denoting the vertical order traversal of <strong>A</strong>.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p><p></p>
<pre>      6
    /   \
   3     7
  / \     \
 2   5     9
</pre>
<p>Input 2:</p>
<pre>           1
         /   \
        2     3
       / \
      4   5
</pre>
<p></p>
<p></p></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p><p></p>
<pre> [
    [2],
    [3],
    [6, 5],
    [7],
    [9]
 ]
</pre>
<p>Output 2:</p>
<pre> [
    [4],
    [2],
    [1, 5],
    [3]
 ]
</pre>
<p></p>
<p></p></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p><p></p>
<pre> <img height="50%" src="https://imgur.com/FIsIzTK.jpeg" width="50%"/>
 Nodes on Vertical Line 1: 2
 Nodes on Vertical Line 2: 3
 Nodes on Vertical Line 3: 6, 5
    As 6 and 5 are on the same vertical level but as 6 comes first in the pre-order traversal of the tree so we will output 6 before 5.
 Nodes on Vertical Line 4: 7
 Nodes on Vertical Line 5: 9
</pre>
<p>Explanation 2:</p>
<pre> Nodes on Vertical Line 1: 4
 Nodes on Vertical Line 2: 2
 Nodes on Vertical Line 3: 1, 5
 Nodes on Vertical Line 4: 3
</pre>
<p></p>
<p></p></div><br/><br/></p>

</div>