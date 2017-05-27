using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursia
{
    class Program
    {
        static int DigitCount(int n)
        {
            if(n<9)
            {
                return 1;

            }
            else 
            {
                return 1 + DigitCount(n / 10);

            }

        
        } 
        static void Main(string[] args)
        {
            int n=300;
            Console.WriteLine(DigitCount(n));

            
            Console.ReadKey();

        }
    }
}

