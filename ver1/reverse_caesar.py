import string

#a = input("input : ")
#a= "Ha keresunk valamit, sose talaljuk meg. Akkor talaljuk meg, amikor nem keressuk. Gayle Forman"
a="IZ jfqfrvml wZmZnhu, rprf uZmZmivj lff. Bjlns uZmZmivj lff, bljjpq mfl jfqfrttl. Fbxmd EpqnZo"
db = string.ascii_letters
b=""
a_chars = list(a)
c=-1
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
print(b)
