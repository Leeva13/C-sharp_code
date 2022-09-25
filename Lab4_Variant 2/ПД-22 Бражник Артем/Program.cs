using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Variant_2
{
    class MyClass
    {
        static void Main(string[] args)
        {
            int[] arr = { 15,2,63,3,6,7,-3,-14,64,98 };
            for (int i = 1; i < arr.Length; i+=2)
            {
                Console.Write(arr[i]+ " "); // Виводимо непарні індекси
            }
            Console.WriteLine("\n");
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.Write(arr[i] + " "); // Виводимо парні індекси
            }
            Console.ReadLine();
        }
    }
}
