//Jorge Ortiz
//Lab 4
//CPT-236-A01H
import java.util.Scanner;

public class Main 
{

	public static void main(String[] args) 
	{
		Scanner input = new Scanner(System.in);
		String userInput = "";
		int count =0;
		StringBuilder [] textHistory = new StringBuilder[100];
		
		//prompts the user for text
		System.out.println("Please Enter some text: ");
		//creates string builder vairbale with the line entered by user
		StringBuilder text = new StringBuilder(input.nextLine());
		
		while(!userInput.equalsIgnoreCase("Q"))
		{
			//User options menu
			System.out.println("Do you want to display (1), remove (2) or append(3) or replace(4) or Uppercase(5) or lowercase(6) or reverse(7) or Quit(0)");
			userInput = input.nextLine();
			//Does what the user asks in a loop
			if(userInput.compareTo("1") == 0|| userInput.equalsIgnoreCase("Display"))//check if equivalent
			{
				TextProcessor.Display(text);
			}
			else if(userInput.compareTo("2") == 0 || userInput.equalsIgnoreCase("Remove"))
			{
				textHistory[count] = text;
				count++;
				text = TextProcessor.Remove(text);
			}
			else if(userInput.compareTo("3") == 0|| userInput.equalsIgnoreCase("Append"))
			{
				textHistory[count] = text;
				count++;
				text = TextProcessor.Append(text);
			}
			else if(userInput.compareTo("4") == 0 || userInput.equalsIgnoreCase("Replace"))
			{
				//Replace();
				textHistory[count] = text;
				count++;
				text = TextProcessor.Replace(text);
			}
			else if(userInput.compareTo("5") == 0|| userInput.equalsIgnoreCase("UpperCase"))
			{
				//Upper case everything
				textHistory[count] = text;
				count++;
				text = TextProcessor.ToUpper(text);
			}
			else if(userInput.compareTo("6") == 0 || userInput.equalsIgnoreCase("LowerCase"))
			{
				//Lower case everything
				textHistory[count] = text;
				count++;
				text = TextProcessor.ToLower(text);
			}
			else if(userInput.compareTo("7") == 0 || userInput.equalsIgnoreCase("Reverse"))
			{
				//Reverse
				textHistory[count] = text;
				count++;
				text = TextProcessor.Reverse(text);
			}
			else if(userInput.compareTo("0") == 0|| userInput.equalsIgnoreCase("Quit"))
			{
				//user Quits
				System.out.println("Thank you");
				userInput ="Q";
			}
			else
			
			{
			System.out.println("Incorrect input please try again");
			}//endif
		}//end while
		//outputs the old texts from the array depending on the count
		System.out.println("\t\tText History\n");
		for(int i =0; i<count;i++)
		{
			System.out.println(textHistory[i]);
		}
	}

}
