// Составить частотный словарь элементов двумерного массива. Частотный словарь 
// содержит информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9

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

int[] FrequensyArray(int[,] array)
{
    int[] FreqArray =new int[10];
    foreach (var item in array)
    {
        FreqArray [item]++; 
    }
    return FreqArray;
}

void PrintFreqArray(int[]frequanceDictionary)
{
    for (int i = 0; i < frequanceDictionary.Length; i++)
    {
        System.Console.WriteLine($"{i} встречается {frequanceDictionary[i]}  раз");
    }
}

int[,]matrix = GenerateArray(4,4);
PrintArray(matrix);
PrintFreqArray(FrequensyArray (matrix));