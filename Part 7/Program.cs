using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[2];

            //names[0] = "John Doe";
            //names[1] = "Jane Doe";

            //for (int i =0; i < names.Length; i++)
            //Console.WriteLine("Item number " + i + ": " + names[i]);
            Random generator = new Random();
            int[] numbers = new int[30];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = generator.Next(1, 101);
            foreach (int i in numbers)
                Console.Write($" {i}"); 
            Console.ReadLine();
        }
    }
}
