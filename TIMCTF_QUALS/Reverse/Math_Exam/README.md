---
layout:      post
title:       Timisoara CTF QUALS
date:        20 Avril 2018
comments:    true
categories:  Forensics
auteur:      f00fc7c8
---

===== INFOS ===== 

Filename                 math_exam

File format              elf

Architecture             x64

Author                   0xcpu 

===== Info =======

Ok, dear students. We've studied a lot of math, many advanced concepts
are already conquered, I think you're ready to go further. But, a
wayfarer should not forget where he comes from, right?
Do you remember your origins?

===== End of Info ======


====== Solve ========

upon runing objdump -D math_exam we see that the password is check in 5 parts of the algorithm, and that we have to reconstruct the flag.

After some time of trial and error we got the flag: timctf{Euclid_w0uld_b3_pr0ud}
