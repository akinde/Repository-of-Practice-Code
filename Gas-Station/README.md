<div class="markdown-content" id="problem-content">
<p>Given two integer arrays <strong>A</strong> and <strong>B</strong> of size <strong>N</strong>.<br/>
There are <strong>N</strong> gas stations along a circular route, where the amount of gas at station <strong>i</strong> is <strong>A[i]</strong>.</p>
<p>You have a car with an unlimited gas tank and it costs <strong>B[i]</strong> of gas to travel from station <strong>i</strong> <br/>
to its next station <strong>(i+1)</strong>. You begin the journey with an empty tank at one of the gas stations.</p>
<p>Return the minimum starting gas station’s index if you can travel around the circuit once, otherwise return -1.</p>
<p>You can only travel in one direction. <strong>i to i+1, i+2, … n-1, 0, 1, 2..</strong> Completing the circuit means starting at <strong>i</strong> and <br/>
ending up at <strong>i</strong> again.</p>
<p><br/><br/>
<strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument given is the integer array A.
The second argument given is the integer array B.
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return the minimum starting gas station's index if you can travel around the circuit once, otherwise return -1.
</code></pre>
</div>
<p><strong>For Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input 1:
    A =  [1, 2]
    B =  [2, 1]
Output 1:
    1
    Explanation 1:
        If you start from index 0, you can fill in A[0] = 1 amount of gas. Now your tank has 1 unit of gas. But you need B[0] = 2 gas to travel to station 1. 
        If you start from index 1, you can fill in A[1] = 2 amount of gas. Now your tank has 2 units of gas. You need B[1] = 1 gas to get to station 0. So, you travel to station 0 and still have 1 unit of gas left over. You fill in A[0] = 1 unit of additional gas, making your current gas = 2. It costs you B[0] = 2 to get to station 1, which you do and complete the circuit. 
</code></pre>
</div>

</div>