// JorgeOrtiz-CPT168-Lab-7.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;


int main()
{
	cout << "\t\t****************" << endl;
	cout << "\t\t* Jorge  Ortiz *" << endl;
	cout << "\t\t* CPT-168-A01S *" << endl;
	cout << "\t\t*    Lab-7     *" << endl;
	cout << "\t\t****************" << endl;

	int userNumber;
	string userCheck = "Y";


	//Main Loop
	while(userCheck == "Y")
	{ 
		int counter = 0;


		cout << "Enter a number to square, cube, and raise to the 4th power: ";
		cin >> userNumber;
		cout << "Number\t Square\t Cube\t 4th Power" << endl;
		cout << "------\t ------\t ----\t ---------" << endl;

		//Counter loop
		while (counter <10)
		{
			
			cout << userNumber << "\t " << pow(userNumber, 2.0) << "\t " << pow(userNumber, 3.0) << "\t " << pow(userNumber, 4.0) << endl;
			userNumber += 5;
			counter++;

		}//end Loop
		cout << "Would you like to continue (Y or N)?: ";
		cin >> userCheck;


		//If that capitalizes the Y or N
		if (userCheck == "y")
		{
			userCheck = "Y";
		} 
		else if(userCheck == "n")
		{
			userCheck = "N";
		}
		//Tells user invalid entry and ends the program
		else
		{
			cout << "Invalid entry try again" << endl;
			cout << "T H A N K   Y O U!" << endl;
			system("Pause");
			return 0;
		}//endif
		

		//Clears screen
		system("cls");


	}//end Loop
	cout << "T H A N K   Y O U!" << endl;
		system("Pause");
		return 0;
}

