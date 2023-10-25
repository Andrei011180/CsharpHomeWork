/* 
Напишите программу , которая находит сумму элементов с нечеными индексами
в однмерном массиве целых чисел и выводит результат на экран
*/
// Console.Clear();

// int [ ] GetRnd(int size)
// {
//     int [ ] array = new int [ size ];
//     for(int i = 0; i< size; i++)
//     {
//         array[i] = new Random().Next(0 , 10);
//        // array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int [ ] arr)
// {
//     Console.Write(" [ ");
//     for(int i = 0; i< arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//         if( i < arr.Length - 1)
//        {
//         Console.Write(", ");
//        }
//     }
//     Console.WriteLine(" ] ");
// }    

// void SumInd(int[ ] arr)
// {
//     int summ = 0;
//     for(int i = 1; i < arr.Length; i+=2)
//     {
//         summ = arr[i] + summ;
//     }
//     System.Console.WriteLine(summ);
// }

// int [ ] array = GetRnd(10);
// PrintArray(array);
// System.Console.WriteLine();
// SumInd(array);