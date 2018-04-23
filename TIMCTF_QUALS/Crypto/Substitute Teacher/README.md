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

So we have a long, Long, LONG text (Which was actually the Da Vinci's Code book which is awesome btw). It is enciphered. After a bit of research I found out this was substitute cipher. Got some information from here: [Substitute cipher](https://en.wikipedia.org/wiki/Substitution_cipher)

So it began a long way to decipher the text, so I can get the key which is:

```
kufxbhaoiyqtmnezwgscdpljrv
```
Aaand after that, i used [this site](https://www.guballa.de/substitution-solver) to decipher where i also got the flag:

```
timctf{fr3quencyan4lyS1s1sc0ol}
```


