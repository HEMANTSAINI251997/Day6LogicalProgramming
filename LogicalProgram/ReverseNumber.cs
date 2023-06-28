using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseNumber
    {
        public void Checkreverse()
        {
            int num = 0, rev = 0, rem;
            Console.WriteLine("Enter the Number");
            num=Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num%10;
                rev = rev*10 + rem;
                num = num/10;
            }
            Console.WriteLine("AFTER REVERSE NUMBER = " + rev);
        }
    }
}
