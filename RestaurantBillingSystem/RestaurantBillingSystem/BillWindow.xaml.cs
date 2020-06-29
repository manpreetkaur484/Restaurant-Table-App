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
using System.Windows.Shapes;

/*Name: Manpreet Kaur
 Student Number: 991342529
 Description: Midterm Assignment*/


namespace RestaurantBillingApp
{
   
    public partial class BillWindow : Window
    {
        public BillWindow()
        {
            InitializeComponent();
        }

        // this display the information about the bill
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            billField.Text = ((TableBill)this.Tag).ToString();
        }

        // if user click the exit button close the window
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
