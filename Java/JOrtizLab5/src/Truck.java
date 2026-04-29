public class Truck extends Vehicle
{
	double BedLength;
	double TowingCapacity;
	//Parameter Constructor
		public Truck(String make, String model, int year, double price,double length, double towCap)
		{
			super(make, model, year,price);
			BedLength = length;
			TowingCapacity = towCap;
		}
	//Accessors
	public double getBedLength()
	{
		return BedLength;
	}
	public double getTowingCap()
	{
		return TowingCapacity;
	}
	//Mutators
	public void setBedLength(double length)
	{
		BedLength = length;
	}
	public void setTowingCap(double towCap)
	{
		TowingCapacity = towCap;
	}
	public void DisplayVehicle()
	{
		System.out.println("This Vehicles\nMake is: " + getMake() +"\nModel: " + getModel() + "\nYear: " 
	+ getYear() + "\nCost: " + getPrice() +"\nBed length: " + getBedLength()+ "\nTowing Capacity: " + getTowingCap());
	}
	
}
