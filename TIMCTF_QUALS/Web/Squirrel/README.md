---
layout:      post
title:       Timisoara CTF QUALS
date:        20 Avril 2018
comments:    true
categories:  Web
auteur:      p4N1CK
---

===== Info =======

Is this the final version?

===== End of Info =======

======== Solve ========

This one was hell of a challenge. But in the end we did it, yay!. At first, we tought of another version of the [web page](http://squirrelsold.woodlandhighschool.xyz/)
but we couldn't figure out what or where that version was supposed to be. Then, a quick though came into my mind, versions has to do with Github right, like a Github server?. There wasn't any hint either so i just did a research and after a lot of searching i found this [link](https://stackoverflow.com/questions/2304087/what-is-head-in-git) which gave me a start point. So after reading that, i just added ```.git/HEAD``` to the main link and it would result in this ```http://squirrels.woodlandhighschool.xyz/.git/HEAD```, i was hoping to get the current branch, thing which happened by the way. After I've got the current branch, i found another URL extension from the file i've just been gived: ```refs/heads/master```, which, well, i added as well to the main link -> ```http://squirrels.woodlandhighschool.xyz/.git/refs/heads/master```. Now this was another problem, i didn't know what to do from here.
Again, after some research, i fount this [link](https://git-scm.com/book/en/v2/Git-Basics-Working-with-Remotes) which helped me with getting the "OTHER VERSION" of this website where the flag was waiting to be revealed:

```timctf{g1t_w1z4rd_1n_w00dl4and_highsch00l}```
