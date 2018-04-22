b = bytearray(open('unirii_square.jpg', 'rb').read())
for i in range(len(b)):
    b[i] ^= 171
open('unirii_square2.jpg', 'wb').write(b)
