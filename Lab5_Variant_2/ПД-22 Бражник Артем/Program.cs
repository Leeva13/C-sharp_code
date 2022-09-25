using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Lab_5
//  Variant 2
int[,] arr = { { 4, 7, 2, -1 }, 
             { 9, 5, 11, -2 },
             { 12, 6, 4, 0 }, 
             { 5, 9, 0, 2 }, 
             { 8, 7, 34, 7 } 
       }; //    array 4 * 4    \\
int heigth = arr.GetLength(0);
int width = arr.GetLength(1);

    int sumPairRows = 0; 
    int sumNoPairRows = 0;

    int sumPairCol = 0;            
    int sumNoPairCol = 0;

for (int i = 0; i < heigth; i += 2) {
        for (int j = 0; j < width; j++) {
        sumPairRows += arr[i, j];
        }
    }
for (int i = 1; i < heigth; i+=2) {
    for (int j = 0; j < width; j++) {
        sumNoPairRows += arr[i, j];
    }
}
for (int i = 0; i < heigth; i++) {
    for (int j = 0; j < width; j+=2) {
        sumPairCol += arr[i, j];
    }
}
for (int i = 0; i < heigth; i++) {
    for (int j = 1; j < width; j += 2) {
        sumNoPairCol += arr[i, j];
    }
}
Console.WriteLine(" Сума елементів всіх парних строк:" + sumPairRows);
Console.WriteLine(" Сума елементів всіх непарних строк:" + sumNoPairRows);
Console.WriteLine(" Сума елементів всіх парних стовпчиків:" + sumPairCol);
Console.WriteLine(" Сума елементів всіх непарних стовпчиків:" + sumNoPairCol);
