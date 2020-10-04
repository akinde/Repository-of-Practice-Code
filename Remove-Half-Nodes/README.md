<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given a binary tree <strong>A</strong> with <strong>N</strong> nodes.</p><p></p>
<p>You have to remove all the half nodes and return the final binary tree.</p>
<p><strong>NOTE:</strong></p>
<ul><li>Half nodes are nodes which have only one child.</li>
<li>Leaves should not be touched as they have both children as NULL.</li>
</ul>
<p></p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p> 1 &lt;= N &lt;= 10<sup>5</sup></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First and only argument is an pointer to the root of binary tree <strong>A</strong>.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return a pointer to the root of the new binary tree.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre>           1
         /   \
        2     3
       / 
      4<br/>
</pre>
<p>Input 2:</p>
<pre>            1
          /   \
         2     3
        / \     \
       4   5     6
</pre>
<p></p></div><br><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre>           1
         /    \
        4      3
</pre>
<p>Output 2:</p>
<pre>            1
          /   \
         2     6
        / \<br/>
       4   5<br/>
</pre>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br><br><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p>
<pre> The only half node present in the tree is 2 so we will remove this node.
</pre>
<p>Explanation 2:</p>
<pre> The only half node present in the tree is 3 so we will remove this node.
</pre>
<p></p></div><br/><br/></br></br></br></p>

</div>