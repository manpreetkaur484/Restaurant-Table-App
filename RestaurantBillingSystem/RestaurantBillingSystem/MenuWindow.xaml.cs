using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

/*Name: Manpreet Kaur
 Student Number: 991342529
 Description: Midterm Assignment*/

namespace RestaurantBillingApp
{
    //cs file for MenuWindow.xaml 
    public partial class MenuWindow : Window
    {
        //Using Observale collections to store the different categories of the menu
        ObservableCollection<MenuItems> beverageItems;
        ObservableCollection<MenuItems> mainCourseItems;
        ObservableCollection<MenuItems> appetizerItems;
        ObservableCollection<MenuItems> dessertItems;

        public MenuWindow()
        {
            InitializeComponent();
        }

        //this method all the all items in the menu lists
        private void LoadMenuItems()
        {
            beverageItems = new ObservableCollection<MenuItems>();

            appetizerItems = new ObservableCollection<MenuItems>();

            mainCourseItems = new ObservableCollection<MenuItems>();

            dessertItems = new ObservableCollection<MenuItems>();

             

            //adding all the values for beverage category

            //adding all the items one by one
            MenuItems menuItem = new MenuItems("Soda", "Beverage", 1.95M);
            beverageItems.Add(menuItem);

            menuItem = new MenuItems("Tea", "Beverage", 1.50M);
            beverageItems.Add(menuItem);

            menuItem = new MenuItems("Coffee", "Beverage", 1.25M);
            beverageItems.Add(menuItem);

            menuItem = new MenuItems("Mineral Water", "Beverage", 2.95M);
            beverageItems.Add(menuItem);

            menuItem = new MenuItems("Juice", "Beverage", 2.50M);
            beverageItems.Add(menuItem);

            menuItem = new MenuItems("Milk", "Beverage", 1.50M);
            beverageItems.Add(menuItem);

            //load the combo box for beverages
            listBeverage.DataContext = beverageItems;

            //adding all the values for mainCourse category
            menuItem = new MenuItems("Chicken Alfredo", "Main Course", 13.95M);
            mainCourseItems.Add(menuItem);

            menuItem = new MenuItems("Chicken Picatta", "Main Course", 13.95M);
            mainCourseItems.Add(menuItem);

            menuItem = new MenuItems("Turkey Club", "Main Course", 11.95M);
            mainCourseItems.Add(menuItem);

            menuItem = new MenuItems("Lobster Pie", "Main Course", 19.95M);
            mainCourseItems.Add(menuItem);

            menuItem = new MenuItems("Prime Rib", "Main Course", 20.95M);
            mainCourseItems.Add(menuItem);

            menuItem = new MenuItems("Shrimp Scampi", "Main Course", 18.95M);
            mainCourseItems.Add(menuItem);

            menuItem = new MenuItems("Turkey Dinner", "Main Course", 13.95M);
            mainCourseItems.Add(menuItem);

            menuItem = new MenuItems("Stuffed Chicken", "Main Course", 14.95M);
            mainCourseItems.Add(menuItem);

            menuItem = new MenuItems("Seafood Alfredo", "Main Course", 15.95M);
            mainCourseItems.Add(menuItem);

            //load the combo box for mainCourse
            listMainCourse.DataContext = mainCourseItems;


            //adding all the values for appetizer category
            menuItem = new MenuItems("Buffalo Wings", "Appetizer", 5.95M);
            appetizerItems.Add(menuItem);

            menuItem = new MenuItems("Buffalo Fingers", "Appetizer", 6.95M);
            appetizerItems.Add(menuItem);

            menuItem = new MenuItems("Potato Skins", "Appetizer", 9.95M);
            appetizerItems.Add(menuItem);

            menuItem = new MenuItems("Nachos", "Appetizer", 8.95M);
            appetizerItems.Add(menuItem);

            menuItem = new MenuItems("Mushroom Caps", "Appetizer", 10.95M);
            appetizerItems.Add(menuItem);

            menuItem = new MenuItems("Shrimp Cocktail", "Appetizer", 12.95M);
            appetizerItems.Add(menuItem);

            menuItem = new MenuItems("Chips and Salsa", "Appetizer", 6.95M);
            appetizerItems.Add(menuItem);

            //load the combo box for appetizers
            listAppetizer.DataContext = appetizerItems;

            //adding all the values for dessert category
            menuItem = new MenuItems("Apple Pie", "Dessert", 5.95M);
            dessertItems.Add(menuItem);
            menuItem = new MenuItems("Sundae", "Dessert", 3.95M);
            dessertItems.Add(menuItem);
            menuItem = new MenuItems("Carrot Cake", "Dessert", 5.95M);
            dessertItems.Add(menuItem);
            menuItem = new MenuItems("Mud Pie", "Dessert", 4.95M);
            dessertItems.Add(menuItem);
            menuItem = new MenuItems("Apple Crips", "Dessert", 5.95M);
            dessertItems.Add(menuItem);

            // Load into combobox for deserts items
            listDessert.DataContext = dessertItems;
        }

        //this method collects all the items selected throught check boxes and add them to the table bill
        private void viewOrderButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //using the foreach loop to get the selected beverages from the list
                foreach(var item in listBeverage.Items)
                {
                    //creating a list for new found items
                    MenuItems menuItems = (MenuItems)item;
                    if (menuItems.IsSelected)
                    {
                        //add the items to Table bill
                        ((TableBill)this.Tag)
                            .Menu_Items_All.
                            Add(menuItems);
                    }
                }//foreach beverages


                //using the foreach loop to get the selected appetizers from the list
                foreach (var item in listAppetizer.Items)
                {
                    //creating a list for new found items
                    MenuItems menuItems = (MenuItems)item;
                    if (menuItems.IsSelected)
                    {
                        //add the items to Table bill
                        ((TableBill)this.Tag)
                            .Menu_Items_All.
                            Add(menuItems);
                    }
                }//foreach appetizers


                //using the foreach loop to get the selected mainCOURSE from the list
                foreach (var item in listMainCourse.Items)
                {
                    //creating a list for new found items
                    MenuItems menuItems = (MenuItems)item;
                    if (menuItems.IsSelected)
                    {
                        //add the items to Table bill
                        ((TableBill)this.Tag)
                            .Menu_Items_All
                            .Add(menuItems);
                    }
                }//foreach maincourse


                //using the foreach loop to get the selected desserts from the list
                foreach (var item in listDessert.Items)
                {
                    //creating a list for new found items
                    MenuItems menuItems = (MenuItems)item;
                    if (menuItems.IsSelected)
                    {
                        //add the items to Table bill
                        ((TableBill)this.Tag).Menu_Items_All.Add(menuItems);
                    }
                }//foreach desserts


                // if user select atleast one item from the menu then generate the bill
                if (((TableBill)this.Tag).Menu_Items_All.Count > 0)
                {
                    //this window displays the bill information
                    BillWindow billWindow = new BillWindow();

                    billWindow.Tag = ((TableBill)this.Tag);     
                    this.Hide(); 
                    
                    //show the bill information
                    billWindow.ShowDialog();               

                    //closes the window
                    this.Close();                       
                }

                //if user does not select anything from the bill
                else
                {
                   //this  message box display the error message
                    MessageBox.Show("Select atleast one item to generate bill!");
                }
            }


            catch (Exception exeception)
            {
                MessageBox.Show(exeception.Message);
            }
        }

        //if the clear button is clicked the clear all the fields
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            Reset_All_Fields();
        }

        // if the close button is clicked the exit the window
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //if user select the reset button, this methods sets the values for all checkboxes to be false
        private void Reset_All_Fields()
        {
            foreach (var items in beverageItems)
            {
                items.IsSelected = false;
            }
            foreach (var items in appetizerItems)
            {
                items.IsSelected = false;
            }
            foreach (var items in mainCourseItems)
            {
                items.IsSelected = false;
            }
            foreach (var items in dessertItems)
            {
                items.IsSelected = false;
            }

            billNumber.Content = "TableBill Number: ";
        }

        //load the window
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadMenuItems(); 

            try
            {
                // Display bill number with current date
                billNumber.Content = (
                    "Date/Bill Number: " 
                    + DateTime.Now.ToString("MM-dd-yyyy") 
                    + "/"
                    + ((TableBill)this.Tag).Bill_Number.ToString("D4")
                    );
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
