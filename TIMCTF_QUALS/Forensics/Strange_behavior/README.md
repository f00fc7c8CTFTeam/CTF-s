---
layout:      post
title:       Timisoara CTF QUALS
date:        20 Avril 2018
comments:    true
categories:  Forensics
auteur:      f00fc7c8
---

===== INFOS ===== 

Filename                 unirii_square

File format              bin

Architecture             x86/x64

Author                   0xcpu 

===== Info =======

```
 Our physics teacher at every lesson is occupied with something, quite strange.
Most of the time he's not teaching us anything, just having fun with something else.
We've stolen something from him, now lets see what is he doing!
```

===== End of Info ======


====== Solve ========

We used binwalk -e to etratraxtract the files from the challenge, then we looked for the flag into the files, and we found it into an xml file.

Flag: ```timctf{d0nt_f0rg3t_t0_h4v3_fun}```, the flag was in sharedStrings.xml
