/*
 * Created by SharpDevelop.
 * User: User
 * Date: 5/1/2018
 * Time: 1:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;

namespace MyApp
{
	class Program
	{
		public static void Main(string[] args)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("user id=sa;" + 
                                       "password=sa123;server=USER-PC\\SQLEXPRESS;" + 
                                       "Trusted_Connection=yes;" + 
                                       "database=customers; " + 
                                       "connection timeout=30");
			try {
				conn.Open();
			}
			catch(Exception e) {
				Console.WriteLine("Error:" + e.ToString());
			}
			
			try
			{
			    SqlDataReader myReader = null;
			    SqlCommand    myCommand = new SqlCommand("select * from customer_data", conn);
			    myReader = myCommand.ExecuteReader();
			    
			    Console.WriteLine("First Name | Last Name");
			    while(myReader.Read())
			    {
			        Console.WriteLine(myReader["firstname"].ToString() + " | " + myReader["lastname"].ToString() );			        
			    }
			}
			catch (Exception e)
			{
			    Console.WriteLine(e.ToString());
			}			
			
			Console.ReadKey(true);
		}
	}
}