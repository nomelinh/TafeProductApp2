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

namespace ProductApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product cProduct;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Calculate Button Click Event
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Convert price and quantity entered by the user
                decimal price = Convert.ToDecimal(priceTextBox.Text);
                int quantity = Convert.ToInt32(quantityTextBox.Text);

                // Calculate total payment
                decimal totalPayment = price * quantity;
                totalPaymentTextBlock.Text = totalPayment.ToString("C"); // Display as currency

                // Add delivery charge ($25)
                decimal deliveryCharge = 25.00M;
                decimal totalCharge = totalPayment + deliveryCharge;

                // Display the total charge
                TotalChargeTextBox.Text = totalCharge.ToString("C"); // Display as currency
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid data for price and quantity.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Clear Button Click Event
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear all input fields and results
            productTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPaymentTextBlock.Text = "";
            TotalChargeTextBox.Text = "";
        }

        // Close Button Click Event
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the application
            this.Close();
        }
    }

}
