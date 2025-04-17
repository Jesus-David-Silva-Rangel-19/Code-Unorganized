# number list
#list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
# average number
#average = sum(list) / len(list)
#print("The average of the list is: ", average)


# number list digit for user
#list = []
#n = int(input())

# functional program
try:
    n = input()
    number_list = [int(n) for n in n.split()]
    average = sum(number_list) / len(number_list)  
    averageround = round(average, 2)
    print(averageround)

except ValueError:
    print("Error: Asegurate de ingresar numeros validos.")