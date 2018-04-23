---
layout:      post
title:       Timisoara CTF QUALS
date:        20 Avril 2018
comments:    true
categories:  Crypto
auteur:      p4N1CK
---
===== Info =======

///\\\

===== End of Info ======

======== Solve ========

```
hsijhk{Pc3nvO_R4NvwM_1S_Nwh_RArD0M}
```
Ok so when i first saw this, i guessed that this is the flag and then i analysed the entire thing, an with some trial end error, i found out that the first word is "pseudo". The rest of it was obvious.
Also the script for this is:

```python
import random

alpha = "abcdefghijklmnopqrstuvwxyz"
key = ''.join(random.sample(alpha,len(alpha)))
print(key)
assert(len(alpha) == 26)

plaintext = open("plaintext.txt").read()
ciphertext = ""

sub_dict = {}

for i in range(len(alpha)):
    sub_dict[alpha[i]] = key[i]

for i in range(len(plaintext)):
    if plaintext[i] in alpha:
        ciphertext += sub_dict[plaintext[i]]
    else:
        ciphertext += plaintext[i]

open("ciphertext.txt", "w").write(ciphertext)
```

After all of this, i just replaced the unwanted letters with letters from the alphabet and it gave me the flag:

```
timctf{Ps3udO_R4NdoM_1S_Not_RAnD0M}
```
