<div class="markdown-content" id="problem-content">
<p>Write a SQL Query to find the movie_title and name of director (first and last names combined) who directed a movie that casted a role as ‘SeanMaguire’.</p>
<p><strong>Output Schema:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>director_name,movie_title
</code></pre>
</div>
<p><strong>NOTE:</strong></p>
<ul>
<li>Output column name has to match the given output schema.</li>
<li>Any name is the concatenation(without any delimiter) of first and last name if present</li>
<li>(E.g. if director_first_name is ‘Alfred’ and  director_last_name is ‘Hitchcock’ then director_name is ‘AlfredHitchcock’)</li>
</ul>
<hr/>
<p><strong>Example Output:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>director_name,movie_title
AlfredHitchcock,Vertigo
</code></pre>
</div>
<hr/>
<p><strong>Schema Design:</strong></p>
<p><img alt="Schema Description" src="https://s3-us-west-2.amazonaws.com/ib-assessment-tests/problem_images/sql_course.jpg"/></p>

</div>