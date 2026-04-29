//Jorge Ortiz
//Lab 6
//CPT236

import java.util.ArrayList;

import javax.swing.JOptionPane;

public class Main 
{

	public static void main(String[] args) 
	{
		boolean userCheck = false;
		int count = 0;
		int current=-1;
		Double amount;
		
		String userLoop= "Y";
		//Creates a Bank Account arrrayList
		ArrayList<BankAccount> AccountLists = new ArrayList<BankAccount>();

		
		//Welcome Message
		System.out.println("*******************Welcome to the Bank Management System*******************");
		String userName = JOptionPane.showInputDialog("Please Enter Your Name");
		String userNumber = JOptionPane.showInputDialog("Please Enter Your Account Number, If You Do Not Have One Leave Blank");
		
		
		//Start While Loop
		while(!userLoop.equalsIgnoreCase("n"))
		{
			//check if user has an account already
			for(BankAccount account : AccountLists)
			{
				
				if(account.CheckForInfo(userName, userNumber)==true)
				{
					current ++;
					userCheck = true;
				}
			}
			
			if(userCheck== true)
			{
				String userChoice = JOptionPane.showInputDialog("\t\tWelcome\nWould you like to (D)eposit, (W)ithdraw,"
						+ " or D(i)splay your Account information or (Q)uit");
				switch(userChoice.toUpperCase())
				{
				case "D":
					amount =  Double.parseDouble(JOptionPane.showInputDialog("How Much Would You Like To Deposit?"));
					AccountLists.get(current).Deposit(amount);
					break;
					
					
				case "W":
					amount =  Double.parseDouble(JOptionPane.showInputDialog("How Much Would You Like To Withdraw?"));
					AccountLists.get(current).Withdraw(amount,userNumber,userName);
					break;
					
					
				case "I":
					AccountLists.get(current).DisplayAccountInfo();
					break;
				case "Q":
					userLoop = "Q";
					System.out.println("Thank you GoodBye");
					break;
				}//end Switch
				
			}
			else  
			{
				System.out.println("Lets register for an account");
				String userPhone = JOptionPane.showInputDialog("Please Enter Your PhoneNumber");
				String userEmail = JOptionPane.showInputDialog("Please Enter Your Email");
				String type = JOptionPane.showInputDialog("What Type of Account do you want?\n(S)avings, (C)heckings,"
						+ "(M)utualFunds, or Cr(y)pto account");
				
				switch(type.toUpperCase())
				{
					case "S":
						SavingsAccounts newSave = new SavingsAccounts(userName,userPhone, userEmail);
						newSave.GetInterestRate();
						AccountLists.add(newSave);
						count++;
						break;
					case "C":
						CheckingAccount newCheck = new CheckingAccount(userName,userPhone, userEmail);
						AccountLists.add(newCheck);
						count++;
						break;
					case "M":
						MutualFundAccount newMut = new MutualFundAccount(userName,userPhone, userEmail);
						newMut.SetRiskLevel();
						AccountLists.add(newMut);
						count++;
						break;
					case "Y":
						String cType = JOptionPane.showInputDialog("What Type of Crypto Do You Have?");
						CryptoAccount newCrypt = new CryptoAccount(userName,userPhone, userEmail,cType);
						newCrypt.SetBalance();
						AccountLists.add(newCrypt);
						count++;
						break;
				}//end if SWitch
				current ++;
				userCheck = true;
			}//end of If
			//userLoop = JOptionPane.showInputDialog("Do you want Q")
		}//end WHile
	}

}
/*
BankAccount newAccount =new BankAccount("JORGE ORTIZ","ExampleEmail@GMAIL.COM","8604506301");
BankAccount newAccount2 =new BankAccount("Jacob Jolly","dasdasd@gmail.com","1234567889");
newAccount.DisplayAccountInfo();
System.out.println();
newAccount2.DisplayAccountInfo();
*/