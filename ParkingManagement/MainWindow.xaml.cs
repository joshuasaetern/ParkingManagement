using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ParkingManagement
{
    /// Joshua Saetern
    /// 05.05.2024
    /// Computer Programming II
    /// Assignment: Classes, Lists, and All of our controls
    public partial class MainWindow : Window
    {
        //List to hold cards
        List<Vehicle> vehicles = new List<Vehicle>();
        public MainWindow()
        {
            InitializeComponent();

            //Set the source of our ComboBox
            comboBoxVehicles.ItemsSource = vehicles;
        }

        public bool AddVehicle()
        {
            //Makes sure all conditions are met to register a vehicle
            String make = txtBoxMake.Text;
            String model = txtBoxModel.Text;
            String license = txtBoxLicense.Text;
            //Checks to make sure Year is a number
            //License plate length must be < 9 
            if (String.IsNullOrWhiteSpace(make) || String.IsNullOrWhiteSpace(model) || String.IsNullOrWhiteSpace(license))
            {
                MessageBox.Show("Please make sure all boxes are filled");
                return false;
            }
            if (license.Length > 8)
            {
                MessageBox.Show("Please make sure License Plate no more than 8 characters");
                return false;

            }
            try
            {
                //All conditions are met
                int year = int.Parse(txtBoxYear.Text);
                vehicles.Add(new Vehicle(make, model, year, license));
                comboBoxVehicles.Items.Refresh();
                MessageBox.Show("Congratulations your Vehicle has been registered!");
                return true;
            }
            catch
            {
                MessageBox.Show("Please enter a valid Year");
                return false;
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            AddVehicle();
        }

        private void comboBoxVehicles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            richTxtBoxVehicles.Text = vehicles[comboBoxVehicles.SelectedIndex].PrintVehicle();
            
            comboBoxVehicles.ItemsSource = vehicles;
        }
    }
}