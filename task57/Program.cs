/*
Составить частотный словарь элементов двумерного массива .
Частотный словарь содержит информацию о том , сколько раз встречается элемент входящий в массив
*/

int[,] GetRandom2DArray(int rowNumber, int min, int max)
{
    int[,] result = new int[rowNumber, rowNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < rowNumber; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)


{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i, j] + "\t"); ;
        }
        System.Console.WriteLine();
    }
}

int[] BackMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0) * matrix.GetLength(1);
    int[] array = new int[n];
    n=0;
    for( int i=0; i< matrix.GetLength(0); i++)
    {
        for( int j = 0; j < matrix.GetLength(1); j++)
        {
            array[n]= matrix[i, j];
            n++;
        }
    }
}
void Sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array.[minPosition]) minPosition = j;
        }
        if (i != minPosition)
        {
            int temp = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temp;
        }
    }
}
void Chastota(int[] array)
{
    int temp = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == temp)
            count++;
        else
        {
            System.Console.WriteLine($"{temp} - {count} раз ");
            temp = array[i];
            count = 1;
        }
        if (i == array.Length - 1)
            System.Console.WriteLine($"{temp} - {count} раз ");
    }
}

int [,] userArrayvb=GetRandom2DArray(4, 4, 10);
Print2DArray( userArrayvb);
System.Console.WriteLine();
BackMatrix(Sort(Chastota));