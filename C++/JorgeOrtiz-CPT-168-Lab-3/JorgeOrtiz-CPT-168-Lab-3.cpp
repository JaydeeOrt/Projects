// JorgeOrtiz-CPT-168-Lab-3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()//Main Function
{
system("color f0");
	
//Display my information
cout << "\t\t****************************" << endl;
cout << "\t\t*        Jorge Ortiz       *"<<endl;
cout << "\t\t*        CPT-168-A01S      *"<<endl;
cout << "\t\t*   Calculate Commission   *"<<endl;
cout << "\t\t*           Lab-3          *" << endl;
cout << "\t\t****************************" << endl<<endl;


//Declare variables
double sale1			= 0.0;
double sale2			= 0.0;
double commissionRate	= 0.0;
double totalSales		= 0.0;
double commission		= 0.0;

//Input
cout << "First sale? ";
cin >> sale1;
cout << "Second sale? ";
cin >> sale2;
cout << "Commission rate in decimal format? ";
cin >> commissionRate;

//Process
totalSales = sale1 + sale2;
commission = totalSales * commissionRate;

//Output
cout << "\tCommission: $" << commission << endl;
cout << "\n*************** T H A N K  Y O U ***************\n" << endl;

system("pause");
return 0;
}//end of main function

