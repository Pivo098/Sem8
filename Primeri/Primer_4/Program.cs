// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и 
// столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col]; // Создаем 2-мерный массив
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}
(int, int )FindMinIndex (int[,] array)
{   
    int minI =  0;
    int minJ = 0;

   for (int i = 0; i < array.GetLength(0) ; i++)
   {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[minI, minJ] > array[i, j])
            {
                minI = i;
                minJ = j;
            }
        }
   }
   return (minI, minJ);
}

int[,] DeliteMinElement(int[,] array, int minI, int minJ)
{
    int [,] result = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == minI || j == minJ) continue; // continue - продолжить цикл, пропускается итерация цикла for
            int indexI = i;
            int indexJ = j;
            if (i < minI) indexI--;
            if (j < minI) indexJ--;
            result[indexI,indexJ] = array[i,j];
        }
    }
    return result;
}

int [,] matrix = GenerateArray(4,4);
PrintArray(matrix);
(int minI, int minJ) = FindMinIndex(matrix);
PrintArray(DeliteMinElement(matrix, minI, minJ));

// // Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// // на пересечении которых расположен наименьший элемент массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Наименьший элемент - 1, на выходе получим 
// // следующий массив:
// // 9 4 2
// // 4 2 4
// // 2 6 7

// int[,] GenerateArray(int row, int col)
// {
//     int[,] array = new int[row, col]; // Создаем 2-мерный массив
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(-9, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         System.Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]}\t");
//         }
//     }
//     System.Console.WriteLine();
// }

// (int, int) FindeMinIndexMatrix(int[,] array)
// {
//     int mini = 0;
//     int minj = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[mini, minj] > array[i, j])
//             { mini = i; minj = j; }
//         }
//     }
//     return (mini, minj);
// }

// int[,] DeliteMInElement(int[,]array, int mini, int minj)
// {
//     int[,]result=new int[array.GetLength(0)-1, array.GetLength(1)-1];
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i==mini||j==minj)continue;
//         int k= i;
//         int l = j; 
//         if (i>mini) k--; 
//         if (j>minj) l--;
//         result [k,l]=array[i,j];
//     } 
//    }
//    return result;
// }

// int[,]matrix=GenerateArray(4,4);
// PrintArray(matrix);
// (int mini, int minj)=FindeMinIndexMatrix(matrix);
// PrintArray(DeliteMInElement(matrix, mini, minj));