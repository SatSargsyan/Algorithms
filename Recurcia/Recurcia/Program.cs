using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurcia
{
    class Program
    {
        static void BackWord(string s)
        {
            if (s.Length >= 1)
            {
                string s1 = s.Substring(0, s.Length-1);
                Console.Write(s[s.Length-1]);
                BackWord(s1);

            }
        }
        // 2-rd depqum popokhutyuny chi tpvi
        static void BackWord1(string s)
        {
            if (s.Length >= 1)
            {
                string s1 = s.Substring(0, s.Length - 1);
                BackWord1(s1);

                Console.Write(s[s.Length - 1]);
                
            }
        }
        static void Main(string[] args)
        {
            string s = "barev";
            BackWord(s);
           
            Console.WriteLine();

            BackWord1(s);
            Console.ReadKey();
        }
    }
}
