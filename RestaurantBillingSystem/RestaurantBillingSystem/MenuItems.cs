using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Name: Manpreet Kaur
 Student Number: 991342529
 Description: Midterm Assignment*/

namespace RestaurantBillingApp
{
	//This class stores the information about the menu items, It includes everything that is required to display a menu that restaurant offers
	public class MenuItems : INotifyPropertyChanged
	{
		
		//declaring the variables
		private string category_name;
		private string item_Name;
		private decimal item_Price;
		private bool is_Selected_value;
		public event PropertyChangedEventHandler PropertyChanged;


		//getters and setters
		public string Item_Name
		{
			get {
				return item_Name; 
			}
			set { 
				item_Name = value; 
			}
		}//item_Name

		public string Category_Name
		{
			get { 
				return category_name; 
			}
			set { 
				category_name = value; 
			}
		}//cactegory name

		

		public decimal Item_Price
		{
			get {
				return item_Price; 
			}
			set {
				item_Price = value; 
			}
		}//item price

		

		public bool IsSelected
		{
			get { 
				return is_Selected_value; 
			}
			set 
			{ 
				is_Selected_value = value;
				Property_Changed();
			}
		}

		// constructor
		public MenuItems()
		{
			//initial menu items are false
			is_Selected_value = false; 
		}

		//overloaded constructor for additonal functionality
		public MenuItems(string item_Name, string category_Name, decimal item_Price)
		{
			this.item_Name = item_Name;
			this.category_name = category_Name;
			this.item_Price = item_Price;
			is_Selected_value = false;
		}

		// display the formatted string
		public override string ToString()
		{
			return item_Name.PadRight(30)
				+ item_Price.ToString("C2").PadRight(30);
		}

		
		
		private void Property_Changed(string propertyName = "")
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
