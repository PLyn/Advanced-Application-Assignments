/*Assignment 3 : Interoperability
 * By : Peter Lyn (26100068)
 * & Joel Hyman (26100088)
 * 
 * From Mr. Damion Mitchell
 * 
 * Date: 6/9/14
*/
package Assignment3;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class client {
	private int TRN;
	private String fName;
	private String lName;
	private String branch;
	private String account_Type;
	private double current_Balance;
	
	Connection connect;
	
	/* Description: Default constructor
	 * (Arguments)->return type: (void)->void
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client();
	 */
	public client(){
		
		
	}
	
	/* Description: constructor that receives arguments
	 * (Arguments)->return type: (int,String,String,String,String,double)->void
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(12345,Jane,Doe,Kingston,Savings,78.89);
	 */
	public client(int TRN,String fName, String lName, String branch, String account_Type, double current_balance){
		this.setTRN(TRN);
		this.setfName(fName);
		this.setlName(lName);
		this.setBranch(branch);
		this.setAccount_Type(account_Type);
		this.setCurrent_Balance(current_Balance);
		
	}
	
	
	/* Description: Connects to mySQL database
	 * (Arguments)->return type: (void)->void
	 * Precondition: Database server must be running
	 * Postcondition: Connection to database successful
	 * Example(s): Client c=new Client(); c.connectDB();
	 */
	public void connectDB(){
		try{
			Class.forName("com.mysql.jdbc.Driver");
			connect = DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/mydb?", "root", "root");

		}catch(Exception e){
			e.printStackTrace();
		}
	}	
	
	
	
	/* Description: adds a client to the database
	 * (Arguments)->return type: (int,String,String,String,String,double)->void
	 * Precondition: Database connection was successful and Arguments must match the data types of the parameter list
	 * Postcondition: Data received is stored in database
	 * Example(s): Client c=new Client(); c.connectDB(); c.addClient(45678,Mary,Jane,Mandeville,Savings,76.34);
	 */
	public void addClient(int TRN, String fName, String lName, String branch, String account_Type, double current_Balance) throws SQLException{
			PreparedStatement stmt = connect.prepareStatement("INSERT INTO ClientTable(trn, fname,lname,branch,account_type, current_balance) " +
																"VALUES(?, ? , ?, ? ,? ,?)");
			
			stmt.setInt(1, TRN);
			stmt.setString(2, fName);
			stmt.setString(3, lName);
			stmt.setString(4, branch);
			stmt.setString(5, account_Type);
			stmt.setDouble(6, current_Balance);
			
			stmt.execute();
		
		
	}
	
	
	/* Description: Gets a client data from database based on TRN inputed
	 * (Arguments)->return type: (int)->ResultSet
	 * Precondition: Database connected to successfully and data types passed match parameter list (int TRN)
	 * Postcondition: One result is received from the database
	 * Example(s): Client c=new Client(); c.connectDB(); c.getClient();
	 */
	public ResultSet getClient(int TRN) throws SQLException{
		
		try{
			PreparedStatement stmt=connect.prepareStatement("SELECT * FROM ClientTable WHERE trn = ?");
			
			stmt.setInt(1,TRN);
			
			stmt.execute();
			
			return stmt.getResultSet();
			
			
		}
		catch(Exception e){
			System.out.println("The Record was not found!");
		}
		return null;
	}
	
	
	/* Description: Requests and receives data for all clients in database
	 * (Arguments)->return type: (void)->ResultSet
	 * Precondition: Database connected to successfully
	 * Postcondition: All client data is displayed
	 * Example(s): Client c=new Client(); c.connectDB(); c.getAllClients();
	 */
	public ResultSet getAllClients() throws SQLException{
			PreparedStatement stmt=connect.prepareStatement("SELECT * FROM ClientTable");
			
			stmt.execute();
			return stmt.getResultSet();
	}
	
	/* Description: Deletes a client's data based on TRN input
	 * (Arguments)->return type: (int)->void
	 * Precondition: Successful connection to database and data types match the parameter list (int TRN)
	 * Postcondition: record with TRN input deleted
	 * Example(s): Client c=new Client(); c.connectDB(); c.deleteClient();
	 */
	public void deleteClient(int TRN){
		
		try {
			PreparedStatement stmt= null;
			stmt = connect.prepareStatement("DELETE FROM ClientTable WHERE trn = ? ;");

		  stmt.setInt(1, TRN);
		  
		  stmt.execute();
		}
		
		catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	
	/* Description: gets the current TRN# from TRN variable 
	 * (Arguments)->return type: ()->int  
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(); c.getTRN();
	 */
	public int getTRN() {
		return TRN;
	}
	/* Description: sets the current TRN# to the TRN variable 
	 * (Arguments)->return type: (int)->void  
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(); c.setTRN(2343);
	 */
	public void setTRN(int tRN) {
		TRN = tRN;
	}
	/* Description: gets the current First Name from fName variable 
	 * (Arguments)->return type: ()->String  
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(); c.getfName();
	 */
	public String getfName() {
		return fName;
	}
	/* Description: sets the current First Name to the fName variable 
	 * (Arguments)->return type: (String)->void  
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(); c.setfName("Peter");
	 */
	public void setfName(String fName) {
		this.fName = fName;
	}
	/* Description: gets the current Last Name from lName variable 
	 * (Arguments)->return type: ()->String  
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(); c.getlName();
	 */
	public String getlName() {
		return lName;
	}
	/* Description: sets the current Last Name from lName variable 
	 * (Arguments)->return type: (String)->void  
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(); c.setlName("Hyman");
	 */
	public void setlName(String lName) {
		this.lName = lName;
	}
	/* Description: gets the current branch from branch variable 
	 * (Arguments)->return type: ()->String  
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(); c.getBranch();
	 */
	public String getBranch() {
		return branch;
	}
	/* Description: sets the current Branch from branch variable 
	 * (Arguments)->return type: (String)->void
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(); c.setBranch();
	 */
	public void setBranch(String branch) {
		this.branch = branch;
	}
	/* Description: gets the current account type from account_type variable 
	 * (Arguments)->return type: ()->String
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(); c.getAccount_Type();
	 */
	public String getAccount_Type() {
		return account_Type;
	}
	/* Description: sets the Account Type from Account_Type variable 
	 * (Arguments)->return type: (String)->void   
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(); c.setAccount_Type("savings");
	 */
	public void setAccount_Type(String account_Type) {
		this.account_Type = account_Type;
	}
	/* Description: gets the current balance from current_Balance variable 
	 * (Arguments)->return type: ()->Double 
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(); c.getTRN();
	 */
	public double getCurrent_Balance() {
		return current_Balance;
	}
	/* Description: sets the current balance from current balance variable 
	 * (Arguments)->return type: (Double)->void  
	 * Precondition: None
	 * Postcondition: None
	 * Example(s): Client c=new Client(); c.getTRN();
	 */
	void setCurrent_Balance(double current_Balance) {
		this.current_Balance = current_Balance;
	}
}
