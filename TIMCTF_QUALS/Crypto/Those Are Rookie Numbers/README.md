---
layout:      post
title:       Timisoara CTF QUALS
date:        20 Avril 2018
comments:    true
categories:  Crypto
auteur:      p4N1CK
---

===== Info =======

I overheard a discussion about whether the size really matters. What does this have to do with RSA?

===== End of Info ======

We were given the following:

```
n = 58900433780152059829684181006276669633073820320761216330291745734792546625247
e = 65537
c = 56191946659070299323432594589209132754159316947267240359739328886944131258862
```

First, i used [factordb.com](factordb.com), i factorised n which gave me the following factors:

```
p = 176773485669509339371361332756951225661
q = 333197218785800427026869958933009188427
```
And then i found something to use at:
[RSA Implementation in Python](http://jhafranco.com/2012/01/29/rsa-implementation-in-python/)

[Modular Multiplicative Inverse Function in Python](http://stackoverflow.com/questions/4798654/modular-multiplicative-inverse-function-in-python)
