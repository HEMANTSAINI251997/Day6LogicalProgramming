using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("\n" + "1.FibonacciSeries" + "\n");
                    Console.WriteLine("\n" + "2.For EXIT" + "\n");
                    Console.WriteLine("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            FibonacciSeries series = new FibonacciSeries();
                            series.Checkfibonacci();
                            break;
                        case 2:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Please enter correct Choice");
                            break;

                    }
                }
            }

        }
    }

}
