import string
q=[]
#a = input("input : ")
with open("q.txt","r") as f:
	for line in f:
		q.append(line)
#a= "Ha keresunk valamit, sose talaljuk meg. Akkor talaljuk meg, amikor nem keressuk. Gayle Forman"
#a="IZ jfqfrvml wZmZnhu, rprf uZmZmivj lff. Bjlns uZmZmivj lff, bljjpq mfl jfqfrttl. Fbxmd EpqnZo"
db = string.ascii_letters
b=""
#print(db)

def encrypt(a):
	b=""
	c = -1
	a_chars = list(a)
	for i in range(0, len(a_chars)):
		if a_chars[i] in db:
			db_index=db.index(a_chars[i])
			if db_index+c==len(db):
				b += db[0]
			else:
				b+=db[db_index+(c)]
		else:
			b +=a_chars[i]
		c=c*-1
	return b

def dencrypt(a):
	b=""
	c = 1
	a_chars = list(a)
	for i in range(0, len(a_chars)):
		if a_chars[i] in db:
			db_index=db.index(a_chars[i])
			if db_index+c==len(db):
				b += db[0]
			else:
				b+=db[db_index+(c)]
		else:
			b +=a_chars[i]
		c=c*-1
	return b

e=[]
for i in range(0,len(q)):
	a = q[i]
	b=encrypt(a)
	e.append(b)
	print(b)
with open("e.txt","a") as f:
	for i in range(0,len(e)):
		f.write(e[i])
'''
for i in range(0,len(e)):
	a=e[i]
	b=dencrypt(a)
	print(b)
'''
