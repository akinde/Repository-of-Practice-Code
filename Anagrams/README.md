<div class="markdown-content" id="problem-content">
<p>Given an array of strings, return all groups of strings that are anagrams. Represent a group by a list of integers representing the index in the original list. Look at the sample case for clarification.</p>
<blockquote>
<p><strong>Anagram :</strong> a word, phrase, or name formed by rearranging the letters of another, such as <code class="highlighter-rouge">'spar'</code>, formed from <code class="highlighter-rouge">'rasp'</code></p>
</blockquote>
<blockquote>
<p><strong>Note:</strong>  All inputs will be in lower-case.</p>
</blockquote>
<p><strong>Example :</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input : cat dog god tca
Output : [[1, 4], [2, 3]]
</code></pre>
</div>
<p><code class="highlighter-rouge">cat</code> and <code class="highlighter-rouge">tca</code> are anagrams which correspond to index <code class="highlighter-rouge">1</code> and <code class="highlighter-rouge">4</code>. <br/>
<code class="highlighter-rouge">dog</code> and <code class="highlighter-rouge">god</code> are another set of anagrams which correspond to index <code class="highlighter-rouge">2</code> and <code class="highlighter-rouge">3</code>.<br/>
The indices are 1 based ( the first element has index 1 instead of index 0).</p>
<blockquote>
<p><strong>Ordering of the result :</strong> You should not change the relative ordering of the words / phrases within the group. Within a group containing <code class="highlighter-rouge">A[i]</code> and <code class="highlighter-rouge">A[j]</code>, <code class="highlighter-rouge">A[i]</code> comes before <code class="highlighter-rouge">A[j]</code> if <code class="highlighter-rouge">i &lt; j</code>.</p>
</blockquote>

</div>