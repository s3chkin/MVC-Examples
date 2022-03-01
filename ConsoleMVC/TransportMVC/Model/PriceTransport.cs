using System;
using System.Collections.Generic;
using System.Text;

namespace TransportPrice
{
    public class PriceTransport
    {
        public int Distance { get; set; }
        public string Time { get; set; }

        //int N = int.Parse(Console.ReadLine()); //Разстояние
        //string Time = Console.ReadLine(); //ден или нощ
        //double Price = int.Parse(Console.ReadLine()); //цена

        public PriceTransport(int distance, string time)
        {
            this.Distance = distance;
            this.Time = time;
        }
        public double CalculatePriceTransport()
        {
            switch (this.Time)
            {
                case "day":
                    if (Distance < 20)
                    {
                        double trnsprt1 = 0.70 + Distance * 0.79;
                        Console.WriteLine(trnsprt1);
                    }

                    else if (Distance >= 20 && Distance < 100)
                    {
                        double trnsprt2 = Distance * 0.09;
                        Console.WriteLine(trnsprt2);


                    }

                    else if (Distance >= 100)
                    {
                        double trnsprt3 = Distance * 0.06;
                        Console.WriteLine(trnsprt3);
                    }
                    break;


                case "night":
                    if (Distance < 20)
                    {
                        double trnsprt1 = 0.70 + Distance * 0.90;
                        Console.WriteLine(Math.Floor(trnsprt1));
                    }

                    else if (Distance >= 20 && Distance < 100)
                    {
                        double trnsprt2 = Distance * 0.09;
                        Console.WriteLine(Math.Floor(trnsprt2));
                    }

                    else if (Distance > 100)
                    {
                        double trnsprt3 = Distance * 0.06;
                        Console.WriteLine(Math.Floor(trnsprt3));
                    }
                    break;

            }
            return CalculatePriceTransport();

        }


    }
}
