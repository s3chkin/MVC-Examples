using System;
using ConsoleMVC.Model;
using System.Collections.Generic;
using System.Text;
using ConsoleMVC.Views;

namespace ConsoleMVC.Controlers
{
    class TipCalculatorController
    {
        public Tip tip;
        public Display display;
        public TipCalculatorController()
        {
            display = new Display();
            tip = new Tip(display.Amount,display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipAndTotal();
        }
    }
}
