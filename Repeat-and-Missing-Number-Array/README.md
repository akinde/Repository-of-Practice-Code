<div class="markdown-content" id="problem-prenote">
<h4>Please Note:</h4>
<p>There are certain problems which are asked in the interview to also check how you take care of <strong>overflows</strong> in your problem.<br/>
This is one of those problems.<br/>
Please take extra care to make sure that you are type-casting your ints to long properly and at all places. <strong>Try to verify if your solution works if number of elements is as large as 10<sup>5</sup></strong></p>
<blockquote>
<p><strong>Food for thought</strong> :</p>
<ul>
<li>Even though it might not be required in this problem, in some cases, you might be required to order the operations cleverly so that the numbers do not overflow. <br/>
 For example, if you need to calculate n! / k! where n! is factorial(n), one approach is to calculate factorial(n), factorial(k) and then divide them. <br/>
 Another approach is to only multiple numbers from <code class="highlighter-rouge">k + 1 ... n</code> to calculate the result. <br/>
 Obviously approach 1 is more susceptible to overflows.</li>
</ul>
</blockquote>
<hr/>
</div>