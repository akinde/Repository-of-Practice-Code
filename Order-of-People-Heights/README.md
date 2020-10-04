<div class="markdown-content" id="problem-content">
<p>You are given the following :</p>
<ul>
<li>A positive number <code class="highlighter-rouge">N</code></li>
<li><code class="highlighter-rouge">Heights</code> : A list of <code class="highlighter-rouge">heights of N persons</code> standing in a <code class="highlighter-rouge">queue</code></li>
<li><code class="highlighter-rouge">Infronts</code> : A list of numbers corresponding to each person <code class="highlighter-rouge">(P)</code>  that gives the <strong>number of persons</strong> who are <strong>taller</strong> than <code class="highlighter-rouge">P</code> and standing in front of <code class="highlighter-rouge">P</code></li>
</ul>
<p>You need to <code class="highlighter-rouge">return</code>  list of actual order of persons’s height</p>
<p><strong>Consider that heights will be unique</strong></p>
<p><strong>Example</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>Input : 
Heights: 5 3 2 6 1 4
InFronts: 0 1 2 0 3 2
</code></pre>
</div>
<div class="highlighter-rouge"><pre class="highlight"><code>Output : 
actual order is: 5 3 2 1 6 4 
</code></pre>
</div>
<p>So, you can see that for the person with height 5, there is no one taller than him who is in front of him, and hence <code class="highlighter-rouge">Infronts</code> has 0 for him.</p>
<p>For person with height 3, there is 1 person ( Height : 5 ) in front of him who is taller than him.</p>
<p>You can do similar inference for other people in the list.</p>

</div>