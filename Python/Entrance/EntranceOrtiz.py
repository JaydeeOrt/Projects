from multiprocessing import Value
import time,os,openpyxl
from tkinter import END



#sets directory
os.chdir("C:\\Users\\Jaydee\\Documents\\SummerPrograms\\PythonClass\\EntranceOrtiz")
#opens workbook as variable
wb = openpyxl.load_workbook("Entrance Test Scores.xlsx")
#variable for Excel tab
sheet = wb["Sheet1"]
#print(sheet["a1"].value)
#print(sheet.max_row)
#print(sheet.max_column)



userScore = ""
#gathers the Acronyms from the excel sheet
oldAcronyms = []
for i in range(3,sheet.max_row+1):
    oldAcronyms.append(sheet.cell(row = i,column =2).value)



#dictionary of changed datatels and the new algebra scores
updated_data = { }
userScore = input("Will you be changeing Writing(W), Reading(R), Pre Algebra(PRA), or Algebra(A) please enter one: ")
#asks user for number of scores going to be changes
changes = int(input("How many changes will you be making?: "))
#loop for entering new stuff into dictionary
for i in range(changes):
    #gets the keys and values
    name=input("Enter datatel acronym: ").upper()
    score=int(input("Enter new score: "))
    updated_data[name] = score



#user input validation
for i in updated_data:
    if i in oldAcronyms:
        print()
    else:
        print("Sorry f{i} is an Incorect Acronym try again!")
        exit()



#Loop to check the rows for the datatel that is going to be changed
for rowNum in range(3,sheet.max_row +1):
    datatel = sheet.cell(row = rowNum, column = 2).value
    #check if datatel
    if datatel in updated_data:
        if userScore.upper() == 'W':
            #updates to add the new writing score
            sheet.cell(row = rowNum, column = 3).value = updated_data[datatel]

        elif userScore.upper() == 'R':
            #updates to add the new reading score
            sheet.cell(row = rowNum, column = 4).value = updated_data[datatel]

        elif userScore.upper() == 'PRA':
            #updates to add the new pre algebra score
            sheet.cell(row = rowNum, column = 5).value = updated_data[datatel]

        elif userScore.upper() == 'A':
            #updates to add the new algebra score
            sheet.cell(row = rowNum, column = 6).value = updated_data[datatel]
        else:
            print("Incorrect Score category")
            


time.sleep(5)
print("Updated save created \n Thank You!")
#saves a new Excel Workbook
wb.save("Updated Entrance Test Scores.xlsx")