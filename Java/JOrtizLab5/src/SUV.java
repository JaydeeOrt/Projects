
public class SUV extends Vehicle
{
	int Seats;
	boolean HasThirdRow;
	//Parameter Constructor
		public SUV(String make, String model, int year, double price,int seats, boolean thirdRow)
		{
			super(make, model, year,price);
			Seats = seats;
			HasThirdRow = thirdRow;
		}
	//Accessors
		public int getSeats()
		{
			return Seats;
		}
		public boolean getHasThirdRow()
		{
			return HasThirdRow;
		}
		//Mutators
		public void setSeats(int seats)
		{
			Seats = Seats;
		}
		public void setThirdRow(boolean thirdRow)
		{
			HasThirdRow = thirdRow;
		}
		public void DisplayVehicle()
		{
			System.out.println("This Vehicles\nMake is: " + getMake() +"\nModel: " + getModel() + "\nYear: " 
		+ getYear() + "\nCost: " + getPrice() +"\nNumber of Seats: " + getSeats()+ "\nHas a Third row: " + getHasThirdRow());
		}
		
}
