using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC.Model
{
    public class Tip
    {
        private double amount;
        private double percent;
        private double Amount { get; set; }
        public double Percent
        {
            get { return this.percent; }
            set
            {
                if (value > 1)
                {
                    this.percent = value / 100.0;
                }
                else
                {
                    this.percent = value;
                }
            }
        }
        public Tip(double amount, double percent)
        {
            Amount = amount;
            Percent = percent;
        }
        public Tip() : this(0, 0) { }

        public double CalculateTip() //пресмята бакшиша
        {
            return Amount * Percent;
        }
        public double CalculateTotal() //пресмята общата сметка заедно с бакшиша
        {
            return CalculateTip() + Amount;
        }
    }
}
