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

File format              jpeg

Architecture             x86/x64

Author                   0xcpu 

===== Info =======

 I've heard you're an abstract art connoisseur. Now look at this, isn't it beautiful?
 
===== End of Info ======


====== Solve ========

From the name of the challenge we realized that the picture is XOR and using the script which we found on stackoverflow(https://stackoverflow.com/questions/5037762/xor-each-byte-with-0x71) we get the flag which is in unirii_square_xor_decoded.jpg
