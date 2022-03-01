using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC.Views
{
    public class Display
    {
        public double Percent { get; set; } //input
        public double Amount { get; set; } //input
        public double Total { get; set; } //output
        public double TipAmount { get; set; } //output

        public Display()
        {
            this.Percent = 0;
            this.Amount = 0;
            this.Total = 0;
            this.TipAmount = 0;
            GetValues();
        }

        private void GetValues()
        {
            Console.WriteLine("Enter the amount of the meal:");
            this.Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percent you want to tip: ");
            this.Percent = double.Parse(Console.ReadLine());
        }
        public void ShowTipAndTotal()
        {
            Console.WriteLine($"Your tip is: {this.TipAmount:C}");
            Console.WriteLine($"Your total will be: {this.Total:C}");
        }





    }
}
