//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] GetArray (int m, int n, int min, int max)
{
    int[,] resultArray = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = new Random().Next(min, max);
        }
    }
    return resultArray;
}

double[] GetAvarage(int[,] array)
{
    double [] resultArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            resultArray[j] += array[i,j];
        }
        resultArray[j] = Math.Round((resultArray[j] / array.GetLength(0)),2);
    }
    return resultArray;
}

Console.WriteLine ("Введите число строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray (m, n, 0, 10);

Console.WriteLine("Сгенирирован следующий массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

double[] result = GetAvarage(array);

Console.WriteLine("Средние арифметические каждого столбца: ");
for (int i = 0; i < result.Length; i++) Console.Write($"{result[i]}; ");