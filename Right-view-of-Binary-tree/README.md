<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given a binary tree <strong>A</strong> of integers. Return an array of integers representing the <strong>right view</strong> of the Binary tree.</p>
<p><strong>Right view of a Binary Tree:</strong> is a set of nodes visible when the tree is visited from Right side.</p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= Number of nodes in binary tree &lt;= 10<sup>5</sup></p>
<p>0 &lt;= node values &lt;= 10<sup>9</sup> </p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First and only argument is an pointer to the root of binary tree <strong>A</strong>.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return an integer array denoting the right view of the binary tree <strong>A</strong>.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p>
<pre>
        1
      /   \
     2    3
    / \  / \
   4   5 6  7
  /
 8 
</pre>
<p>Input 2:</p>
<pre>
    1
   /  \
  2    3
   \
    4
     \
      5
</pre></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p>
<pre>
 [1, 3, 7, 8]
</pre>
<p>Output 2:</p>
<pre>
 [1, 3, 4, 5]
</pre></div><br/><br/></p>

</div>