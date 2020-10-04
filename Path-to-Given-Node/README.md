<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given a Binary Tree <strong>A</strong> containing <strong>N</strong> nodes.</p><p></p><p></p><p></p>
<p>You need to find the path from <strong>Root</strong> to a given node <strong>B</strong>.</p>
<p><strong>NOTE:</strong></p>
<ul>
<li>No two nodes in the tree have same data values.</li>
<li>You can assume that <strong>B</strong> is present in the tree <strong>A</strong> and a path always exists.</li>
</ul>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p> 1 &lt;= N &lt;= 10<sup>5</sup> </p><p></p><p></p><p></p>
<p> 1 &lt;= Data Values of Each Node &lt;= N</p>
<p> 1 &lt;= B &lt;= N</p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First Argument represents pointer to the root of binary tree <strong>A</strong>.</p><p></p><p></p><p></p><p></p>
<p>Second Argument is an integer <strong>B</strong> denoting the node number.</p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return an one-dimensional array denoting the path from <strong>Root</strong> to the node <strong>B</strong> in order.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre> A =<br/>
           1
         /   \
        2     3
       / \   / \
      4   5 6   7 </pre></div></p>
<p>B = 5

<p>Input 2:</p>
<pre> A = 
            1
          /   \
         2     3
        / \ .   \
       4   5 .   6</pre></p>
<p>B = 1<br/>

<p></p>
<p></p>
<p></p>
<p></p></p></div>