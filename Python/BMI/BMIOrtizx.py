import time


userAnswer = 'Y'
while userAnswer.upper() == 'Y': #start of my while loop
    #Getting Variables
    height = float(input("\nPlease enter your height (in inches): "))
    weight = float(input("Please enter your weight(in pounds): "))

    #Calculations
    bmi = float((weight / (height**2))*703)
    weightStatus = " "

    #Bmi if statement
    if bmi >= 30.0:
        weightStatus ="Obese"
    elif bmi >= 25.0:
        weightStatus ="Overweight"
    elif bmi >= 18.5:
        weightStatus ="Normal"
    else:
        weightStatus ="Underweight"
    #End If

    print("\nYou are in the weight range of " + weightStatus)
    userAnswer = input("Would you like to enter another?(Y/N) ")
#5 second pause
time.sleep(5)