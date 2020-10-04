<div class="markdown-content subjective-problem" id="problem-content" style="position: relative; min-height: 420px;">
<div class="hidden-xs" id="problem-complete-graph-ct">
<div id="problem-complete-graph"></div>
<div id="problem-complete-percent">40%</div>
</div>
<div class="ng-hide ng-cloak" id="vertical-line" ng-cloak="" ng-hide="!showTimeLine || true"></div>
<div class="main" id="system-design-root" style="display: none;">
<div data-comment-url="https://www.interviewbit.com/courses/system-design/topics/interview-questions/problems/design-url-shortener/" id="comment-url"></div>
<h2 class="text-center problem-desc" ng-bind-html="renderHtml(problem['statement'])" style="font-size: 16px"> </h2>
<div ng-if="show_features">
<hr/>
<h4> <br/> Features: </h4>
<blockquote class="newEl"> <p> This is the first part of any system design interview, coming up with the features which the system should support. As an interviewee, you should try to list down all the features you can think of which our system should support. Try to spend around 2 minutes for this section in the interview. You can use the notes section alongside to remember what you wrote. </p> </blockquote>
</div>
<ul style="list-style-type:circle">
<li class="question-background-main list-group {{feature.isNew}}" ng-repeat="feature in features_shown">
<span class="question-text" ng-bind-html="renderHtml(feature.text.split('&lt;br /&gt;')[0])"></span>
<br>
<span class="answer-text" ng-bind-html="renderHtml(feature.text.split('&lt;br /&gt;')[1])"></span>
</br></li>
</ul>
<div ng-if="sections_visible[1]">
<hr/>
<br/><br/>
<h4> Estimation: </h4>
<blockquote> <p class="newEl"> This is usually the second part of a design interview, coming up with the estimated numbers of how scalable our system should be. Important parameters to remember for this section is the number of queries per second and the data which the system will be required to handle. <br/> Try to spend around 5 minutes for this section in the interview. </p> </blockquote>
</div>
<div class="question-start" ng-repeat="question in sections_shown[1]['questions']">
<p>
<div class="newEl question-text question-background-main" ng-bind-html="renderHtml(question['text'])"></div>
<div ng-if="question['explanation']">
<div class="newEl question-background" ng-repeat="q in question['explanation']['questions']" style="margin-left: 30px">
<div class="container-fluid" style="padding-left: 0; padding-right: 0;">
<div class="col-md-11 question-text" ng-bind-html="renderHtml(q['text'])" style="padding: 0px"></div>
<div class="col-md-1">
<div class="pull-right">
<a href="" ng-click="getComments(q, $event)">
<span class="fa-stack fa-2x comment-icon" style="font-size: 16px;">
<i class="fa fa-comment fa-stack-2x" style="font-size: 2em;"></i>
<i class="fa fa-stack-1x"><span>{{q['count']}}</span></i>
</span></a>
</div>
</div>
</div>
<div class="" ng-bind-html="renderHtml(q['explanation']['text'])" ng-if="q['explanation']"></div>
<div ng-bind-html="renderHtml(q['answer'])" ng-if="q['answer']"></div>
<br/>
</div>
<div class="newEl" ng-bind-html="renderHtml(question['explanation']['text'])" ng-if="question['explanation']['text']"></div>
</div>
<div class="container-fluid question-background-main answer-text" ng-if="question['answer']">
<div class="newEl col-md-11" ng-bind-html="renderHtml(question['answer'])"></div>
<div class="pull-right">
<div class="col-md-1">
<a href="" ng-click="getComments(question, $event)">
<span class="fa-stack fa-2x comment-icon" style="font-size: 16px; ">
<i class="fa fa-comment fa-stack-2x" style="font-size: 2em;"></i>
<i class="fa fa-stack-1x"><span>{{question['count']}}</span></i>
</span></a>
</div>
</div>
</div>
</p>
</div>
<div ng-if="sections_visible[2]">
<hr/>
<br/><br/>
<h4> Design Goals: </h4>
<blockquote class="newEl">
<ul>
<li><b>Latency</b> - Is this problem very latency sensitive (Or in other words, Are requests with high latency and a failing request, equally bad?). For example, search typeahead suggestions are useless if they take more than a second.</li>
<li><b>Consistency</b> - Does this problem require tight consistency? Or is it okay if things are eventually consistent?</li>
<li><b>Availability</b> - Does this problem require 100% availability?</li>
</ul>
<i>There could be more goals depending on the problem.
        It's possible that all parameters might be important, and some of them might conflict. In that case, you’d need to prioritize one over the other.</i>
</blockquote>
</div>
<div class="question-start" ng-repeat="question in sections_shown[2]['questions']">
<p>
<div class="newEl question-text question-background-main" ng-bind-html="renderHtml(question['text'])"></div>
<div ng-if="question['explanation']">
<div class="newEl question-background" ng-repeat="q in question['explanation']['questions']" style="margin-left: 30px">
<div class="container-fluid" style="padding-left: 0; padding-right: 0;">
<div class="col-md-11 question-text" ng-bind-html="renderHtml(q['text'])" style="padding: 0px"></div>
<div class="col-md-1">
<div class="pull-right">
<a href="" ng-click="getComments(q, $event)">
<span class="fa-stack fa-2x comment-icon" style="font-size: 16px;">
<i class="fa fa-comment fa-stack-2x" style="font-size: 2em;"></i>
<i class="fa fa-stack-1x"><span>{{q['count']}}</span></i>
</span>
</a>
</div>
</div>
</div>
<div class="" ng-bind-html="renderHtml(q['explanation']['text'])" ng-if="q['explanation']"></div>
<div class="" ng-bind-html="renderHtml(q['answer'])" ng-if="q['answer']"></div>
<br/>
</div>
<div class="newEl" ng-bind-html="renderHtml(question['explanation']['text'])" ng-if="question['explanation']['text']"></div>
</div>
<div class="container-fluid question-background-main answer-text" ng-if="question['answer']">
<div class="newEl col-md-11" ng-bind-html="renderHtml(question['answer'])"></div>
<div class="pull-right">
<div class="col-md-1">
<a href="" ng-click="getComments(question, $event)">
<span class="fa-stack fa-2x comment-icon" style="font-size: 16px;">
<i class="fa fa-comment fa-stack-2x" style="font-size: 2em;"></i>
<i class="fa fa-stack-1x"><span>{{question['count']}}</span></i>
</span></a>
</div>
</div>
</div>
</p>
</div>
<div ng-if="sections_visible[3]">
<hr/>
<br/><br/>
<h4> Skeleton of the design: </h4>
<blockquote> <p class="newEl">
      The next step in most cases is to come up with the barebone design of your system, both in terms of API and the overall workflow of a read and write request.
      Workflow of read/write request here refers to specifying the important components and how they interact.
      Try to spend around 5 minutes for this section in the interview. <br/>
<b>Important</b> : Try to gather feedback from the interviewer here to indicate if you are headed in the right direction.
    </p>
</blockquote>
</div>
<div class="question-start" ng-repeat="question in sections_shown[3]['questions']">
<p>
<div class="newEl question-text question-background-main" ng-bind-html="renderHtml(question['text'])"></div>
<div ng-if="question['explanation']">
<div class="newEl question-background" ng-repeat="q in question['explanation']['questions']" style="margin-left: 30px">
<div class="container-fluid" style="padding-left: 0; padding-right: 0;">
<div class="col-md-11 question-text" ng-bind-html="renderHtml(q['text'])" style="padding: 0px"></div>
<div class="col-md-1">
<div class="pull-right">
<a href="" ng-click="getComments(q, $event)">
<span class="fa-stack fa-2x comment-icon" style="font-size: 16px;">
<i class="fa fa-comment fa-stack-2x" style="font-size: 2em;"></i>
<i class="fa fa-stack-1x"><span>{{q['count']}}</span></i>
</span></a>
</div>
</div>
</div>
<div class="" ng-bind-html="renderHtml(q['explanation']['text'])" ng-if="q['explanation']"></div>
<div class="" ng-bind-html="renderHtml(q['answer'])" ng-if="q['answer']"></div>
<br/>
</div>
<div class="newEl" ng-bind-html="renderHtml(question['explanation']['text'])" ng-if="question['explanation']['text']"></div>
</div>
<div class="container-fluid question-background-main answer-text" ng-if="question['answer']">
<div class="newEl col-md-11" ng-bind-html="renderHtml(question['answer'])"></div>
<div class="pull-right">
<div class="col-md-1">
<a href="" ng-click="getComments(question, $event)">
<span class="fa-stack fa-2x comment-icon" style="font-size: 16px;">
<i class="fa fa-comment fa-stack-2x" style="font-size: 2em;"></i>
<i class="fa fa-stack-1x"><span>{{question['count']}}</span></i>
</span></a>
</div>
</div>
</div>
</p>
</div>
<div ng-if="sections_visible[4]">
<hr/>
<br/><br/>
<h4> Deep Dive: </h4>
<blockquote> <p class="newEl"> Lets dig deeper into every component one by one. Discussion for this section will take majority of the interview time(20-30 minutes).</p> </blockquote>
</div>
<div class="question-start" ng-repeat="question in sections_shown[4]['questions']">
<p>
<div class="newEl question-text question-background-main" ng-bind-html="renderHtml(question['text'])"></div>
<div ng-if="question['explanation']">
<div class="newEl question-background" ng-repeat="q in question['explanation']['questions']" style="margin-left: 30px">
<div class="container-fluid" style="padding-left: 0; padding-right: 0;">
<div class="col-md-11 question-text" ng-bind-html="renderHtml(q['text'])" style="padding: 0px"></div>
<div class="col-md-1">
<div class="pull-right">
<a href="" ng-click="getComments(q, $event)">
<span class="fa-stack fa-2x comment-icon" style="font-size: 16px;">
<i class="fa fa-comment fa-stack-2x" style="font-size: 2em;"></i>
<i class="fa fa-stack-1x"><span>{{q['count']}}</span></i>
</span></a>
</div>
</div>
</div>
<div class="" ng-bind-html="renderHtml(q['explanation']['text'])" ng-if="q['explanation']"></div>
<div class="" ng-bind-html="renderHtml(q['answer'])" ng-if="q['answer']"></div>
<br/>
</div>
<div class="newEl" ng-bind-html="renderHtml(question['explanation']['text'])" ng-if="question['explanation']['text']"></div>
</div>
<div class="container-fluid question-background-main answer-text" ng-if="question['answer']">
<div class="newEl col-md-11" ng-bind-html="renderHtml(question['answer'])"></div>
<div class="pull-right">
<div class="col-md-1">
<a href="" ng-click="getComments(question, $event)">
<span class="fa-stack fa-2x comment-icon" style="font-size: 16px;">
<i class="fa fa-comment fa-stack-2x" style="font-size: 2em;"></i>
<i class="fa fa-stack-1x"><span>{{question['count']}}</span></i>
</span></a>
</div>
</div>
</div>
</p>
</div>
<div class="newEl" ng-if="sections_visible[5]">
<hr/>
<br/><br/>
<h4> Bonus Exercise : </h4>
</div>
<div class="question-start" ng-repeat="question in sections_shown[5]['questions']">
<p>
<div class="newEl question-text question-background-main" ng-bind-html="renderHtml(question['text'])"></div>
<div ng-if="question['explanation']">
<div class="newEl question-background" ng-repeat="q in question['explanation']['questions']" style="margin-left: 30px">
<div class="container-fluid" style="padding-left: 0; padding-right: 0;">
<div class="col-md-11 question-text" ng-bind-html="renderHtml(q['text'])" style="padding: 0px"></div>
<div class="col-md-1">
<div class="pull-right">
<a href="" ng-click="getComments(q, $event)">
<span class="fa-stack fa-2x comment-icon" style="font-size: 16px;">
<i class="fa fa-comment fa-stack-2x" style="font-size: 2em;"></i>
<i class="fa fa-stack-1x"><span>{{q['count']}}</span></i>
</span></a>
</div>
</div>
</div>
<div class="" ng-bind-html="renderHtml(q['explanation']['text'])" ng-if="q['explanation']"></div>
<div class="" ng-bind-html="renderHtml(q['answer'])" ng-if="q['answer']"></div>
<br/>
</div>
<div class="newEl" ng-bind-html="renderHtml(question['explanation']['text'])" ng-if="question['explanation']['text']"></div>
</div>
<div class="container-fluid question-background-main answer-text" ng-if="question['answer']">
<div class="newEl col-md-11" ng-bind-html="renderHtml(question['answer'])"></div>
<div class="pull-right">
<div class="col-md-1">
<a href="" ng-click="getComments(question, $event)">
<span class="fa-stack fa-2x comment-icon" style="font-size: 16px;">
<i class="fa fa-comment fa-stack-2x" style="font-size: 2em;"></i>
<i class="fa fa-stack-1x"><span>{{question['count']}}</span></i>
</span></a>
</div>
</div>
</div>
</p>
</div>
<div align="center" style="margin-top: 12px;">
<span ng-if="encouragement_text">
<i>{{encouragement_text}}</i>
<br/>
</span>
<button class="btn bookmark-btn btn-sm btn-success" data-ng-click="submit('explain')" id="explain-btn" ng-if="show_explain_button" type="button">{{explain_button_text}}</button>
<button class="btn bookmark-btn btn-sm btn-info" data-ng-click="submit(next_button)" id="next-btn" ng-if="show_next_button" type="button">{{next_button_text}}</button>
<br/>
<br/>
</div>
<div align="center" class="newEl" data-target="#sign-up-modal" data-toggle="modal" id="problem_finished" style="display: none; cursor: pointer;">
<span class="fa" ng-if="!demo_loggedin_view" style="font-size: larger;">
          Sign up to view the complete problem.
        </span>
<span class="fa" ng-if="demo_loggedin_view" style="font-size: larger;">
<i class="fa fa-trophy" style="font-size: larger;"></i> You have now mastered this problem!
        <br>
        Sign up to practice more.
        </br></span>
</div>
</div>
</div>