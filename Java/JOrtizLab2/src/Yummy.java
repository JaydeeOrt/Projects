/*	
	Jorge Ortiz
 	CPT-236-A01H
	Lab 2
 */
import java.util.Scanner;

public class Yummy {

	public static void main(String[] args) 
	{
		int numberGuest = numberOfGuests();
		displayInfo();
		eventCalculations(numberGuest);
	}
	
	public static int numberOfGuests()
	{
		Scanner input = new Scanner(System.in);
		int guests;
		//Prompts user
		System.out.println("How many guests will be attending?:");
		//reads line for int
		guests = input.nextInt();
		return guests;
		
	}
	
	public static void displayInfo()
	{
		System.out.println("**********************************************");
		System.out.println("* Yummy makes the food tht makes it a party! *");
		System.out.println("**********************************************");
	}
	
	public static void eventCalculations(int guests)
	{
		boolean largeEvent = false;
		//Calculates cost
		int cost = guests * 5;
		//Outputs 
		System.out.println("Number of guests: " + guests);
		System.out.println("Total Cost: $" + cost);
		//Checks if its a large event and then calculates costs based on party size
		if(guests >=50)
		{
			largeEvent = true;
			cost = guests * 32;
			System.out.println("Cost per Guests: $32");
			System.out.println("Total Cost: $" + cost);
		}
		else
		{
			cost = guests *35;
			System.out.println("Cost per Guests: $35");
			System.out.println("Total Cost: $" + cost);
		}
		System.out.println("Event Large: " + largeEvent);
				
		//Prints Goodbye message with new line and tabs
		System.out.println("\n\t\tThankYou!");
		
	}

}
