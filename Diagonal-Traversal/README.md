<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Consider lines of slope -1 passing between nodes.</p><p></p><p></p><p></p><p></p>
<p>Given a Binary Tree <strong>A</strong> containing <strong>N</strong> nodes, return all diagonal elements in a binary tree belonging to same line.</p>
<p><strong>NOTE:</strong></p>
<ul>
<li>See Sample Explanation for better understanding.</li>
<li>Order does matter in the output.</li>
<li>To get the same order as in the output traverse the tree same as we do in pre-order traversal.</li>
</ul>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p> 0 &lt;= N &lt;= 10<sup>5</sup> </p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First and only Argument represents the root of binary tree <strong>A</strong>.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return a 1D array denoting the diagonal traversal of the tree.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p><p></p><p></p><p></p>
<pre>            1
          /   \
         4      2
        / \      \
       8   5      3
          / \    /
         9   7  6
</pre>
<p>Input 2:</p>
<pre>             11
          /     \
         20      12
        / \       \
       1   15      13
          /  \     /
         2    17  16
          \   /
          22 34
</pre>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p><p></p><p></p><p></p>
<pre> [1, 2, 3, 4, 5, 7, 6, 8, 9]
</pre>
<p>Output 2:</p>
<pre> [11, 12, 13, 20, 15, 17, 16, 1, 2, 22, 34]
</pre>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p><p></p><p></p><p></p>
<pre> <img height="30%" src="https://i.imgur.com/TssjQtS.jpeg" width="40%"/>
 1) Diagonal 1 contains [1, 2, 3]
 2) Diagonal 2 contains [4, 5, 7, 6]
 3) Diagonal 3 contains [8, 9]</pre></div></p>
<p><strong>NOTE:</strong>
The order in the output matters like for Example:
6 and 7 belong to same diagonal i.e diagonal 2 but as 7 comes before 6 in pre-order traversal so 7 will be added to answer array first.</p>
<p>So concantenate all the array as return it as a single one.
 Final output: [1, 2, 3, 4, 5, 7, 6, 8, 9]

<p>Explanation 2:</p>
<pre> <img height="30%" src="https://i.imgur.com/bTL4IOH.jpeg" width="40%"/>
 1) Diagonal 1 contains [11, 12, 13]
 2) Diagonal 2 contains [20, 15, 17, 16]
 3) Diagonal 2 contains [1, 2, 22, 34]</pre></p>
<p>So concantenate all the array as return it as a single one.
 Final output: [11, 12, 13, 20, 15, 17, 16, 1, 2, 22, 34]</p>
<p>
<p></p>
<p></p>
<p></p>
<p></p></p></div>