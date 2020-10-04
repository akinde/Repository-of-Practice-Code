<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given an arbitrary unweighted rooted tree which consists of <strong>N</strong> nodes.</p><p></p>
<p>The goal of the problem is to find <strong>largest distance between two nodes in a tree.</strong></p>
<p>Distance between two nodes is a number of edges on a path between the nodes (there will be a unique path between any pair of nodes since it is a tree).</p>
<p>The nodes will be numbered <strong>0</strong> through <strong>N - 1</strong>.</p>
<p>The tree is given as an array <strong>A</strong>, there is an edge between nodes <strong>A[i]</strong> and <strong>i (0 &lt;= i &lt; N)</strong>. Exactly one of the i's will have A[i] equal to -1, it will be root node.</p>
<p></p></div><br/><br/><strong>Problem Constraints</strong><br/><div id="problem_constraints_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>1 &lt;= N &lt;= 40000</p>
</div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First and only argument is an integer array A of size <strong>N</strong>.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return a single integer denoting the largest distance between two nodes in a tree.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p>
<pre> A = [-1, 0, 0, 0, 3]
</pre>
<p></p></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p>
<pre> 3
</pre>
<p></p></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p>
<pre> node 0 is the root and the whole tree looks like this: 
          0
       /  |  \
      1   2   3
               \
                4<br/>
 One of the longest path is 1 -&gt; 0 -&gt; 3 -&gt; 4 and its length is 3, thus the answer is 3.
</pre>
<p></p></div><br><br/></br></p>

</div>