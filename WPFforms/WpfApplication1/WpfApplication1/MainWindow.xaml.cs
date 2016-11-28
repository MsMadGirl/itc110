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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }



        private void buttonSubmit_Click_1(object sender, RoutedEventArgs e)
        {
            Mileage m = new WpfApplication1.Mileage();
            m.Miles = double.Parse(enterMileage.Text);
            m.Gallons = double.Parse(enterGallons.Text);

            int tank;
            if (radio10gal.IsChecked == true)
            {
                tank = 10;
            }

            else if (radio15gal.IsChecked == true)
            {
                tank = 15;
            }

            else if (radio20gal.IsChecked == true)
            {
                tank = 20;
            }

            else
            {
                tank = int.Parse(textBoxOther.Text);
            }

            double range = m.GetRange(tank);

            labelResult.Content = "Your MPG is " + m.GetMilesPerGallon().ToString() + " Your range is " + range.ToString();
        }
    }
}
