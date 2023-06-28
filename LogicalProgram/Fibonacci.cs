using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public void Checkfibonacci()
        {

            Console.WriteLine("Enter the number of terms to generate in the series ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");
            int firstTerm = 0;
            int secondTerm = 1;

            Console.Write(firstTerm + " " + secondTerm);

            for (int val = 2; val < num; val++)
            {
                int nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
                Console.Write(" " + nextTerm);
            }
        }
    }

}
