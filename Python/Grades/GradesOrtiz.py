import time
userChoice = 'Y'
#loop start
while userChoice.upper() == 'Y':

    #userinputs
    name = input("What is the students name: ")
    quizz = input("What are your quizz grades(Seperated by space): ").split()
    project = float(input("What is the final project grade: "))
    examGrade = float(input("What is the final exam grade: "))
    #Map to change all items in list to ints 
    quizz = list(map(int, quizz))

    #calculating grades
    fQuizz = sum(quizz) / len(quizz)
    finalQuizz = fQuizz * 0.5
    finalProject = project * 0.3
    finalExamGrade = examGrade *0.2
    finalGrade = finalQuizz+ finalProject + finalExamGrade
    

    #Writing a file into 
    with open(name + " Grade Report","w") as file:
        file.write("Central Community College")
        file.write("\nCPT Advanced Python Programming")
        file.write("\nGrade report for " + name)
        file.write(f"\nQuiz Average:\t\t {fQuizz:.2f}")
        file.write(f"\nFinal Project:\t\t {project:.2f}")
        file.write(f"\nFinal Exam:\t\t {examGrade:.2f}")
        file.write(f"\nFinal grade:\t\t {finalGrade:.2f}")
    
    userChoice = input("\nWould you like to do another report?(Y/N) ")
    print()
#End of loop and asking user if they want to loop
print("Thank You!")
#End
time.sleep(2)