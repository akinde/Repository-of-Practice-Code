<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p><strong>Max Heap</strong> is a special kind of <strong>complete binary tree</strong> in which for every node the value present in that node is greater than the value present in it’s children nodes.</p><p></p><p></p><p></p><p></p>
<p>Find the number of <strong>distinct Max Heap</strong> can be made from <strong>A distinct integers</strong>.</p>
<p>In short, you have to ensure the following properties for the max heap :</p>
<ul><li>Heap has to be a complete binary tree ( A complete binary tree is a binary tree in which every level, except possibly the last, is completely filled, and all nodes are as far left as possible.)</li>
<li>Every node is greater than all its children.</li></ul>
<p><strong>NOTE: </strong> If you want to know more about Heaps, please visit this <a href="https://en.wikipedia.org/wiki/Heap_%28data_structure%29">link</a>. Return your answer <strong>modulo 10<sup>9</sup> + 7</strong>.</p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= A &lt;= 100</p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First and only argument is an inetegr A.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return an integer denoting the number of distinct Max Heap.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p><p></p><p></p><p></p>
<pre> A = 4</pre>
<p>Input 2:</p>
<pre> A = 10</pre>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p><p></p><p></p><p></p>
<pre> 3</pre>
<p>Output 2:</p>
<pre> 3360</pre>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p><p></p><p></p><p></p>
<pre> Let us take 1, 2, 3, 4 as our 4 distinct integers
 Following are the 3 possible max heaps from these 4 numbers :
      4           4                     4
    /  \         / \                   / \ 
   3    2   ,   2   3      and        3   1
  /            /                     /<br/>
 1            1                     2
</pre>
<p>Explanation 2:</p>
<pre> Number of distinct heaps possible with 10 distinct integers = 3360.
</pre>
<p></p>
<p></p>
<p></p>
<p></p></div><br><br/></br></p>

</div>