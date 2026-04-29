import time

#defined tuition cost
costperHour = 198

#Gets Users name
name = input("What is your Name(First and last): ")
print()

#Gets Users Credit Hours
creditHours = int(input("How many total credit hours do you plan on taking: "))
print()

#calcualtes tuition cost
price = costperHour * creditHours

#Outputs to the user their tuition cost
print("Hello " + name + " your tuition cost will be $" + format(price,',.2f') + ".")
print("Thank you!")

#Pauses for 5 seconds before ending
time.sleep(5)