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
27289543
27409927
33322589
17730961
27138691
22576643
27606707
21647243
18313601
23554169
24525821
31703933
25671797
24996157
27739163
20013121
17673199
29488469
30580789
21321539
31881917
25808239
22685197
30342329
24946057
16904777
18646361
19459483
31696261
22050221
20010041
25963459
20197313
21891889
33098557
31737131
29511773
28863719
20390129
17901463
18145913
33381329
```
We used this [algorithm](https://crypto.stackexchange.com/questions/31109/rsa-enc-decryption-with-multiple-prime-modulus-using-crt) here, which was the most voted one and was what we needed.
We got the flag!

```timctf{mUlt1_PriM3_rS4_c0ULD_B3_DAngEr0us}```
