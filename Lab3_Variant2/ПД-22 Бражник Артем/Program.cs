using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2Variant
{
    class MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input x:");
            string str1 = Console.ReadLine();
            int strX = Int32.Parse(str1);

            Console.WriteLine("Input y:");
            string str2 = Console.ReadLine();
            int strY = Int32.Parse(str2);

            if(strX < 0 && strY > 0) {
                Console.WriteLine("True");
            }else { 
                Console.WriteLine("False"); 
            }
            Console.ReadLine();
        }
    }
}
