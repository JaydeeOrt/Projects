
public class SavingsAccounts extends BankAccount
{
	final static Double InterestRate = 0.01;
	String Type;
	public SavingsAccounts(String name, String phone, String email)
	{
		super(name,phone,email);
		Type = "Savings Account";
	}
	
	public void GetInterestRate()
	{
		System.out.println("Your Interest Rate will be: " + InterestRate*100+"%");
	}
	public double GetInterestRateBalance()
	{
		Double newBalance =GetBalance()*InterestRate;
		return newBalance;
	}
	public String DisplayAccountInfo()
	{
		//Displays account info
		String Info =  "Acount Type: " + Type +"\nAccount Numbers: ****" + AccountNumber.substring(AccountNumber.length()-4) +
				"\nHolders Name: "+ OwnerName + "\nEmail: " + Email + "\nPhone: " + PhoneNumber +
				"\nBalance: "+String.format("%.2f", Balance);
		return Info;
		
	}
}
