package Assignment3;   //Assignment 3 package+6

import java.io.IOException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;

public class test {
	static Scanner read  = new Scanner(System.in);
	private static client c = new client();
	public static void main(String[] args) throws SQLException, IOException{
		c.connectDB();
		String key = "";
		while(key.toUpperCase() != "X"){
			MainMenu();
			key = read.next().toUpperCase();
			checkMenuInput(key);
		}
	}
	
	//MainMenu function with print methods
	public static void MainMenu(){
		System.out.println("This is a Tester for the JConnector that connects a Java Program and a MySQL Database");
		System.out.println("Press 'A' to add a client to the database");
		System.out.println("Press 'V' to view all clients");
		System.out.println("Press 'G' to get a specific client");
		System.out.println("Press 'D' to delete a client");

	}
	
	//checkMenuInput checks key input and calls respective method
	public static void checkMenuInput(String key) throws SQLException, IOException{
		if(key.equals("A")){
			System.out.println("Enter TRN number");
			c.setTRN(read.nextInt());
			System.out.println("Enter First Name");
			c.setfName(read.next());
			System.out.println("Enter Last Name");
			c.setlName(read.next());
			System.out.println("Enter Branch");
			c.setBranch(read.next());
			System.out.println("Enter Account Type");
			c.setAccount_Type(read.next());
			System.out.println("Enter Account Balance");
			c.setCurrent_Balance(read.nextDouble());
			c.addClient(c.getTRN(), c.getfName(), c.getlName(), c.getBranch(), c.getAccount_Type(), c.getCurrent_Balance());
			System.in.read();
		}
		else if(key.equals("V")){
			ResultSet r = c.getAllClients();
			int count = 0;
		       System.out.println ("TRN \t FName \t LName \t Branch   Acc_Type       Acc_bal");
			   while (r.next ())
			   {
			       int trn = r.getInt ("trn");
			       String f = r.getString ("fname");
			       String l = r.getString ("lname");
			       String branch = r.getString("branch");
			       String Acc_Type = r.getString("account_type");
			       Double acc_bal = r.getDouble("current_balance");

			       System.out.println(trn + " \t " + f + " \t " + l + " \t " + branch + " \t " + Acc_Type + " \t " + acc_bal);
			       ++count;
			   }
			   System.out.println("Number of rows retrieved is " + count );
				System.in.read();
		}
		else if(key.equals("D")){
			System.out.println("Record to delete");
			c.deleteClient(read.nextInt());
			
			System.out.println("Record deleted successfully");
			System.in.read();
		}
		else if(key.equals("G")){
			ResultSet r = c.getClient(read.nextInt());
			r.first();
			System.out.println("Enter Record to view");
			System.out.println ("TRN \t FName \t LName \t Branch   Acc_Type       Acc_bal");
		       int trn = r.getInt ("trn");
		       String f = r.getString ("fname");
		       String l = r.getString ("lname");
		       String branch = r.getString("branch");
		       String Acc_Type = r.getString("account_type");
		       Double acc_bal = r.getDouble("current_balance");

		       System.out.println(trn + " \t " + f + " \t " + l + " \t " + branch + " \t " + Acc_Type + " \t " + acc_bal);
				System.in.read();
		}
	}
}
