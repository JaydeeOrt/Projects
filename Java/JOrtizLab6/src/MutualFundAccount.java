import javax.swing.JOptionPane;

public class MutualFundAccount extends BankAccount 
{
	Double InvestmentBalance;
	String RiskLevel;//Low,medium,High
	String Type;
	public MutualFundAccount(String name, String phone, String email)
	{
		super(name,phone,email);
		Type = "Mutual Funds Account";
	}
	public void SetRiskLevel()
	{
		//ask for risk level then sitch statement to set it in the class;
		String risk = JOptionPane.showInputDialog("What is your Risk Level?(L)ow, (M)edium,(H)igh");
		switch(risk.toUpperCase())
		{
		case "L":
			RiskLevel ="Low";
		case "M":
			RiskLevel ="Medium";
		case"H":
			RiskLevel ="High";
			default:
				System.out.println("Please try again to enter your risk level");
		}
	}
	
	public void DisplayAccountInfo()
	{
		//Displays account info
		System.out.println( "Acount Type: " + Type +"\nAccount Numbers: ****" + AccountNumber.substring(AccountNumber.length()-4) +
				"\nHolders Name: "+ OwnerName + "\nEmail: " + Email + "\nPhone: " + PhoneNumber +
				"\nBalance: "+String.format("%.2f", Balance) + "\nYour Accounts Risk Level Is: " + RiskLevel);
		
	}
}
