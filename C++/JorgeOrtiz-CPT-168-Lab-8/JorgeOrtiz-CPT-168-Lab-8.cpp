// JorgeOrtiz-CPT-168-Lab-8.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main()
{
	//declare variable
	string celeb[6] = { "Angelina Jolie","Brad Pitt","Margot Robbie","George Clooney","Jennifer Lopez","Jennifer Lawrence" };
	string phoneNumber[6] = {"949-232-1124","949-865-3492","864-235-7569","939-453-2288","987-209-2132","543-239-8745"};
	int userInput = 0;
	char userChoice = 'Y';//Priming read 🤓

	//LoopStart
	while (toupper(userChoice)== 'Y')
	{
		//My information
		cout << "\t\t****************" << endl;
		cout << "\t\t* Jorge  Ortiz *" << endl;
		cout << "\t\t* CPT-168-A01S *" << endl;
		cout << "\t\t*    Lab-8     *" << endl;
		cout << "\t\t****************" << endl;
		
		//user input
		cout << "Enter a number from 1 to 6 to display an actor's information: ";
		cin >> userInput;

		//Validate user input
		if (userInput > 0 && userInput < 7)
		{
			cout << "The actors name is: " << celeb[userInput - 1] << endl << "Phone number is: " << phoneNumber[userInput - 1] << endl;

		} 
		else
		{
			cout << "Error invalid number entered!" << endl;

		}//end if

		cout << "\nWould you like to continue (Y or N)? ";
		cin >> userChoice;

		//Validate user Choice
		if (toupper(userChoice) == 'Y')
		{
			system("cls");

		}
		else if (toupper(userChoice)=='N')
		{
			//Stop and Thanks
			cout << "T H A N K  Y O U!" << endl;
			system("pause");
			return 0;
		}
		else
		{
			//Clears and loops to the start
			system("cls");
			cout << "Error please try again invalid (Y or N)" << endl;
				userChoice = 'Y';
		}//endif

	}//end of while loop

	cout << "\t\t\tT H A N K   Y O U !" << endl;;

	//Stop
	system("pause");
	return 0;
}
