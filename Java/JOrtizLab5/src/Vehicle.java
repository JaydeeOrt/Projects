public class Vehicle 
{
	String Make;
	String Model;
	int Year;
	double Price;
	
	//Default
	public Vehicle()
	{
		Make = "N/A";
		Model = "N/A";
		Year = 1000;
		Price = 0.00;
	}
	//paramaterized constructor
	public Vehicle(String make, String model, int year, double price)
	{
		Make = make;
		Model = model;
		Year = year;
		Price = price;
	}
	
	//Gets Accessors
	public String getMake()
	{
		return Make;
	}
	public String getModel()
	{
		return Model;
	}
	public int getYear()
	{
		return Year;
	}
	public double getPrice()
	{
		return Price;
	}
	
	//Mutators
	public void setMake(String make)
	{
		Make = make;
	}
	public void setModel(String model)
	{
		Model =  model;
	}
	public void setYear(int year)
	{
		Year = year;
	}
	public void setPrice(double price)
	{
		Price = price;
	}
	//Display
	public void DisplayVehicle()
	{
		System.out.println("This Vehicles:\nMake is: " + getMake() +"\nModel: " + getModel() + "\nYear: " 
	+ getYear() + "\nCost:" + getPrice());
	}
}
