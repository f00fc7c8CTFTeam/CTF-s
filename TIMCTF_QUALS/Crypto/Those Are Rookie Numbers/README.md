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

I combined these and i have got the script which got me the flag:

```Python

def int2Text(number, size):
    text = "".join([chr((number >> j) & 0xff)
                    for j in reversed(range(0, size << 3, 8))])
    return text.lstrip("\x00")
def egcd(a, b):
    if a == 0:
        return (b, 0, 1)
    else:
        g, y, x = egcd(b % a, a)
        return (g, x - (b // a) * y, y)
def modinv(a, m):
    g, x, y = egcd(a, m)
    if g != 1:
        raise Exception('modular inverse does not exist')
    else:
        return x % m
p = 176773485669509339371361332756951225661
q = 333197218785800427026869958933009188427
e = 65537
c = 56191946659070299323432594589209132754159316947267240359739328886944131258862
phi = (p-1) * (q-1)
d = modinv(e, phi)
print(d)
n = p * q
m_int = pow(c, d, n)
print(int2Text(m_int, len(str(m_int))))
```

And the flag is:
```
timctf{th0sE_rOoKIe_numB3rz}
```
