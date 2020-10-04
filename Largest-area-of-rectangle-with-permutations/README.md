<div class="markdown-content" id="problem-content">
<p><strong>Problem Description</strong><br/><div id="problem_description_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Given a binary grid <strong>A</strong> of size <code>N x M</code> consisting of 0's and 1's, find the <strong>area of the largest rectangle</strong> inside the grid such that all the cells inside the chosen rectangle should have 1 in them.</p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p>
<p>You are allowed to permutate the columns matrix i.e. you can arrange each of the column in any order in the final grid.</p>
<p>Please follow the sample input and explanation for more clarity.</p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Input Format</strong><br/><div id="input_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>First and only argument is an 2D binary array <strong>A</strong>.</p></div><br/><br/><strong>Output Format</strong><br/><div id="output_format_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Return a single integer denoting the <strong>area of the largest rectangle</strong> inside the grid such that all the cells inside the chosen rectangle should have 1 in them.</p></div><br/><br/><strong>Example Input</strong><br/><div id="example_input_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Input 1:</p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre> A = [  [1, 0, 1]
        [0, 1 ,0]
        [1, 0, 0]
    ]
</pre>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Example Output</strong><br/><div id="example_output_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Output 1:</p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre> 2
</pre>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></div><br/><br/><strong>Example Explanation</strong><br/><div id="example_explanation_markdown_content_value" style="background-color: #f9f9f9; padding: 5px 10px; "><p>Explanation 1:</p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p>
<pre>    1 0 1
    0 1 0
    1 0 0</pre></div></p>
<p>At present we can see that max rectangle satisfying the criteria mentioned in the problem
 is of 1 * 1 = 1 area i.e either of the 4 cells which contain 1 in it.</p>
<p>Now since we are allowed to permutate the columns of the given matrix, we can take column 1
 and column 3 and make them neighbours. One of the possible configuration of the grid can be:
 1 1 0
 0 0 1
 1 0 0</p>
<p>Now In this grid, first column is column 1, second column is column 3 and third column
 is column 2 from the original given grid.</p>
<p>Now, we can see that if we calculate the max area rectangle, we get max area as 1 * 2 = 2
 which is bigger than the earlier case. Hence 2 will be the answer in this case.

<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p>
<p></p></p></div>