/*
Напишите программу для работы с массивом ещественных чисел ,
найдите разницу между максимальным и минимальным элеметами 
*/

// Console.Clear();

// double [ ] GetDoubleRnd(int size)
// {
//     double [ ] array = new double [ size ];
//     for(int i = 0; i< size; i++)
//     {
//         array[i] = new Random().Next(-9 , 9) + new Random().NextDouble();
//        // array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintDoubleRnd(double [ ] arr)
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

// void MinMax( double [ ] arr)
// {
//     double min = 0;
//     double max = 0;
//     for(int i = 0; i< arr.Length; i++)
//     {
//         if(arr[i] >max) max = arr[i];
//         if(arr[i] <min) min = arr[i];
//     }
//     System.Console.WriteLine($" Разница между {Math.Round( max, 2) } и {Math.Round( min, 2) } равняется {Math.Round( max - min, 2) }");
// }
// double[ ] arrayDouble = GetDoubleRnd(5);
// PrintDoubleRnd(arrayDouble);
// MinMax(arrayDouble);
