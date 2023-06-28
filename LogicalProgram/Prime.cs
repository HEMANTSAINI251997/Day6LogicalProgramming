using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Prime
    {
        public void Checkprime()
        {
            Console.WriteLine("ENTER THE NUMBER");
            int num = Convert.ToInt32(Console.ReadLine());
            bool Is_prime = true;
            if (num > 1)
            {
                for (int val = 2; val <= num / 2; val++)
                {
                    if (num % val == 0)
                    {
                        Is_prime = false;
                        break;
                    }
                }
                if (Is_prime == true)
                {
                    Console.WriteLine("It is a Prime Number: " + num);
                }
                else
                {
                    Console.WriteLine("Its is not a Prime Number:" + num);
                }
            }
            else 
            { 
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
