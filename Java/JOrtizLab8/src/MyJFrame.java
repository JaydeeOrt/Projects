import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;

import javax.swing.*;

public class MyJFrame extends JFrame implements ActionListener
{
	//Creates a Bank Account arrrayList
	ArrayList<BankAccount> AccountLists = new ArrayList<BankAccount>();
	//BankAccount newAccount =new BankAccount("JORGE ORTIZ","ExampleEmail@GMAIL.COM","8604506301");
	//Variables to save user inputs
	private String userName;
	private String userAccount;
	private String userEmail;
	private String userPhone;
	private String type;
	//Combo Box Values
	private String[] accountTpyes = {"Checking","Savings", "Crypto", "Mutual Funds"};
	//Panels
	JPanel Cont = new JPanel();
	JPanel Welcome = new JPanel();
	JPanel Main = new JPanel();
	JPanel Register = new JPanel();
	JPanel Login = new JPanel();
	//Layout
	CardLayout layout = new CardLayout();
	//Buttons
	private JButton btnLogin = new JButton("Login");
	private JButton btnSubmit = new JButton("Submit");
	private JButton btnLog = new JButton("Have an Account");
	private JButton btnRegister = new JButton("Register");
	private JButton btnDeposit = new JButton("Deposit");
	private JButton btnWithdraw = new JButton("Withdraw");
	private JButton btnDisplay = new JButton("Account Info");
	private JButton btnExit = new JButton("Exit");
	//Text fields
	private JTextField txtName = new JTextField(20);
	private JTextField txtName2 = new JTextField(20);
	private JTextField txtAcNumber = new JTextField(20);
	private JTextField txtEmail = new JTextField(20);
	private JTextField txtPhone = new JTextField(20);
	private JComboBox cmbBoxTypes = new JComboBox(accountTpyes);
	//Label
	private JLabel lblMainWelcome = new JLabel();
	private JTextArea lblInfo = new JTextArea();
	private int count =0;
	public MyJFrame()
	{
		//Panels Set Ups
		//Welcome Page Setup
		Welcome.setLayout(new FlowLayout(FlowLayout.CENTER));
		//Label
		JLabel lblWelcome = new JLabel("Welcom to the bank Manager");
		JLabel lblWelcome2 = new JLabel("Login if you have an account number already!!");
		//Add Labels to page
		Welcome.add(lblWelcome);
		Welcome.add(lblWelcome2);
		//adding buttons and listener actions
		Welcome.add(btnRegister);
		btnRegister.addActionListener(this);
		Welcome.add(btnLog);
		btnLog.addActionListener(this);
		
		//Login Setup*****************
		//Labels Create
		JLabel lblName = new JLabel("Please enter your name: ");
		JLabel lblAcNumber = new JLabel("Please enter your Account number: ");
		
		//adding
		Login.add(lblName);
		Login.add(txtName);
		Login.add(lblAcNumber);
		Login.add(txtAcNumber);
		//button
		btnLogin.addActionListener(this);
		Login.add(btnLogin);

		
		//Register Page Setup**************************
		//Labels
		JLabel lblName2 = new JLabel("Please enter your name: ");
		JLabel lblType= new JLabel("Please Select The Account type: ");
		JLabel lblEmail = new JLabel("Please Enter Contact Email: ");
		JLabel lblPhone= new JLabel("Please Enter Contact Phone Number:");
		//comboBox
		btnSubmit.addActionListener(this);//Registering Submit button for listening
		//Add components to page and some from the log in
		Register.add(lblName2);
		Register.add(txtName2);
		Register.add(lblEmail);
		Register.add(txtEmail);
		Register.add(lblPhone);
		Register.add(txtPhone);
		Register.add(lblType);
		Register.add(cmbBoxTypes);
		cmbBoxTypes.addActionListener(this);
		Register.add(btnSubmit);
		
		
		//Main Page Setup***************************
		//JLabel lblMainWelcom = new JLabel("Welcome to your accoutn " + AccountLists.get(count-1).GetAccountName());
		JLabel lblSelect = new JLabel("Please Select: ");
		lblInfo.setVisible(false);
		lblInfo.setEditable(false);
		lblInfo.setOpaque(false);
		Main.add(lblMainWelcome);
		Main.add(lblSelect);
		Main.add(btnDeposit);
		Main.add(btnWithdraw);
		Main.add(btnDisplay);
		Main.add(btnExit);
		Main.add(lblInfo);
		btnDeposit.addActionListener(this);
		btnWithdraw.addActionListener(this);
		btnDisplay.addActionListener(this);
		btnExit.addActionListener(this);
		
		//Container Panel Setup
		//adding the panels
		Cont.setLayout(layout);
		Cont.add(Welcome,"Welcome");
		Cont.add(Register,"Register");
		Cont.add(Login,"Login");
		Cont.add(Main,"Main");
		//Starting Panel**************************
		layout.show(Cont,"Welcome");
		add(Cont);
		setSize(300,250);
	}
	
	@Override
	public void actionPerformed(ActionEvent e) 
	{
		// TODO Auto-generated method stub
		//Checks if my button was pressed on a switch by looking at buttons text
		double amount=0.0;
		switch(e.getActionCommand())
		{
		case "Register":
			layout.show(Cont, "Register");
			break;
			
		case "Submit":
			userName = txtName2.getText();
			userEmail = txtEmail.getText();
			userPhone = txtPhone.getText();
			
			 switch(type = (String) cmbBoxTypes.getSelectedItem())
				{
				case "Checking":
					CheckingAccount newCheck = new CheckingAccount(userName,userPhone, userEmail);
					AccountLists.add(newCheck);
					break;
				case "Savings":
					SavingsAccounts newSave = new SavingsAccounts(userName,userPhone, userEmail);
					AccountLists.add(newSave);
					break;
				case "Crypto":
					String cType = JOptionPane.showInputDialog("What Type of Crypto Do You Have?");
					CryptoAccount newCrypt = new CryptoAccount(userName,userPhone, userEmail,cType);
					AccountLists.add(newCrypt);
					break;
				case "Mutual Funds":
					MutualFundAccount newMut = new MutualFundAccount(userName,userPhone, userEmail);
					newMut.SetRiskLevel();
					AccountLists.add(newMut);
					break;
				}//EndSwitch
			count++; 
			//gets the account number shows to user and then sets it to text box in the next form
			userAccount = AccountLists.get(count-1).GetAccountNumber();
			lblMainWelcome.setText("Welcome to your account " + AccountLists.get(count-1).GetAccountName());
			JOptionPane.showMessageDialog(null, "Your Account Number is : " + userAccount + " Write it down and save it!");
			txtName.setText(userName);
			txtAcNumber.setText(userAccount);
			layout.show(Cont, "Login");
			break;
			
		case "Have an Account":
			layout.show(Cont, "Login");
			break;
			
		case "Login":
			btnSubmit.setText("Submitted!");
			btnSubmit.setEnabled(false);
			userName = txtName.getText();
			userAccount = txtAcNumber.getText();
			boolean checks = false;
			//check if user has an account already
			for(BankAccount account : AccountLists)
			{
				if(account.CheckForInfo(userName, userAccount))
				{
					checks = true;
				}
			}
			if(checks)
			{layout.show(Cont, "Main");
			break;}
			JOptionPane.showMessageDialog(null, "ERROR No Account With That Name or Account Number! Please Try again Or Register");
			break;
			
		case "Deposit":
			lblInfo.setVisible(false);
			amount =  Double.parseDouble(JOptionPane.showInputDialog("How Much Would You Like To Deposit?"));
			AccountLists.get(count-1).Deposit(amount);
			break;
			
		case "Withdraw":
			lblInfo.setVisible(false);
			amount =  Double.parseDouble(JOptionPane.showInputDialog("How Much Would You Like To Withdraw?"));
			AccountLists.get(count-1).Withdraw(amount,userAccount,userName);
			break;
		case"Account Info":
			lblInfo.setText(AccountLists.get(count-1).DisplayAccountInfo());
			btnDisplay.setText("Account Infos");
			lblInfo.setVisible(true);
			break;
		case"Account Infos":
			btnDisplay.setText("Account Info");
			lblInfo.setVisible(false);
			break;
		case "Exit":
			System.exit(0);
			break;
		}//End of Switch
	}
	public String getUserName()
	{
		return userName;
	}
	public String getUserAccount()
	{
		return userAccount;
	}
	public void setAccountNum(String num)
	{
		userAccount = num;
	}
}
