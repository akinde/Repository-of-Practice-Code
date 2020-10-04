<div class="markdown-content" id="problem-content">
<p>There are a total of <strong>A</strong> courses you have to take, labeled from <strong>1</strong> to <strong>A</strong>.</p>
<p>Some courses may have prerequisites, for example to take course <strong>2</strong> you have to first take course <strong>1</strong>, which is expressed as a pair: <strong>[1,2]</strong>.</p>
<p>Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?</p>
<p>Return <strong>1</strong> if it is <strong>possible</strong> to finish all the courses, or <strong>0</strong> if it is <strong>not possible</strong> to finish all the courses.</p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument of input contains an integer A, representing the number of courses.
The second argument of input contains an integer array, B.
The third argument of input contains an integer array, C.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return a boolean value:
    1 : If it is possible to complete all the courses.
    0 : If it is not possible to complete all the courses.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= A &lt;= 6e4
1 &lt;= length(B) = length(C) &lt;= 1e5
1 &lt;= B[i], C[i] &lt;= A
</code></pre>
</div>
<p><strong>Example:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = 3
    B = [1, 2]
    C = [2, 3]

Output 1:
    1

Explanation 1:
    It is possible to complete the courses in the following order:
        1 -&gt; 2 -&gt; 3

Input 2:
    A = 2
    B = [1, 2]
    C = [2, 1]

Output 2:
    0

Explanation 2:
    It is not possible to complete all the courses.
</code></pre>
</div>

</div>