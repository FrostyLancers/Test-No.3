using System;
using System.Linq;

namespace Test_No._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int count;
            double[] Number = new double[999];
            Console.WriteLine("Type <0.0> to End.");
            do
            {
                int count1 = 0;
                count = 0;
                a = 0;
                Number[a] = double.Parse(Console.ReadLine());
                a++;
                count1++;
                count = count + count1;

            } while (Number[count-1] != 0.0);

            Console.Write("Input Mode: ");
            string Mode = Console.ReadLine();

            if (Mode == "FindMax")
            {
                Console.WriteLine(Number.Max());
            }
            else if (Mode == "FindMin")
            {
                Console.WriteLine(Number.Min());
            }
        }
    }
}
