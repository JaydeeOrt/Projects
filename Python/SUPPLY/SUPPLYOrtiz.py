import time
#defined variables
trioSale = 0
userInput = "Y"

#Made function to display The supplies and chose supplies
def supplyKit(userInput):
    #defined Variable
    cart = 0
    while userInput.upper() == "Y":
        #Prints list of Supply kits being sold at the Library
        print("#1 Mechatronics kit\t$299")
        print("#2 Nursing kit\t\t$99")
        print("#3 Welding kit\t\t$699")
        print("#4 Multimeter\t\t$199")
        print("#5 Culinary kit\t\t$250")

        kit = int(input("\nEnter number for kit you would like(1-5): "))

        #Gives price to users kit
        if kit == 1:
            cart = cart + 299
        elif kit == 2:
            cart = cart + 99
        elif kit == 3:
            cart = cart + 699
        elif kit == 4:
            cart = cart + 199
        elif kit == 5:
            cart = cart + 250
        else:
            print("Error try again\n")
            continue
        #End If
        userInput = input("Would you like to pick another?(Y/N): ")
    return cart



#loops
while userInput.upper() == "Y":
    name = input("What is your Name: ")
    cart= supplyKit(userInput)
    print(cart)
    trioStatus = input("Do you have TRIO?(Y/N): ")

    #calculates Costs with and without TRIO
    if trioStatus.upper() == "Y":
        cart = cart * 0.5

        tax = cart * 0.07
        totalCost = cart - tax
    else:
        tax = cart * 0.07
        totalCost = cart - tax
    #end If

    #Outputs to user
    print("\n" + name + " your total will be: $" + format(totalCost,'.2f'))

    #asks user if they want to enter another person
    userInput = input("\nWould you like to enter another student?(Y/N): ")
#End Loop

#Outputs thank you message
print("\nThank you!")
#Pauses for 5 seconds
time.sleep(5)
