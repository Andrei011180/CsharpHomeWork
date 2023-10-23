/*
Задайте массив из 12 элементов , заполненый случайными числами из промежутка 
[ -9, 9 ] .  Найдите сумму отрицательных и положительных элементов массива . 
*/

// Console.Clear( );

// int[ ] GetRnd( int size )
// {
//     int[ ] array = new int[ size ];
//     for( int i = 0; i < size; i++)
//     {
//         array[ i ] = new Random().Next(-9, 10);
//     }
//     return array;
// }

// void PrintArray(int[ ] arr1)
// {
//     for (int i= 0; i < arr1.Lenghs; i++)
//     {
//         System.Console.WriteLine(arr1[i]+ " ");
//     }
// }

// void SumArray(int[ ] arr)
// {
//     int summPos = 0;
//     int summNeg = 0;
//     for (int i = 0; i < arr.Lenghs; i++)
//     {
//         if(arr[i] >0) summPos = summPos + arr[i];
//         else summNeg =summNeg + arr[i];
//     }
//     System.Console.WriteLine(" Сумма положительных чисел в массиве равна : " + summPos );
//     System.Console.Write(" Сумма отрицательных чисел в массиве равна : " + summNeg );
// }

// int [ ] userArray = GetRnd(12);
// PrintArray(userArray);
// System.Console.WriteLine();
// SumArray(userArray);