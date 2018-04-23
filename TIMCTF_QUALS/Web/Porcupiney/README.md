---
layout:      post
title:       Timisoara CTF QUALS
date:        20 Avril 2018
comments:    true
categories:  Web
auteur:      f00fc7c8
---

===== Info =======

///\\\

===== End of Info =======

======== Solve ========

Well, first, the challenge is about security, right? Security on a website could lead to ```SSL Certificate```, which in this case is our key to the flag. I check it, then i watch at the dns we have seen. A different dns address we input it make request with browser than we do the same step at the following address: ```https://nonononono.woodlandhighschool.xyz/``` and at the bottom we see the flag:


```
timctf{w00dl4nd_cr1tt3rs_s3cur3_chr1stm4s}
```
