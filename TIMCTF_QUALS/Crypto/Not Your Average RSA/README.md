---
layout:      post
title:       Timisoara CTF QUALS
date:        20 Avril 2018
comments:    true
categories:  Crypto
auteur:      P4UL
---

===== Info =======

```Somebody told me this RSA factoring is MP complete... or was it NP?```

===== End of Info ======


======== Solve ========

This was a little bit difficult because of the big number! Damn hell of a number. We knew it was Multi Prime RSA, like A LOT of primes, oh we found out
with this tool called [yafu](https://github.com/DarkenCode/yafu) (God bless u dude!). here are the primes:

```
p1 = 27289543
p2 = 27409927
p3 = 33322589
p4 = 17730961
p5 = 27138691
p6 = 22576643
p7 = 27606707
p8 = 21647243
p9 = 18313601
p10 = 23554169
p11 = 24525821
p12 = 31703933
p13 = 25671797
p14 = 24996157
p15 = 27739163
p16 = 20013121
p17 = 17673199
p18 = 29488469
p19 = 30580789
p20 = 21321539
p21 = 31881917
p22 = 25808239
p23 = 22685197
p24 = 30342329
p25 = 24946057
p26 = 16904777
p27 = 18646361
p28 = 19459483
p29 = 31696261
p30 = 22050221
p31 = 20010041
p32 = 25963459
p33 = 20197313
p34 = 21891889
p35 = 33098557
p36 = 31737131
p37 = 29511773
p38 = 28863719
p39 = 20390129
p40 = 17901463
p41 = 18145913
p42 = 33381329
```
