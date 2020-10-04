<div class="markdown-content" id="problem-content">
<p>You are given an array <strong>A</strong> consisting of strings made up of the letters ‘a’ and ‘b’ only.  <br/>
Each string goes through a number of operations, where:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>1.	At time 1, you circularly rotate each string by 1 letter.
2.	At time 2, you circularly rotate the new rotated strings by 2 letters.
3.	At time 3, you circularly rotate the new rotated strings by 3 letters.
4.	At time i, you circularly rotate the new rotated strings by i % length(string) letters.

Eg: String is "abaa"

1.	At time 1, string is "baaa", as 1 letter is circularly rotated to the back
2.	At time 2, string is "aaba", as 2 letters of the string "baaa" is circularly rotated to the back
3.	At time 3, string is "aaab", as 3 letters of the string "aaba" is circularly rotated to the back
4.	At time 4, string is again "aaab", as 4 letters of the string "aaab" is circularly rotated to the back
5.	At time 5, string is "aaba", as 1 letters of the string "aaab" is circularly rotated to the back
</code></pre>
</div>
<p>After some units of time, a string becomes equal to it’s original self.  <br/>
Once a string becomes equal to itself, it’s letters start to rotate from the first letter again (<strong>process resets</strong>). So, if a string takes <strong>t</strong> time to get back to the original, at time t+1 one letter will be rotated and the string will be it’s original self at 2<strong>t</strong> time.  <br/>
You have to find the minimum time, where maximum number of strings are equal to their original self.  <br/>
As this time can be very large, give the answer modulo 10<sup>9</sup>+7.</p>
<p><strong>Note:</strong> Your solution will run on multiple test cases so do clear global variables after using them.</p>
<p><strong>Input:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>A: Array of strings.
</code></pre>
</div>
<p><strong>Output:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Minimum time, where maximum number of strings are equal to their original self.
</code></pre>
</div>
<p><strong>Constraints:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>1 &lt;= size(A) &lt;= 10^5
1 &lt;= size of each string in A &lt;= 10^5
Each string consists of only characters 'a' and 'b'
Summation of length of all strings &lt;= 10^7
</code></pre>
</div>
<p><strong>Example:</strong></p>
<p><strong>Input</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>A: [a,ababa,aba]
</code></pre>
</div>
<p><strong>Output</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>4

String 'a' is it's original self at time 1, 2, 3 and 4.
String 'ababa' is it's original self only at time 4. (ababa =&gt; babaa =&gt; baaba =&gt; babaa =&gt; ababa)
String 'aba' is it's original self at time 2 and 4. (aba =&gt; baa =&gt; aba)

Hence, 3 strings are their original self at time 4.
</code></pre>
</div>

</div>