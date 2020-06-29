/*Name: Manpreet Kaur
 Student Number: 991342529
 Description: Midterm Assignment*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillingApp
{
	//This class is for Bill Information Page. It store all the infomation required for billing, it calculates bill,
	//display the bills

	//class for the Table Bill
    public class TableBill
    {
		//this variable generated the automated countere for bill
		private static int countBill = 1;

		//this vaariable sets the constant value fot Tax which is 13% and cannot be changed
		private const decimal TAX_RATE = 0.13M; 

		
		private int bill_Number;

		//this list holds all the items for menu
		private List<MenuItems> menu_Items_all;

		//holds the information about waiter name
		private string waiter_Name;

		//this holds the information about the total bill amount 
		private decimal bill_Total_Amount;

		//This holds information about the tax amount
		private decimal tax_amount;

		//holds the infomation about bill numbers using geters and setters
		public int Bill_Number
		{
			get { 
				return bill_Number; 
			}
			set { 
				bill_Number = value;
			}
		}//bill number ends


		

		//holds the infomation about all the menu items using geters and setters
		public List<MenuItems> Menu_Items_All
		{
			get { 
				return menu_Items_all; 
			}
			set {
				menu_Items_all = value;
			}
		}//menu_Items_all ends


		//holds the information about the table number
		private int table_Number;

		public int Table_Number
		{
			get {
				return table_Number; 
			}
			set { 
				table_Number = value;
			}
		}//table number ends 

		

		public string Waiter_Name
		{
			get {
				return waiter_Name;
			}
			set { 
				waiter_Name = value; 
			}
		}//waiter name ends


		

		public decimal Bill_Total_Amount
		{
			get
			{
				//calling the method to calculate the bill and return the total
				Calculate_Bill_Total(); 
				return bill_Total_Amount;
			}
		}


		

		public decimal Tax_Amount
		{
			get 
			{
				//calling the method to calculate the total amount of taxes and return thte final amount
				Calculate_Bill_Total(); 
				return tax_amount; 
			}
		}

		//Method that is calculating the total bill
		private void Calculate_Bill_Total()
		{
			//if user select at least one item from menu and it is not null 
			if (menu_Items_all != null && menu_Items_all.Count >0)
			{
				//intial bill is 0
				decimal total_bill = 0;

				//using the LINQ here to sum up the values
				total_bill = (
					     from mi in menu_Items_all
						 select mi.Item_Price
						 ).Sum();

				//total amount to select items
				bill_Total_Amount = total_bill;
			}

			//applying the taxes on total amount
			tax_amount = bill_Total_Amount * TAX_RATE;
		}

		

		//constructotr of class that sets the values for variables
		public TableBill()
		{
			menu_Items_all = new List<MenuItems>();

			//sets the bill number
			bill_Number = countBill;
			
			//incrase the number after every order
			countBill++;
			
			//setting the initial values to be 0
			bill_Total_Amount = 0;
			tax_amount = 0;
		}

		// Overloaded constructor for additional functionality
		public TableBill(int table_Number, string waiter_Name)
		{
			
			//sets the values for table number and waiter's name
			this.table_Number = table_Number;
			this.waiter_Name = waiter_Name;

			menu_Items_all = new List<MenuItems>();
			bill_Number = countBill;   
			countBill++;             
			bill_Total_Amount = 0;
			tax_amount = 0;
		}

		//method that prints the information bill information
		public override string ToString()
		{
			//calling the method to calculate the bill
			Calculate_Bill_Total();

			//building a string output usinf format specifiers
			string output = (
				            "Bill Number:".PadRight(30)
							+ (DateTime.Now.ToString("MM-dd-yyyy")
							+ "/" + bill_Number.ToString("D4")).PadRight(30)
							+ "\n"
							+ "\n\nTable Number:".PadRight(30)
							+ table_Number.ToString("D4").PadRight(30) 
							+ "\n"
							+ "Waiter Name:".PadRight(30) 
							+ waiter_Name.PadRight(30) 
							+ "\n"
							+ "\n"
							+ "\n"
							+ "\nItems Selected from Menu:\n"
							+ "****************************************\n"
							+ "\n"
							);
			
			
			//using the foreach loop to generate the output
			foreach(MenuItems menuItem in menu_Items_all)
			{
				output += menuItem.ToString() + "\n";
			}

			//Add the subtotal to the output
			output += "\nSub Total:".PadRight(30) 
				      + Bill_Total_Amount.ToString("C2").PadRight(30);


			//Add the Taxes to the output
			output += "\nTax (13%):".PadRight(30) +
				       Tax_Amount.ToString("C2").PadRight(30);
			output += "\n---------------------------------------";

			//Add the total to output
			output += "\nTotal:".PadRight(30) 
				      + (Bill_Total_Amount + Tax_Amount).ToString("C2").PadRight(30);
			return output;
		}
	}
}
