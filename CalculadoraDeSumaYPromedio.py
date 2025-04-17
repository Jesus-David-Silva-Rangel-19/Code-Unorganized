# start of the program
# Number list
numbers = list(input('Enter a list of numbers separated by a space: ').split())
# Convert the string list to an integer list
numbers = [int(i) for i in numbers]
# calculate the sum of the numbers
sumlist = sum(numbers)
# calculate the average of te list number
averagelist = sumlist / len(numbers)
# print the sum of the numbers
print('The sum of the numbers is:', sumlist)
# print the average of the numbers
print('The average of the numbers is:', averagelist)
# print the acknowledgement
print('Thanks you for your feedback!')
# End of the program