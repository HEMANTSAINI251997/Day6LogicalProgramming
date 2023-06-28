using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PerfectNumber
    {
        public void Checkperfectnumber()
        {
            int sum = 0;
            Console.WriteLine("ENTER THE NUMBER ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int val =1; val<num; val++)
            {
                if (num % val == 0)
                {
                    sum+=val;
                    Console.WriteLine(val);            
                }
            }
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Number = " + num);
            if (sum == num)
            {
                Console.WriteLine("It is a Perfect Number");
            }
            else 
            { 
                Console.WriteLine("It is not a Perfect Number"); 
            }
        }
    }
}
