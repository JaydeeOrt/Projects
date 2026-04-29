/*	
	Jorge Ortiz
 	CPT-236
	Lab 1
 */
//Contains all Sunshine
import java.util.Scanner;
public class SunshineMotto 
{
	
	public static void main(String[] args) 
	{
		//Prints out welcome message
		System.out.println("Welcome to Sunshine Seashore Supplies!");
		System.out.println();
		//prints motto
		System.out.println("Sunshine Seashore makes it fun in the sun!");
		System.out.println();
		//Prints Motto with * Border
		System.out.println("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
		System.out.println("S Sunshine Seashore makes it fun in the sun! S");
		System.out.println("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
		
				
				
		//Chapter 2 Part
		Scanner input = new Scanner(System.in);
		int minutes;
		int cost = 0;
		System.out.println("How long was rented(in minutes)>>");
		minutes = input.nextInt();
		//Gets the hours
		int hours = minutes/60;
		//gets the minutes
		int times = minutes % 60;
		//calculates
		cost = ((hours*40) + times);
		
		System.out.println("Hours: "+hours+"\nMinutes: " + times);
		System.out.println("Total: $" + cost);
		//Prints Goodbye message with new line and tabs
		System.out.println("\n\t\tThankYou!");
	}

}
