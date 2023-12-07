using System;

class Program
{
    static void Main(string[] args)
    {
        // Создание и заполнение двумерного массива
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int rows = array.GetLength(0); // количество строк
        int cols = array.GetLength(1); // количество столбцов

        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Меняем местами первую и последнюю строку
        for (int i = 0; i < cols; i++)
        {
            int temp = array[0, i];
            array[0, i] = array[rows - 1, i];
            array[rows - 1, i] = temp;
        }

        // Вывод измененного массива
        Console.WriteLine("Измененный массив:");
        PrintArray(array);
    }

    // Метод для вывода массива
    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
