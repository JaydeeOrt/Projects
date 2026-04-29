// JorgeOrtiz-CPT-168-Lab-10.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>
using namespace std;

int main()
{
	cout << "\t\t*****************" << endl;
	cout << "\t\t*  Jorge Ortiz  *" << endl;
	cout << "\t\t*    CPT-168    *" << endl;
	cout << "\t\t*     Lab-10    *" << endl;
	cout << "\t\t*****************" << endl;

	//declare variables
	ifstream inPayroll;
	double grossPay = 0.0;
	double deductions = 0.0;
	double netPay = 0.0;
	double otPayRate = 0.0;
	int otHours = 0;
	double overTime = 0.0;
	string firstName = "";
	string lastName = "";
	string ssn = "";
	int hours = 0;
	double payRate = 0;
	int recordnum = 0;

	//open file
	inPayroll.open("payroll.txt");
	if (inPayroll.is_open())
	{
		cout << "W E L C O M E  T O  T H E  P A Y R O L L  R E P O R T!" << endl;
	}
	else
	{
		cout << "Could not open file..... !" << endl;
		return 0;
	}

	while (!inPayroll.eof() )
	{
		//reading the file
		getline(inPayroll, firstName,' ');
		getline(inPayroll, lastName, '\t');
		getline(inPayroll, ssn,'\t');
		inPayroll>> hours;
		inPayroll >> payRate;
		inPayroll.ignore();

		
		//Social security number
		cout << "SSN: ";
		for (int i = 7; i < 11; i++)
		{
			cout << ssn[i];
		}

		//Name
		cout << "\nName: " << firstName[0] << ". " << lastName << endl;

		//Hours
		cout << "Hours Worked: " << hours << endl;
		cout << "Hourly Rate: "<<fixed<<setprecision(2) << payRate << endl;

		//Gross Pay 
		if(hours > 40)
		{
			otHours = hours - 40;
			otPayRate = payRate * 1.5;
			overTime = otHours * otPayRate;
			grossPay = 40 * payRate;
			grossPay = grossPay + overTime;

		}
		else
		{
			grossPay = hours * payRate;
		}
		
		cout << "Gross pay:" << grossPay << endl;

		//deductions
		deductions = grossPay * 0.1;
		cout << "Deductions: " << deductions << endl;
		
		//Net Pay
		netPay = grossPay - deductions;
		cout << "NetPay: " << netPay << endl << endl;


		//counter
		recordnum++;

	}
	
	cout << "Number of records: " <<recordnum <<endl ;
	//close file
	inPayroll.close();


	cout << "Thank You!" << endl;





	system("pause");
	return 0;
}
