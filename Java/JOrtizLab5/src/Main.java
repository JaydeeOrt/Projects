//Jorge Ortiz
//CPT 236
//Lab 5
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
public class Main 
{
	public static void main(String[] args) 
	{
		//Initialize vehicle list and user input Scanner and Variables
		ArrayList<Vehicle> vehicleList = new ArrayList<Vehicle>();
		Scanner input = new Scanner(System.in);
		String userInput = "";
		String make;
		String model;
		int year;
		double price;
		//Welcome message
		System.out.println("\t\tWelcome to Your Digital Car Garage! \n\t\tAre Your Ready To Enter Your Vehicles?\n");
		
		while(!userInput.equalsIgnoreCase("n"))
		{
			//Gets user Base Vehicle Data
			System.out.println("What is your Vehicles Make: ");
			make = input.nextLine();
			System.out.println("What is your Vehicles Model: ");
			model = input.nextLine();
			System.out.println("What is your Vehicles Year: ");
			year = input.nextInt();
			
			System.out.println("What is your Vehicles Price: ");
			price = input.nextDouble();
			
			//Gets User Vehicle type for Switch statement
			System.out.println("\nWhat Type of Vehicle is this?\nPLease Enter (C = Car, T = Truck, or S = SUV!): ");
			input.nextLine();
			userInput = input.nextLine();
			
			//Switch Statement to add info needed For Specific Vehicles
			switch(userInput.toUpperCase())
			{
			case "C":
				//Creates Car Extra variables and asks user for them
				boolean convertible = false;
				int doors;
				System.out.println("How Many Doors Does Your Car Have?: ");
				doors = input.nextInt();
				input.nextLine();
				System.out.println("Is Your Car a Convertible?: ");
				//takes user yes or no input to try and Makes them true or false
				if(input.nextLine().equalsIgnoreCase("Yes")||input.nextLine().equalsIgnoreCase("Y"))
				{
					convertible = true;
				}
				//Makes the Car Object and fills it with the info from user
				Car newCar = new Car(make,model,year,price,doors,convertible);
				//Adds The Car object into the Vehicles lsit
				vehicleList.add(newCar);
				break;
				
				
			case "T":
				//Truck Variables
				double bedLength;
				double towingCap;
				//Get truck specific user inputs
				System.out.println("What is your Trucks Bed Length?: ");
				bedLength = input.nextDouble();
				System.out.println("What is your Trucks Towing Cap?: ");
				towingCap = input.nextDouble();
				//initialize Truck vairble then add to vehicle list
				Truck newTruck = new Truck(make,model,year,price,bedLength,towingCap);
				vehicleList.add(newTruck);
				break;
				
				
			case "S":
				//SUV Variables and user inputs
				int seats;
				boolean thirdRow = false;
				System.out.println("How Many Seats Does Your SUV Have?: ");
				seats = input.nextInt();
				System.out.println("Is Does Your SUV Have a Third Row?: ");
				//takes user yes or no input to try and Makes them true or false
				if(input.nextLine().equalsIgnoreCase("Yes")||input.nextLine().equalsIgnoreCase("Y"))
				{
					thirdRow = true;
				}
				//Create SUV object fill it and add to list
				SUV newSUV = new SUV(make,model,year,price,seats,thirdRow);
				vehicleList.add(newSUV);
				break;
			}//end Switch
			//Ask to loop
			input.nextLine();
			System.out.println("Would you like to add Another?(Y/N): ");
			
			userInput = input.nextLine();
		}//end while
		
		//Loops and outputs the List of Vehicles
		for(int i = 0;i < vehicleList.size();i++)
		{
			vehicleList.get(i).DisplayVehicle();
			System.out.println("\n");
		}
	}
}
