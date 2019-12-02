#!/usr/bin/python3

import random

#Functions of fibonacci
def fibo1(number):
	a=1
	b=1	
	print(a)
	print(b)
	for i in range(3, number+1, 1):
		f= a+b
		a= b
		b= f
		print(f)

def fibo2(number):
	if number < 2:
		return 1;
	return fibo2(number-1) + fibo2(number-2)		


def add_the_numbers(start, end, step):
	total = 0
	for i in range(start, end+ step, step):
		total+= i
	print(total)

'''
INPUT 
start = int(input("Desde donde quiere empezar: "))
end = int(input("Hasta que numero: "))
step = int(input("Cuantos pasos: "))
add_the_numbers(start, end, step)
'''

'''
FIBONACCI EXERCISE
n =  int(input("Number of Fibonacci: "))
#fibo1(n)
for i in range(0, n, 1):
        print(fibo2(i));
'''

'''
PROBABILITY OF 2 DICE
cont = 0
for i in range(0, 1000, 1):
	two_dice = random.randint(0, 6) + random.randint(0, 6)
	cont += two_dice

print(cont / 1000)
'''
'''
numero_columnas = 5
numero_filas = 5

matriz = [range(numero_columnas) for i in range(numero_filas)]

for i in range(len(matriz)):
	for j in range(len(matriz[i])):
		if j == 0:
			matriz[i][j]= 
'''
'''
for i in range(len(matriz)):
	for j in range(len(matriz[i])):
		print(matriz[i][j], end=' ')
    print()	
'''

'''
for i in range (1,100):
	print("  %6d  %6d  %6d  " %(i, i*i, i*i*i))
'''

