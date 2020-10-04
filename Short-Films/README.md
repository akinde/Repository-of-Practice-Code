<div class="markdown-content" id="problem-content">
<p>Write a SQL Query to find those lowest duration movies along with the year, director’s name(first and last name combined), actor’s name(first and last name combined) and his/her role in that production.</p>
<p><strong>Output Schema:</strong></p>
<div class="highlighter-rouge"><pre class="highlight"><code>movie_title,movie_year,director_name,actor_name,role
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
<div class="highlighter-rouge"><pre class="highlight"><code>movie_title,movie_year,director_name,actor_name,role
Vertigo,1958,AlfredHitchcock,JamesStewart,JohnFerguson
</code></pre>
</div>
<hr/>
<p><strong>Schema Design:</strong></p>
<p><img alt="Schema Description" src="https://s3-us-west-2.amazonaws.com/ib-assessment-tests/problem_images/sql_course.jpg"/></p>

</div>