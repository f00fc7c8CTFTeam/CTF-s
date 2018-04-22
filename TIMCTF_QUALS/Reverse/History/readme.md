---
layout:       post
title:       Timisoara CTF QUALS
date:        20 April 2018
comments:    true
categories:  RE
auteur:      f00fc7c8
---

===== INFOS ===== 

Filename:                 attendance

File format:              ELF32

Architecture:             x86

Author:                   0xcpu 

===== Info =======

Hey buddy, today at our history lesson a guy from some sort of consortium came
to speak about some standard... it was soooo boring, that at some time I fell asleep,
but I used my audio recorder program to take some notes about his speech.
Unfortunately there's a sentence missing (a bug?). Can you help?
===== End of Info ======

====== Solve ========

We just took the executable, run it with ida and the flag was:
