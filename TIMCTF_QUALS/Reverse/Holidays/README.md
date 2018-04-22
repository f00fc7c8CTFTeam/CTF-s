---
layout:      post
title:       Timisoara CTF QUALS
date:        20 Avril 2018
comments:    true
categories:  RE
auteur:      f00fc7c8
---

===== INFOS ===== 
Filename                 holidays
File format              PE32
Architecture             x86
Author                   Tzeny 

===== Info =======
The summer vacation is coming! Can you get your flag before it arrives?
===== End of Info ======


===== HINTS =========
http://lmgtfy.com/?q=romanian+school+summer+holidays

====== Solve ========

We took the executable run it in dotPeek(https://www.jetbrains.com/decompiler/) and we wore presented with the following referenced in decompile.cs
We then modified the variable password with the date that the summer school vacantion starts in romania, in timestamp format and we get the flag back:
