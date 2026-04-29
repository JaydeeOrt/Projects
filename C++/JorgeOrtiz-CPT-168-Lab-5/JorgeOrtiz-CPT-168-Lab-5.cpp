// JorgeOrtiz-CPT-168-Lab-5.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main()//Main Function
{
	//Display my information
	cout << "******************" << endl;
	cout << "*  Jorge Ortiz   *" << endl;
	cout << "*  CPT-168-A01S  *" << endl;
	cout << "*     Lab-5      *" << endl;
	cout << "******************" << endl;

	//Declare Variables
	int yearsWorked = 0;
	double salary = 0.0;
	double holidayBonus = 0.0;

	//Input
	cout << "Please enter your salary: ";
	cin >> salary;
	cout << "Please enter number of years worked: ";
	cin >> yearsWorked;

	//Decision
	//1-5
	if (yearsWorked <= 5 && yearsWorked > 0)
		{
		//Process
		holidayBonus = salary * 0.01;
		}
	else
		//Greater than 5
		if (yearsWorked > 5)
		{
			//Process
			holidayBonus = salary * 0.02;
		}
		else
		{
			//Output
			cout << "Invalid number of years" << endl;
			cout << "\tT  H  A  N  K    Y  O  U" << endl;
			system("pause");
			return 0;
		}
	//Output
	cout << "Your holiday bonus is: $" << holidayBonus << endl;

	cout << "\tT  H  A  N  K    Y  O  U" << endl;

	system("pause");
	return 0;
}


