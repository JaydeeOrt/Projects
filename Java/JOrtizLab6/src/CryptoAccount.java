import javax.swing.JOptionPane;

public class CryptoAccount extends BankAccount 
{
	Double CryptoBalance;
	String CryptoType;
	String Type;
	public CryptoAccount(String name, String phone, String email,String crypto)
	{
		super(name,phone,email);
		Type = "Crypto Account";
		CryptoType = crypto;
	}
	public void SetBalance()
	{
		CryptoBalance = Double.parseDouble(JOptionPane.showInputDialog("How much is your Crypto Worth"));
	}
	public void DisplayAccountInfo()
	{
		//Displays account info
		System.out.println( "Acount Type: " + Type +"\nAccount Numbers: ****" + AccountNumber.substring(AccountNumber.length()-4) +
				"\nHolders Name: "+ OwnerName + "\nEmail: " + Email + "\nPhone: " + PhoneNumber +
				"\nYou Own "+ CryptoType + "\nBalance: "+String.format("%.2f", Balance));
		
	}
}
