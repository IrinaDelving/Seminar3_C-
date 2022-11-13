// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int SetNumber(string str)
{
System.Console.WriteLine(str);
int num = int.Parse(Console.ReadLine());
return num;
}
int rows = SetNumber("Введите количество строк");
int column = SetNumber("Введите количество столбцов");

int[,] matrix = GetRandomMatrix(rows, column, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
BubbleSort(matrix);


void BubbleSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        Console.Write(matrix[i, j] + " "); 
        }
    Console.WriteLine();
    }  
}
  
    int[,] GetRandomMatrix(int rows, int column, int minValue, int maxValue)
    {
        int[,] matrix = new int[rows, column];
        var random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matrix[i, j] = random.Next(minValue, maxValue);
            }
        }
        return matrix;
    }

    void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write(matrix[i, j] + " ");
            }
            System.Console.WriteLine();
        }
    }
    