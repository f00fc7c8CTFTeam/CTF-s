#!/usr/bin/python2
# credit : http://jhafranco.com/2012/01/29/rsa-implementation-in-python/
def int2Text(number, size):
    text = "".join([chr((number >> j) & 0xff)
                    for j in reversed(range(0, size << 3, 8))])
    return text.lstrip("\x00")
# credit : http://stackoverflow.com/questions/4798654/modular-multiplicative-inverse-function-in-python
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
n = p * q
m_int = pow(c, d, n)
print(int2Text(m_int, len(str(m_int))))