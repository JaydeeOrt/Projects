/*	
	Jorge Ortiz
 	CPT-236-A01H
	Lab 2
 */
import java.util.Scanner;

public class SunshineRental 
{

	public static void main(String[] args) 
	{
		int minutes =numberOfMinutes();
		displayInfo();
		details(minutes);
	}
	
	public static int numberOfMinutes()
	{
		Scanner input = new Scanner(System.in);
		int minutes;
		System.out.println("How long was rented(in minutes)>>");
		minutes = input.nextInt();
		return minutes;
	}
	
	public static void displayInfo()
	{
		System.out.println("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
		System.out.println("S Sunshine Seashore makes it fun in the sun! S");
		System.out.println("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
	}
	public static void details(int minutes)
	{
		int cost = 0;
		//Gets the hours
		int hours = minutes/60;
		//gets the minutes
		int times = minutes % 60;
		//calculates
		cost = ((hours*40));
		
		if(times>40)
		{
			cost = cost+40;
		}
		else
		{
			cost = cost+times;
		}
			
		System.out.println("Hours: "+hours+"\nMinutes: " + times);
		System.out.println("Total: $" + cost);
		//Prints Goodbye message with new line and tabs
		System.out.println("\n\t\tThankYou!");
	}
	
	
}
