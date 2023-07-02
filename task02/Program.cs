/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

// Метод, который создает произвольный двумерный массив
int[,] Matrix()
{

    int row = new Random().Next(3, 6); // Случайное количество строк от [3;5]
    int column = new Random().Next(3, 6); // Случайное количество столбцов от [3;5]
    Random rmd = new Random();
    int[,] matrix = new int[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rmd.Next(1, 10);
        }
    }
    return matrix;
}

// Метод, который принимает от пользователя строку и столбец
// при наличии такого символа выводит элемент двумерного массива, а при отсутствии выводит сообщение
void Message(int[,] matrica)
{

    Console.Write("Введите позицию элемента в строке: ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("Введите позицию элемента в столбце: ");
    int column = int.Parse(Console.ReadLine());
    if ((matrica.GetLength(0) > row && row > 0) && (matrica.GetLength(1) > column && column > 0))
    {
        Console.Write($"Под номером элемента в строке {row} и элемента в столбце {column}");
        Console.Write($" находится элемент со значением {matrica[row, column]}");
        Console.WriteLine();
    }
    else Console.WriteLine($"К сожалению элемента со значениями строки {row} и столбца {column} - нет");
}

// Метод, который выводит в консоль двумерный массив
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }

}

Console.Clear();
int[,] matrisa = Matrix();
Message(matrisa);
PrintMatrix(matrisa);