<div class="markdown-content" id="problem-content">
<p>Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.</p>
<blockquote>
<ul>
<li><strong>push(x)</strong> – Push element x onto stack.</li>
<li><strong>pop()</strong> – Removes the element on top of the stack.</li>
<li><strong>top()</strong> – Get the top element.</li>
<li><strong>getMin()</strong> – Retrieve the minimum element in the stack.</li>
</ul>
</blockquote>
<p>Note that all the operations have to be constant time operations.</p>
<p>Questions to ask the interviewer :</p>
<div class="highlighter-rouge"><pre class="highlight"><code>Q: What should getMin() do on empty stack? 
A: In this case, return -1.

Q: What should pop do on empty stack? 
A: In this case, nothing. 

Q: What should top() do on empty stack?
A: In this case, return -1
</code></pre>
</div>
<blockquote>
<p><strong>NOTE</strong> : If you are using your own declared global variables, make sure to clear them out in the constructor.</p>
</blockquote>

</div>