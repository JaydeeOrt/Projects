from datetime import date
from datetime import time
from datetime import datetime
import pyinputplus as pyip

userChoice = 'Y'

print("\t\tThe Grand Hotel Reservation System\n")
while userChoice.upper() == 'Y':
    #gets user arrival and departure time
    arrival = input("Enter arrival date (YYYY-MM-DD): ")
    departure = input("Enter departure date (YYYY-MM-DD): ")

    #formats user input
    arrivalTime = datetime.strptime(arrival,'%Y-%m-%d')
    departureTime = datetime.strptime(departure,'%Y-%m-%d')


    #prints arrival &departure time
    print(f"\nArrival Date:\t\t{arrivalTime:%B %d, %Y}")
    print(f"Departure Date:\t\t{departureTime:%B %d, %Y}")

    #check if the arrival is in june
    if arrivalTime.month == 6:
        rate = 325.00
        print(f"Nightly rate:\t\t${rate:.2f} (Peak Season")
    else:
        rate = 250.00
        print(f"Nightly rate:\t\t${rate:.2f}")

    #calculates nights
    nights = departureTime - arrivalTime
    nights = nights.days
    print(f"Total nights:\t\t{nights}")
    #calculates rates
    price = rate * nights
    print(f"Total price:\t\t${price:,.2f}")


    #Check if user wants to loop/ make another reservation
    userChoice = input("Would you like to make another reservation(Y/N)?: ")
    print()
print("Thank you!\n")
