#!/usr/local/bin/python
# coding: latin-1
from modulefinder import packagePathMap
import os, sys
import random
from datetime import datetime, timedelta
from struct import pack

# Prompt the user to input the number of days they want to calculate

day = int(input("\n\tIngrese el numero de dias que desea calcular: "))
second = day * 86400 # Calculate the number of seconds in the number of days entered by the user
print("\n\tHay", second, "segundos en", day, "d�as.") # Print the number of seconds in the number of days entered
# Wait for the user to press enter to continue
input("\n\tPresiona Enter para continuar...")
# Ask the user if they're ready to calculate their age
print('\n\tAhora menciona cuanto tiempo has vivido a partir de tu fecha de nacimiento. ¿Preparado?.')
# Clear the console
os.system("cls")

def calculate_age(date_of_birth):
    today = datetime.now()
    age = today - date_of_birth
    return age

date_of_birth = input("\n\tIngresa tu fecha de nacimiento en el formato (dd-mm-yyyy): ")
date_of_birth = datetime.strptime(date_of_birth, "%d-%m-%Y")

age = calculate_age(date_of_birth)
days, seconds = age.days, age.seconds

minutes = seconds / 60
hours = minutes / 60
days = days + (hours / 24)
years = days / 365

print("\n\tTienes aproximadamente:")
print("\n\t{} a�os".format(int(years)))
print("\n\t{} dias".format(int(days)))
print("\n\t{} horas".format(int(hours)))
print("\n\t{} minutos".format(int(minutes)))

input('\n\tAhora generar� frases aleatorias para t�. �Preparado?.')
os.system("cls")


nouns = ["perro", "gato", "casa", "�rbol", "ciudad", "cient�fico", "experimento"]
verbs = ["corre", "salta", "canta", "vuela", "nada", "descubre", "analiza", "estudia"]
adjectives = ["grande", "peque�o", "hermoso", "r�pido", "feliz", "loco", "efusivo"]

def generate_phrase():
    phrase = "\n\t" + " " + random.choice(adjectives) + " " + random.choice(nouns) + " " + random.choice(verbs) + "."
    return phrase

print("\n\t�Bienvenido al generador de frases creativas!")
while True:
    input("\n\tPresiona Enter para generar una frase.")
    print(generate_phrase())

generate_phrase()