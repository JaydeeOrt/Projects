/*	
	Jorge Ortiz
 	CPT-236
	Lab 1
 */
//Contains all Yummy Catering
import java.util.Scanner;
public class YummyMotto {

	public static void main(String[] args) 
	{
		//Prints out welcome message
		System.out.println("Welcome to Yummy Catering!");
		System.out.println();
		//prints motto
		System.out.println("Yummy makes the food tht makes it a party!");
		System.out.println();
		//Prints Motto with * Border
		System.out.println("**********************************************");
		System.out.println("* Yummy makes the food tht makes it a party! *");
		System.out.println("**********************************************");
		
		
		
		//Chapter 2 Part
		Scanner input = new Scanner(System.in);
		int guests;
		int cost;
		boolean largeEvent = false;
		//Promps user
		System.out.println("How many guests will be attending?:");
		//reads line for int
		guests = input.nextInt();
		//Calculates cost
		cost = guests * 35;
		//Outputs 
		System.out.println("Number of guests: " + guests);
		System.out.println("Cost per Guests: $35");
		System.out.println("Total Cost: $" + cost);
		//Checks if its a large event
		if(guests >=50)
		{
			largeEvent = true;
		}
		System.out.println("Event Large: " + largeEvent);
		
		//Prints Goodbye message with new line and tabs
		System.out.println("\n\t\tThankYou!");
	}

}
