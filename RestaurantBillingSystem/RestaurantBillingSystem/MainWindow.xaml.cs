using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

/*Name: Manpreet Kaur
 Student Number: 991342529
 Description: Midterm Assignment*/

namespace RestaurantBillingApp
{
   
    public partial class MainWindow : Window
    {
        // Collection that store the list of table bills
        private List<TableBill> bills;
        public MainWindow()
        {
            InitializeComponent();
            bills = new List<TableBill>();
            TableNumber.Focus();
        }

        //method that perform ok button function from main window
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            //check for valid input from user
            if (ValidateInputs())
            {
                //create a new list for bills
                TableBill bill = new TableBill();

                bill.Table_Number = Convert.ToInt32(TableNumber.Text);
                bill.Waiter_Name = WaiterName.Text;

                bills.Add(bill);

                
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.Tag = bill;              
                this.Hide();                
                menuWindow.ShowDialog();            

                // Clear input fields 
                TableNumber.Clear();
                WaiterName.Clear();
                TableNumber.Focus();

                //main windnow
                this.ShowDialog();  
            }
        }

        // if user click the cancel button then close the application
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       //method that validates the user input
        private bool ValidateInputs()
        {
            //if number feild is empty
            if (string.IsNullOrEmpty(TableNumber.Text))
            {
                //message box display the error
                MessageBox.Show("Table number Empty! Please enter again!");
                TableNumber.Focus();
                return false;
            }

            //check for numeric number 
            try
            {
                int num = Convert.ToInt32(TableNumber.Text);
            }
            catch (Exception ex)
            {
                //message box display the error
                MessageBox.Show("Wrong Input! Number must be a numeric value.");
                TableNumber.SelectAll();
                return false;
            }

            //check if waiter name is empty
            if (string.IsNullOrEmpty(WaiterName.Text))
            {
                //message box display the error
                MessageBox.Show("Waiter name is empty! Please enter waiter's name.");
                WaiterName.Focus();
                return false;
            }

            return true;
        }
    }
}
