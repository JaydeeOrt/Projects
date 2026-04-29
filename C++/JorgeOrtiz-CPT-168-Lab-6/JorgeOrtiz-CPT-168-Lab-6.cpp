// JorgeOrtiz-CPT-168-Lab-6.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>;
using namespace std;

int main()
{
    //Display my information
    cout << "*******************" << endl;
    cout << "*  Jorge Ortiz    *" << endl;
    cout << "*  CPT-168-A01S   *" << endl;
    cout << "*     Lab-6       *" << endl;
    cout << "*******************" << endl;


    //Declare Variable
    int yearsWorked = 1;
    double salary = 0.0;
    double holidayBonus = 0.0;

    //Loop
    while (yearsWorked > 0 && yearsWorked < 99)
    {


        //Input
        cout << "Please enter number of years worked or (0, 99 or higher, negative number) to exit: ";
        cin >> yearsWorked;


        if (yearsWorked > 0 && yearsWorked < 99)
        {
            cout << "Please enter your salary: ";
            cin >> salary;


            //Dicisions
            if (yearsWorked > 0 && yearsWorked <= 5)
            {
                //Process
                holidayBonus = salary * 0.01;

            }
            else
                if (yearsWorked > 5)
                {
                    holidayBonus = salary * 0.02;
                } //endif checks holiday bonus
            
              //Output
            cout << "Your holiday bonus: is $" << holidayBonus << endl;

        }//endif checks if years worked bwtween 0 - 99
   
    }//End Loop

    cout << "\tT H A N K  Y O U" << endl;
    system("pause");
    return 0;
}
