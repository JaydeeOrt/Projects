//Jorge Ortiz
//Lab 4
//CPT-236-A01H
import java.util.Scanner;

public class TextProcessor 
{
	static Scanner input = new Scanner(System.in);
	
	public static void Display(StringBuilder original)
	{
		//Displays the given text
		System.out.println("Your Current text is: " + original);
	}
	public static StringBuilder Append(StringBuilder original)
	{
		//gets user input then appends it to the end including the space before the new appended text goes in
		System.out.println("What would you like to append to the text: ");
		StringBuilder apend = new StringBuilder(input.nextLine());
		original.append(" "+apend);
		return original;
	}
	
	//removes character
	public static StringBuilder Remove(StringBuilder original)
	{
		
		String edit = original.toString();
		//gets user input
		System.out.println("Which characters do you wish to remove?: ");
		String out = input.next();
		//Removes Character anywhere it shows up in the text, and replaces with nothing  removing it
		//added regex so it is not case sensitive it does everything
		StringBuilder finalEdit = new StringBuilder(edit.replaceAll("(?i)"+ out,""));
		return finalEdit;
		
		
	}
	
	//replaces characters
	public static StringBuilder Replace(StringBuilder original)
	{
		String edit = original.toString();
		//get user inputs
		System.out.println("Which characters do you wish to replace?: ");
		String out = input.next();
		System.out.println("What character will take its place?: ");
		String in = input.next();
		//replaces
		//Added regex to do both caps or not
		StringBuilder finalEdit = new StringBuilder(edit.replaceAll("(?i)"+ out, in));
		return finalEdit;
	}
	
	
	public static StringBuilder ToUpper(StringBuilder original)
	{
		//Upper cases them with built in method
		StringBuilder upper =new StringBuilder(original.toString().toUpperCase());
		
		return upper;
	}
	
	public static StringBuilder ToLower(StringBuilder original)
	{
		//Turns it to lower case using the built in method 
		//alternatly would have to for loop it to lowercase them all
		StringBuilder lower = new StringBuilder(original.toString().toLowerCase());
		return lower;
	}
		
		
	public static StringBuilder Reverse(StringBuilder original)
	{
		StringBuilder edit = new StringBuilder(original.reverse());
		return edit;//placeholder
	}
		
		
	

}
