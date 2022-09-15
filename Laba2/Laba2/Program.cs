using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            int nk, nn;

            Console.Write("Введіть початковий елемент рядку: nn = ");
            string strnn = Console.ReadLine();
            nn = Int32.Parse(strnn);

            Console.Write("Введіть межу ряду: nk = ");
            string strnk = Console.ReadLine();
            nk = Int32.Parse(strnk);

            if (nn > nk || nn < 0){
                Console.WriteLine("Введено некоректні значення!");
                Console.Write("Введіть початок ряду = ");
                strnn = Console.ReadLine();
                nn = Int32.Parse(strnn);
            }
            double Sum = 0;

            for (double i = nn; i < nk; i++)
            {
                Sum += ((i * i) + Math.Pow(-1, i) * i - 1) / (i * i + 1);
            }

            Console.WriteLine("Сума числового ряду = " + Sum);
            Console.Read();
        }
    }
}