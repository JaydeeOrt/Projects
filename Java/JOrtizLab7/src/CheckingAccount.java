import javax.swing.JOptionPane;

public class CheckingAccount extends BankAccount 
{
	final static Double OverDraftLimit = 100.00;
	String Type = "Checkings Account";
	boolean Dues = false;
	
	public CheckingAccount(String name, String phone, String email)
	{
		super(name,phone,email);
	}
	public void Withdraw(double amount, String number, String Name)
	{
		//asks user to verify account name and number
		String userName = JOptionPane.showInputDialog("Please Enter The Name on Your Account");
		String userAccountNumber = JOptionPane.showInputDialog("Please Enter Your Account Number");
		//Deducts money from balance
		if(userAccountNumber.contentEquals(AccountNumber) && userName.contentEquals(OwnerName))
		{
			Double tempBalance = Balance +100;
			if(amount <= tempBalance)
			{
				//withdraws amount if they have enough in balance
				Balance -= amount;
				if(Balance <= -100)
				{
					Dues = true;
					System.out.println("You owe $"+String.format("%.2f", Balance));
				}
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
	public String DisplayAccountInfo()
	{
		//Displays account info
		String Info;
		if(Dues)
		{
			Info = "Acount Type: " + Type +"\nAccount Numbers: ****" + AccountNumber.substring(AccountNumber.length()-4) +
				"\nHolders Name: "+ OwnerName + "\nEmail: " + Email + "\nPhone: " + PhoneNumber +
				"\nBalance: "+String.format("%.2f", Balance) +"\nYou owe $"+String.format("%.2f", Balance);
		}
		else
		{
			//Displays account info
			Info =  "Acount Type: " + Type +"\nAccount Numbers: ****" + AccountNumber.substring(AccountNumber.length()-4) +
					"\nHolders Name: "+ OwnerName + "\nEmail: " + Email + "\nPhone: " + PhoneNumber +
					"\nBalance: "+String.format("%.2f", Balance);
		}
		return Info;
		
	}
	
	
}
