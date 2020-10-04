<div class="markdown-content" id="problem-content">
<p>There are <code class="highlighter-rouge">N</code> Mice and <code class="highlighter-rouge">N</code> holes are placed in a straight line. <br/>
Each hole can accomodate only 1 mouse. <br/>
A mouse can stay at his position, move one step right from <code class="highlighter-rouge">x</code> to <code class="highlighter-rouge">x + 1</code>, or move one step left from <code class="highlighter-rouge">x</code> to <code class="highlighter-rouge">x − 1</code>. Any of these moves consumes 1 minute.<br/>
Assign mice to holes so that the time when the last mouse gets inside a hole is minimized.</p>
<p><strong>Example:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>positions of mice are:
4 -4 2
positions of holes are:
4 0 5

Assign mouse at position x=4 to hole at position x=4 : Time taken is 0 minutes 
Assign mouse at position x=-4 to hole at position x=0 : Time taken is 4 minutes 
Assign mouse at position x=2 to hole at position x=5 : Time taken is 3 minutes 
After 4 minutes all of the mice are in the holes.

Since, there is no combination possible where the last mouse's time is less than 4, 
answer = 4.
</code></pre>
</div>
<p><strong>Input:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>A :  list of positions of mice
B :  list of positions of holes
</code></pre>
</div>
<p><strong>Output:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>single integer value
</code></pre>
</div>
<blockquote>
<p><strong>NOTE:</strong> The final answer will fit in a 32 bit signed integer.</p>
</blockquote>

</div>