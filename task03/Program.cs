/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// Метод, который создает произвольный двумерный массив из целых чисел
int[,] Matrix()
{
    int row = new Random().Next(2, 7);
    int column = new Random().Next(2, 7);
    int[,] matrix = new int[row, column];
    Random rmd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rmd.Next(0, 10);
        }
    }
    return matrix;
}
// Метод, который выводит в консоль двумерный массив
void PrintMatrix(int[,] matrica)
{
    for (int i = 0; i < matrica.GetLength(0); i++)
    {
        for (int j = 0; j < matrica.GetLength(1); j++)
        {
            Console.Write($"{matrica[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Метод, который считает и выводит в консоль среднее арифметическое элементов в каждом столбце
void SredSum(int[,] matriza)
{

    double[] array = new double[matriza.GetLength(1)]; // массив для среднего арифметического столбцов
    double num2 = matriza.GetLength(0); // Количество элементов в столбце

    for (int i = 0; i < matriza.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matriza.GetLength(0); j++)
        {
            sum += matriza[j, i];
        }

        array[i] = sum / num2;

    }
    foreach (double item in array)
    {
        Console.Write($"{item:f1} ");
    }
}

Console.Clear();
int[,] matrisa = Matrix();
PrintMatrix(matrisa);
SredSum(matrisa);