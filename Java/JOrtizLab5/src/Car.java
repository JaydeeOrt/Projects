public class Car extends Vehicle
{
	//final private String Type = "Car";
	int NumDoors;
	boolean IsConvertible;
	
	//Default Consstructor
	public Car()
	{
		NumDoors = 4;
		IsConvertible = false;
	}
	//Parameter Constructor
	public Car(String make, String model, int year, double price,int doors, boolean convert)
	{
		super(make, model, year,price);
		NumDoors = doors;
		IsConvertible = convert;
		/*
		setMake(make);
		setModel(model);
		setYear(year);
		setPrice(price);
		*/
	}
	
	//Accesssors
	public int getNumDoors()
	{
		return NumDoors;
	}
	public boolean getIsConvertible()
	{
		return IsConvertible;
	}
	//Mutators
	public void setNumDoors(int doors)
	{
		NumDoors = doors;
	}
	
	public void setIsConvertible(boolean convertible)
	{
		IsConvertible = convertible;
	}
	public void DisplayVehicle()
	{
		System.out.println("This Vehicles\nMake is: " + getMake() +"\nModel: " + getModel() + "\nYear: " 
	+ getYear() + "\nCost: " + getPrice() +"\nNumber of Doors: " + getNumDoors()+ "\nConvertible: " + getIsConvertible());
	}
	
}
