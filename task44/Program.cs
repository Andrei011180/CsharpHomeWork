/*
Не используя рекурсию , выведите первые N чисел фибоначи . Первые два числа фибоначи 0 и 1 
*/
// void Fibonaci(int num)
// {
//     int[ ] fibonaci = new int[ num + 1 ];
//     if( num == 0 ) System.Console.WriteLine(" 1 ");
//     else
//     {
//         for( int i = 0; i < 2; i++)
//         {
//             fibonaci[ i ] = i;
//             System.Console.Write(fibonaci[i] + " ");
//         }
//         for(int i = 2; i < num; i++)
//         {
//             fibonaci[i] = fibonaci[i-2] + fibonaci[i-1];
//             System.Console.Write(fibonaci[i] + " ");
//         }
//     }
// }
// Fibonaci(5);