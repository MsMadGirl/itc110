using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTipCalculator
{
    class Bill
    {

        private double amount;//field for amount
        private double tip;//field for tip

        public double Amount//
        {
            set
            {
                amount = value;
            }//end set amount

            get
            {
                return amount;
            }//end get amount
        }//end Amount

        public double Tip
        {
            set
            {
                tip = value;
            }//end set tip

            get
            {
                return tip;
            }//end get tip
        }//end Tip

        public double CalcTax()
        {
            double taxPercent = 0.09;

            return taxPercent * amount;
        }//end CalcTax

        public double CalcTip(double tip)
        {
            return (amount + CalcTax()) * tip;
        }//end CalcTip

        public double CalcTotal()
        {
            return CalcTax() + CalcTip(tip) + amount;
        }//end CalcTotal

        public Bill()//constructor 1
        {
            Amount = 0;
            Tip = 0;
        }//end constructor 1

        public Bill(double mealAmount, double tipPercent)//constructor 2
        {
            Amount = mealAmount;
            Tip = tipPercent;
        }//end constructor 2


    }//end Bill
}//end namespace
