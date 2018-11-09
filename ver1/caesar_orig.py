import string

#a = input("input : ")
a= "Ha keresunk valamit, sose talaljuk meg. Akkor talaljuk meg, amikor nem keressuk. Gayle Forman"
#I9	jfqfrvml~w9m9nhu+	rprf~u9m9mivj	lff/~Bjlns~u9m9mivj	lff-~bljjpq	mfl	jfqfrttl-	Fbxmd	Epqn9o

db = string.ascii_letters
b=""
a_chars = list(a)
#print(db)
c=1
for i in range(0, len(a_chars)):
	db_index=db.index(a_chars[i])
	b+=db[db_index+(c)]
	c=c*-1
print(b)
