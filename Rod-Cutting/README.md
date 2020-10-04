<div class="markdown-content" id="problem-content">
<p>There is a rod of length N lying on x-axis with its left end at x = 0 and right end at x = N. Now, there are M weak points on this rod denoted by positive integer values(all less than N) A<sub>1</sub>, A<sub>2</sub>, …, A<sub>M</sub>. You have to cut rod at all these weak points. You can perform these cuts in any order. After a cut, rod gets divided into two smaller sub-rods. Cost of making a cut is the length of the sub-rod in which you are making a cut.</p>
<p>Your aim is to minimise this cost. Return an array denoting the sequence in which you will make cuts. If two different sequences of cuts give same cost, return the lexicographically smallest.</p>
<p><strong>Notes</strong>:</p>
<ul>
<li>Sequence a<sub>1</sub>, a<sub>2</sub> ,…, a<sub>n</sub> is lexicographically smaller than b<sub>1</sub>, b<sub>2</sub> ,…, b<sub>m</sub>, if and only if at the first i where a<sub>i</sub> and b<sub>i</sub> differ, a<sub>i</sub> &lt; b<sub>i</sub>, or if no such i found, then n &lt; m.</li>
<li>N can be upto 10<sup>9</sup>.</li>
</ul>
<p>For example,</p>
<div class="highlighter-rouge"><pre class="highlight"><code>N = 6
A = [1, 2, 5]

If we make cuts in order [1, 2, 5], let us see what total cost would be.
For first cut, the length of rod is 6.
For second cut, the length of sub-rod in which we are making cut is 5(since we already have made a cut at 1).
For third cut, the length of sub-rod in which we are making cut is 4(since we already have made a cut at 2).
So, total cost is 6 + 5 + 4.

Cut order          | Sum of cost
(lexicographically | of each cut
 sorted)           |
___________________|_______________
[1, 2, 5]          | 6 + 5 + 4 = 15
[1, 5, 2]          | 6 + 5 + 4 = 15
[2, 1, 5]          | 6 + 2 + 4 = 12
[2, 5, 1]          | 6 + 4 + 2 = 12
[5, 1, 2]          | 6 + 5 + 4 = 15
[5, 2, 1]          | 6 + 5 + 2 = 13


So, we return [2, 1, 5].

</code></pre>
</div>

</div>