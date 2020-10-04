<div class="markdown-content" id="problem-content">
<p>Given two words (<strong>start</strong> and <strong>end</strong>), and a dictionary, find the shortest transformation sequence from <strong>start</strong> to <strong>end</strong>, such that:</p>
<blockquote>
<ul>
<li>Only one letter can be changed at a time</li>
<li>Each intermediate word must exist in the dictionary</li>
</ul>
</blockquote>
<p>If there are multiple such sequence of shortest length, return all of them. Refer to the example for more details.</p>
<p><strong>Note:</strong></p>
<blockquote>
<ul>
<li>All words have the same length.</li>
<li>All words contain only lowercase alphabetic characters.</li>
</ul>
</blockquote>
<p><strong>Input Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>The first argument is string start.
The second argument is string end.
The third argument is an array of strings dict
</code></pre>
</div>
<p><strong>Output Format</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Return all transformation sequences such that first word of each sequence is start and last word is end, all intermediate words belongs to dictionary(dict) and consecutive words had atmost 1 difference.  
</code></pre>
</div>
<p><strong>Example :</strong></p>
<p>:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>start = "hit"
end = "cog"
dict = ["hot","dot","dog","lot","log"]
</code></pre>
</div>
<p>Return</p>
<div class="highlighter-rouge"><pre class="highlight"><code>  [
    ["hit","hot","dot","dog","cog"],
    ["hit","hot","lot","log","cog"]
  ]
  
</code></pre>
</div>

</div>