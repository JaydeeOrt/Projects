// JorgeOrtiz-CPT-168-Lab-4.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main() //Main Function
{
	//Display my information
	cout << "\t\t***************************" << endl;
	cout << "\t\t*       Jorge Ortiz       *" << endl;
	cout << "\t\t*       CPT-168-A01       *" << endl;
	cout << "\t\t*          Lab-3          *" << endl;
	cout << "\t\t***************************" << endl;


	//Declare variables

	int commission	= 0;
	int carsSold	= 0;

	//Input
	cout << "Please enter the number of cars sold: ";
	cin >> carsSold;

	//Process
	commission = carsSold * 500;

	//Output
	cout << "Your commission is: $" << commission<< endl;
	cout << "\tT H A N K   Y O U" << endl;
	system("pause");
	return 0;
} //End of main function


