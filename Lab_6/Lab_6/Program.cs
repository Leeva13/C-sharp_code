using System;
using System.Globalization;

namespace Lab_6
{
    class Global{
        public static void Main() 
        {

            void reverseArray(int[] array)
            {
                for (int i = array.Length; i >= 0; i--)
                {
                    Console.Write(array[i] + " ");
                }
            }

            void reverseString(string[] str)
            {
                for (int i = str.Length; i >= 0; --i)
                {
                    Console.Write(str[i]);
                }
            }
            void Foo(double num)
            {
                double newNum = Math.Truncate(num / 10d);
                if (newNum > 0)
                {
                    Foo(Convert.ToInt32(newNum));
                }
                Console.WriteLine(Convert.ToInt32((num / 10d - Math.Truncate(num / 10d)) * 10));
            }
            void magicCharForString(string[] str, char magicSymbol)
            {
                for (int i = str.Length; i >= 0; i++)
                {
                    Console.Write(str[i]);
                }
                Console.Write(" " + magicSymbol);    
            }
          
            // 1 Zavdannya
            /* 
                       int[] array = new int[5];
                       Console.WriteLine("Введіть числа через Enter (5 значень)");
                       for (int i = 0; i < 5; i++) 
                       {
                           array[i] = int.Parse(Console.ReadLine());
                       }
                       Console.WriteLine("Обернений масив: ");
                       reverseArray(array);

           */

            //  2 Zavdannya

            /*            
                        Console.WriteLine("Введіть розмір рядка: ");
                        string[] str;
                        int sizeStr = int.Parse(Console.ReadLine());
                        str = new string[sizeStr];
                        Console.WriteLine("Введіть рядок: ");
                        for (int i = 0; i < str.Length; i++)
                        {
                            str[i] = Console.ReadLine();
                        }
                        reverseString(str);
            */


            // 3 Zavdannya
            /*
                        double someDouble = double.Parse(Console.ReadLine());

                        Foo(someDouble);
              */

            // 4 Zavdannya
            /*
                        Console.WriteLine("Введіть розмір рядка:");
                        int testSizeStr = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть магічне число (1 символ):");
                        char magicChar = char.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть рядок (по букві через Enter), і після магічного символу я поверну рядок у зворотньому порядку ;)");
                        string[] testStr;
                        testStr = new string[testSizeStr];
                        for (int i = 0; i < testStr.Length; i++)
                        {
                            testStr[i] = Console.ReadLine();
                        }
                        magicCharForString(testStr,magicChar);
            */



        }
    }
}






