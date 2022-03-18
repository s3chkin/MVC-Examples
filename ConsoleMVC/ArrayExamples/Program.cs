using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
                //if (nums[i] == nums[i])
                //{
                //    Console.WriteLine("Има еднакви!");
                //}
                //else if (nums[i] != nums[i])
                //{
                //    Console.WriteLine("“No occurrences were found!”.");
                //}
                if (nums[i] == nums[i] )
                {
                    Console.Write("  Има еднакви! ");

                }
            }

            //if (nums[0] == nums[i] || nums[1] == nums[1] || nums[2] == nums[2] || nums[3] == nums[3]
            //    || nums[3] == nums[3] || nums[4] == nums[4] || nums[5] == nums[5]
            //    || nums[6] == nums[6])
            //{
            //    Console.WriteLine("Има еднакви!");
            //}
            //else
            //{
            //    Console.WriteLine("Nyama еднакви!");
            //}


        }
    }
}
