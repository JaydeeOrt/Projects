import javax.swing.JOptionPane;

public class BankAccount 
{
	//Personal Profile Fields
	String AccountNumber = "10000000";
	String OwnerName;
	String Email;
	String PhoneNumber;
	static int Count=0;
	//Financial Fields
	Double Balance;
	
	
	//default
	public BankAccount()
	{
		AccountNumber="10000000";
		OwnerName ="N/A";
		Email= "N/A@gmail.com";
		PhoneNumber = "000-000-0000";
		Balance = 0.0;
	}
	//paramaterized constructor
	public BankAccount( String name, String email, String phone)
	{
		Count ++;
		int x = Integer.parseInt(AccountNumber);
		AccountNumber = String.valueOf(x + Count);
		OwnerName =name;
		Email= email;
		PhoneNumber = phone;
		Balance =0.00;
	}
	

	//methods 
	public void Deposit(double amount)
	{
		//Add money to balance
		Balance += amount;
	}
	public void Withdraw(double amount, String number, String Name)
	{
		//asks user to verify account name and number
		String userName = JOptionPane.showInputDialog("Please Enter The Name on Your Account");
		String userAccountNumber = JOptionPane.showInputDialog("Please Enter The Name on Your Account");
		//Deducts money from balance
		if(userAccountNumber.contentEquals(AccountNumber) && userName.contentEquals(OwnerName))
		{
			Double tempBalance= Balance+100;
			if(amount <= tempBalance)
			{
				//withdraws amount if they have enough in balance
				Balance -= amount;
			}
			else
			{
				//error if not enough money to withdraw
				System.out.println("Error!!!\nYou do not have enought Fund to withdraw!");
			}//endif
		}
		else
		{
			//error if Failed account verification
			System.out.println("Error!!!\nCannot find your account please try again");
		}//endif
			
	}
	
	public boolean CheckForInfo(String name, String number)
	{
		if(name.toUpperCase() ==OwnerName.toUpperCase() && number == AccountNumber)
		{
			return true;
		}
		else
		{
			return false;
		}//endif
	}
	public void DisplayAccountInfo()
	{
		//Displays account info
		System.out.println( "Account Numbers: ****" + AccountNumber.substring(AccountNumber.length()-4) +
				"\nHolders Name: "+ OwnerName + "\nEmail: " + Email + "\nPhone: " + PhoneNumber +
				"\nBalance: "+String.format("%.2f", Balance));
		
	}
	public Double GetBalance()
	{
		return Balance;
	}
	public String GetAccountNumber()
	{
		return AccountNumber;
	}

}
