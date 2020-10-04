<div class="markdown-content" id="problem-content">
<p>Given a csv file(with <code class="highlighter-rouge">,</code> as a delimiter) named <code class="highlighter-rouge">input</code> with the following fields:</p>
<ul>
<li><code class="highlighter-rouge">FirstName</code></li>
<li><code class="highlighter-rouge">LastName</code></li>
<li><code class="highlighter-rouge">Address</code></li>
<li><code class="highlighter-rouge">City</code></li>
<li><code class="highlighter-rouge">CountryCode</code></li>
<li><code class="highlighter-rouge">Email</code></li>
<li><code class="highlighter-rouge">PhoneNumber</code></li>
</ul>
<p>Write a bash script to combine both <code class="highlighter-rouge">CountryCode</code> and <code class="highlighter-rouge">PhoneNumber</code> with a <code class="highlighter-rouge">-</code> and add a <code class="highlighter-rouge">+</code> before country code and remove country codes from the csv file</p>
<p><strong>Example:</strong></p>
<p>Assume that <code class="highlighter-rouge">input</code> has the following content:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>Lotty,Kilner,08 Boyd Place,Jiangqiao,04,lkilner0@epa.gov,433-447-7966
Benoite,Ducket,9 Harper Alley,Tenenkou,22,bducket1@friendfeed.com,724-995-7769
</code></pre>
</div>
<p>Your script should output the following:</p>
<div class="highlighter-rouge"><pre class="highlight"><code>Lotty,Kilner,08 Boyd Place,Jiangqiao,lkilner0@epa.gov,+04-433-447-7966
Benoite,Ducket,9 Harper Alley,Tenenkou,bducket1@friendfeed.com,+22-724-995-7769
</code></pre>
</div>
<p><strong>Note:</strong></p>
<ul>
<li>Note that the given csv file does not contain headers i.e., only data is present.</li>
</ul>

</div>