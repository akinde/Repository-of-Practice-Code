<div class="markdown-content" id="problem-content">
<p>Given an array of words and a length L, format the text such that each line has exactly L characters and is fully <em>(left and right)</em> justified.<br/>
You should pack your words in a greedy approach; that is, pack as many words as you can in each line.</p>
<p>Pad extra spaces ‘ ‘ when necessary so that each line has exactly L characters.<br/>
Extra spaces between words should be distributed as evenly as possible.<br/>
If the number of spaces on a line do not divide evenly between words, the empty slots on the left will be assigned more spaces than the slots on the right.<br/>
For the last line of text, it should be left justified and no extra space is inserted between words.</p>
<p>Your program should return a list of strings, where each string represents a single line.</p>
<p><strong>Example:</strong></p>
<p>words: <code class="highlighter-rouge">["This", "is", "an", "example", "of", "text", "justification."]</code></p>
<p>L: <code class="highlighter-rouge">16</code>.</p>
<p>Return the formatted lines as:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>[
   "This    is    an",
   "example  of text",
   "justification.  "
]
</code></pre>
</div>
<blockquote>
<p><strong>Note:</strong> Each word is guaranteed not to exceed L in length.</p>
</blockquote>

</div>