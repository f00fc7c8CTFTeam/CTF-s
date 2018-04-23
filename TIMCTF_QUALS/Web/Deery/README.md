---
layout:      post
title:       Timisoara CTF QUALS
date:        20 Avril 2018
comments:    true
categories:  Web
auteur:      p4N1CK
---

===== Info =======

///\\\

===== End of Info =======

======== Solve ========

First, I noticed there is a JS script that won't let me do anything on the site. I deactivated the JS from the site, altough in the end wasn't necessary. This lead me however, to Inspect Element (of course that's the first thing you do on a challenge of this type) and I looked down where i saw this in a portion of the html index file:

```
<div class="ui vertical stripe segment">
    <div class="ui text container">
      <h3 class="ui header">Now our Critter Christmas can finally happen!</h3>
      <p>People stood in long lines, sometimes waiting for hours or more, because Christmas needs to be bought in a store</p>
      <a class="ui large button">Read More</a>
      <h4 class="ui horizontal header divider">
        <a href="homepage.html#">Case Studies</a>
      </h4>
      <h3 class="ui header">Well, good going, Stupid!</h3>
      <p>I don't believe anybody interrupted you when you read your Christmas story aloud, Kyle</p>
      <a class="ui large button">I'm Still Quite Interested</a>
    </div>
  </div>


  <!-- keep looking... -->
  <div class="ui inverted vertical footer segment">
    <div class="ui container">
      <div class="ui stackable inverted divided equal height stackable grid">
        <div class="three wide column">
          <h4 class="ui inverted header">About</h4>
          <div class="ui inverted link list">
            <a href="homepage.html#" class="item">Sitemap</a>
            <a href="homepage.html#" class="item">Contact Us</a>
            <a href="homepage.html#" class="item">Religious Ceremonies</a>
            <a href="homepage.html#" class="item">Gazebo Plans</a>
          </div>
        </div>
        <div class="three wide column">
          <h4 class="ui inverted header">Services</h4>
          <div class="ui inverted link list">
            <a href="homepage.html#" class="item">Banana Pre-Order</a>
            <a href="homepage.html#" class="item">DNA FAQ</a>
            <a href="homepage.html#" class="item">How To Access</a>
            <a href="homepage.html#" class="item">Favorite X-Men</a>
          </div>
        </div>
        <div class="seven wide column">
          <h4 class="ui inverted header">Footer Header</h4>
          <p>Hi there! I'm glad that you look in here!</p>
        </div>
      </div>
    </div>
```
Which, if you look carefully, says ```<!-- keep looking... -->```



