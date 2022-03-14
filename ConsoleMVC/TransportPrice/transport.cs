using System;

namespace TransportPrice
{
    class transport
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double taxi = 0.70;
            double train = 0.06;
            double bus = 0.09;

            

            switch (dayOrNight)
            {
                case "day":
                    if (n < 20)
                    {
                        double trnsprt1 = taxi + n * 0.79;
                        Console.WriteLine(trnsprt1);
                    }

                    else if (n >= 20 && n < 100)
                    {
                        double trnsprt2 = n * bus;
                        Console.WriteLine(trnsprt2);
                        
                        
                    }

                    else if (n >= 100)
                    {
                        double trnsprt3 = n * train;
                        Console.WriteLine(trnsprt3);
                    }
                    break;


                case "night":
                    if (n < 20)
                    {
                        double trnsprt1 = taxi + n * 0.90; 
                        Console.WriteLine(Math.Floor(trnsprt1));
                    }

                    else if (n >= 20 && n < 100)
                    {
                        double trnsprt2 = n * bus; 
                        Console.WriteLine(Math.Floor(trnsprt2));
                    }

                    else if (n > 100)
                    {
                        double trnsprt3 = n * train;
                        Console.WriteLine(Math.Floor(trnsprt3));
                    }
                    break;

            }
        }
    }
}
