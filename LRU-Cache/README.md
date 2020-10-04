<div class="markdown-content" id="problem-content">
<p>Design and implement a data structure for LRU (Least Recently Used) cache. It should support the following operations: get and set.</p>
<ol>
<li><code class="highlighter-rouge">get(key)</code> - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return <code class="highlighter-rouge">-1</code>.</li>
<li><code class="highlighter-rouge">set(key, value)</code> - Set or insert the value if the key is not already present. When the cache reaches its capacity, it should invalidate the least recently used item before inserting the new item.</li>
</ol>
<p>The LRU Cache will be initialized with an integer corresponding to its capacity. Capacity indicates the maximum number of unique keys it can hold at a time.</p>
<p><strong>Definition of “least recently used”</strong> : An access to an item is defined as a get or a set operation of the item. “Least recently used” item is the one with the oldest access time.</p>
<blockquote>
<p><strong>NOTE:</strong> If you are using any global variables, make sure to clear them in the constructor.</p>
</blockquote>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge">
<pre class="highlight"><code>Input : 
         capacity = 2
         set(1, 10)
         set(5, 12)
         get(5)        returns 12
         get(1)        returns 10
         get(10)       returns -1
         set(6, 14)    this pushes out key = 5 as LRU is full. 
         get(5)        returns -1 

</code></pre>
</div>

</div>