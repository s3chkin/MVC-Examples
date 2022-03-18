using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExampleCross
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firtsDay = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] lastDay = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("\n =====================");

            for (int i = 0; i < firtsDay.Length; i++)
            {

                Console.Write(firtsDay[i] + " ");
                Array.Sort(firtsDay);
            }
            
            for (int i = 0; i < lastDay.Length; i++)
            {
                Console.Write(lastDay[i] + " ");
                Array.Sort(lastDay);

            }
            //Console.WriteLine("\n");
            //var rslt = firtsDay.ToString() + lastDay.ToString();
            //Array.Sort(rslt.ToArray());

            //Console.WriteLine(rslt);


        }
    }
}
