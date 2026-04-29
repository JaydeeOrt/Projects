import time
#Dictionary containing menu items and prices
menu = {"specialty donut": 1.50, "bagel": 3.15, "croissant": 2.98, "english Muffin": 1.75, "coffee": 2.99,"juice": 1.99}
#function displaying menu items
def menuDisplay():
    print("**********\tSpecialty Donut\t\t**********")
    print("**********\tBagel\t\t\t**********")
    print("**********\tCroissant\t\t**********")
    print("**********\tEnglish Muffin\t\t**********")
    print("**********\tCoffee\t\t\t**********")
    print("**********\tJuice\t\t\t**********")

userInput = 'Y'
while userInput.upper() == 'Y':
    #Calls function
    menuDisplay()
    #declaring new list
    totalOrder = []

    userChoice = 'Y'
    while userChoice.upper() == 'Y':
        menuItem = input("\nEnter menu item your buying: ")
        #if to check if item entered is in the dictionary
        if menuItem.lower() in menu:
            print (f'{menuItem} will cost ${menu[menuItem.lower()]:.2f}')
            amount = int(input("\nEnter how many you would like to buy: "))
            subtotal = menu[menuItem.lower()]*amount
            totalOrder.append(subtotal)
        else:
            print("We dont currently carry that item.")
        userChoice = input("\nWould you like to purchase another item?(Y/N): ")
        #endif
    #end iner while loop
    #Calculates Taxes
    total = sum(totalOrder)
    tax = total *0.09
    total = total + tax

    print(f"\nYour total cost is $ {total:.2f}")
    
    time.sleep(2)

    userInput = input("\nDo you wish to continue?(Y/N): ")
#end of outer loop    
print("\n\nThank You!")
time.sleep(5)