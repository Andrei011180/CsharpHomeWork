/* 
Задайте двумерный массив . Напишите программу , которая поменяет местами 
первую и последнюю строку массива .
*/

// int[,] Get2DArray(int rows, int colms, int min, int max)
// {
//     int[,] array = new int[rows, colms];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colms; j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }
// void Print2DArray(int[,] arrayToPrint)

// {
//     for (int i = 0; i < arrayToPrint.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayToPrint.GetLength(1); j++)
//         {
//             System.Console.Write(arrayToPrint[i, j] + "\t"); ;
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] ResultArray(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int colms = array.GetLength(1);
//     int temp = 0;
//     for (int i = 0; i < colms; i++)
//     {
//         temp = array[0, i];
//         array[0, i] = array[rows - 1, i];
//         array[rows - 1, i] = temp;
//     }
//     return array;
// }

// int[,] arr = Get2DArray(4, 4, 0, 10);
// Print2DArray(arr);
// System.Console.WriteLine();
// int[,] arr2 = ResultArray(arr);
// Print2DArray(arr2);