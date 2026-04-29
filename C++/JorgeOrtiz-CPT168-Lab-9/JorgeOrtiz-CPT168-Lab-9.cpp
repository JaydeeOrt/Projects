

#include <iostream>
#include <string>
using namespace std;
int main()
{
	cout << "\t\t*****************" << endl;
	cout << "\t\t*  Jorge Ortiz  *" << endl;
	cout << "\t\t*    CPT-168    *" << endl;
	cout << "\t\t*     Lab-9     *" << endl;
	cout << "\t\t*****************" << endl;


	string firstName = "";
	string lastName = "";
	string phoneNumber = "";
	string ssn = "";
	string fullName = firstName + " " + lastName;
	int fullNameLength = 0;
	string reversedName = "";
	int phoneLength = 0;
	int ssnLength = 0;
	char userChoice = 'Y';


	while (toupper(userChoice) != 'N')
	{
		if (toupper(userChoice) == 'Y')
		{
			cout << "Please enter your first name: ";
			cin >> firstName;
			cout << "Please enter your last name: ";
			cin >> lastName;


			//Phone loop
			do
			{
				cout << "Please enter a 10 digit phone number: ";
				cin >> phoneNumber;
				phoneLength = phoneNumber.length();
			} while (phoneLength != 10);


			// SSN loop
			do
			{
				cout << "Please enter a 9 digit social security number: ";
				cin >> ssn;
				ssnLength = ssn.length();
			} while (ssnLength != 9);


			//fills full name
			fullName = firstName + " " + lastName;
			fullNameLength = fullName.length();
			cout << "Your full name is: " + fullName << endl;


			//Reverses the name
			for (int i = fullNameLength; i > 0;i--)
			{
				reversedName += fullName[i - 1];
			}
			cout << "Your name backwards is: " + reversedName << endl;

			//Add () and - to phone
			phoneNumber.insert(0, "(");
			phoneNumber.insert(4, ")");
			phoneNumber.insert(8, "-");
			cout << "Your phone number is: " << phoneNumber << endl;


			//Add - to SSn
			ssn.insert(3, "-");
			ssn.insert(6, "-");
			
		}//endif


		cout << "Do you want to try again(Y or N)?";
		cin >> userChoice;


	}//end loop


	//Thank you end
	cout << "\t\t\tThank You!" << endl;
	system("pause");
	return 0;
}

