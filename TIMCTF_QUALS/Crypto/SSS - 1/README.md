---
layout:      post
title:       Timisoara CTF QUALS
date:        20 Avril 2018
comments:    true
categories:  Crypto
auteur:      crypt0
---

===== Info =======

```
3 math teachers agreed to a common secret password to access the exam answers. Luckily, one of them lost a note that seems related. They also talk all the time about some guy named Lagrange.

NOTE: the coordinates are: 

4612c90f5d8cd5d616193257336d92af1f66df92443b4ee69f5c885f0173ad80113844e393d194e3 

8c25921e46b03e48b7cbe94c3267f41adf618abd16422f660b59df6fae81e8aff2242852be33db49 

d2385b2d2fd3a6bb597ea041316255869f5c35e7e8490fe5775736805b9023dfd3100bc1e89621af
```

===== End of Info ======

======== Solve ========

I converted the numbers from hex to dec, after that i used this [tool](https://www.dcode.fr/lagrange-interpolating-polynomial), after many tries i realised the flag is going to be given by only 2 out of the numbers just like the ```b``` element from the equation ```f(x) = ax+b``` after that we convertet it from dec to hex, and from hex to text. Voilla there was the flag!

```timctf{b4s1C_l4gr4ng3_1NTerP0LatioN}```
