#!/usr/bin/python3

class Travel:
    def __init__(self, country, destination, month, grade):
        self.country = country
        self.destination = destination
        self.month = month
        self.grade = grade
    
    def myfunc(travel):
	    print("Hello im travelling to " + travel.destination +" on "+travel.month +" Grade:",+travel.grade)

i = []
t1 = Travel("november", "prague", "Czech Republic", 9)
t1.myfunc() 
i.append(t1)

t2 = Travel("november", "Lviv", "Ucraine", 7)
t2.myfunc()
i.append(t2)

t3 = Travel("October", "Warsawa", "Poland", 10)
t3.myfunc()
i.append(t3)

t4 = Travel("October", "Lublin", "Poland", 6)
t4.myfunc()
i.append(t4)
print()

cont = 0
for x in i:
    cont = cont + x.grade
print(cont/len(i))


def add(n, z, x):
    return n + z + x









