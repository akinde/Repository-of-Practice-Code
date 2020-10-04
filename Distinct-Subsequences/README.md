<div class="markdown-content" id="problem-content">
<p>Given two sequences <strong>A</strong>, <strong>B</strong>, count number of unique ways in sequence <strong>A</strong>, to form a subsequence that is identical to the sequence <strong>B</strong>.</p>
<p><strong>Subsequence :</strong> A subsequence of a string is a new string which is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (ie, “ACE” is a subsequence of “ABCDE” while “AEC” is not).</p>
<p><strong>Input Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument of input contains a string, A.
The second argument of input contains a string, B.
</code></pre>
</div>
<p><strong>Output Format:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return an integer representing the answer as described in the problem statement.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= length(A), length(B) &lt;= 700
</code></pre>
</div>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A = "abc"
    B = "abc"
    
Output 1:
    1

Explanation 1:
    Both the strings are equal.

Input 2:
    A = "rabbbit" 
    B = "rabbit"

Output 2:
    3

Explanation 2:
    These are the possible removals of characters:
        =&gt; A = "ra_bbit" 
        =&gt; A = "rab_bit" 
        =&gt; A = "rabb_it"
        
    Note: "_" marks the removed character.
</code></pre>
</div>

</div>