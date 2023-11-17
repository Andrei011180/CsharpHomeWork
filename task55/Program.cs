/*
Задайте двумерный массив . Напишите программу , которая заменяет строки на столбцы .
В случае , если это невозможно , программа должна вывести сообщение для пользователя .
*/
// int[,] GetRandom2DArray(int rowNumber, int min, int max)
// {
//     int[,] result = new int[rowNumber, rowNumber];
//     for (int i = 0; i < rowNumber; i++)
//     {
//         for (int j = 0; j < rowNumber; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
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
// int[,] Cange(int[,] matrix)
// {
//     int temp = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }
//     return matrix;
// }

// int [,] userMatrix = GetRandom2DArray(5, 0, 10);
// Print2DArray(userMatrix);
// System.Console.WriteLine();
// Print2DArray(Cange(userMatrix));