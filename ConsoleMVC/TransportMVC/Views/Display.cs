using System;
using System.Collections.Generic;
using System.Text;

namespace TransportMVC.Views
{
    public class Display
    {
        public int Distance { get; set; }
        public string Time { get; set; }
        public double PriceTransport { get; set; }
        public Display()
        {
            Distance = 0;
            Time = " ";
            PriceTransport = 0.0;
            SumPrice();
        }
        public void SumPrice()
        {
            Console.Write("Enter Distance: ");
            this.Distance = int.Parse(Console.ReadLine());
            Console.Write("Enter 'Day' or 'Night': ");
            this.Time = Console.ReadLine();
        }

        public void Result()
        {
            Console.WriteLine($"Price is {PriceTransport}");
        }
    }
}
