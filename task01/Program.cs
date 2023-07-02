/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
// Метод, который создает двумерный массив из трех строк и четырех столбцов
double[,] Matrix(int row = 3, int column = 4)
{
    int max = 10;
    int min = -10;
    Random rmd = new Random();
    double[,] matrix = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rmd.NextDouble() * (max - min) + min;
        }

    }
    return matrix;
}
// Метод, который выводит в консоль двумерный массив
void PrintMatrix(double[,] matrica)
{
    for (int i = 0; i < matrica.GetLength(0); i++)
    {
        for (int j = 0; j < matrica.GetLength(1); j++)
        {
            Console.Write($"{matrica[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
double[,] matrisa = Matrix();
PrintMatrix(matrisa);