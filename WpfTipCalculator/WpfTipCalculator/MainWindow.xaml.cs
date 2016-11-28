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

namespace WpfTipCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }//end MainWindow

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }//end radioButton_checked

        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            Bill b = new Bill();
            b.Amount = double.Parse(boxMealAmount.Text);

            double tip = 0;

            if (radio_10.IsChecked == true)
            {
                tip = .1;
            }//end if

            else if (radio_15.IsChecked == true)
            {
                tip = .15;
            }//end else if 1
        
            else if (radio_20.IsChecked == true)
            {
                tip = .2;
            }//end else if 2



            labelResult.Content = "Your tax is " + b.CalcTax().ToString() + ", your tip is " + b.CalcTip(tip).ToString() + ", and your total is " + b.CalcTotal().ToString() + ".";

            

        }//end buttonCalculate_Click
    }//end partial class
}//end namespace
