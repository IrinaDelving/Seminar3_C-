// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int rows = SetNumber("Введите количество строк");
int column = SetNumber("Введите количество столбцов");
Console.Write(rows);
Console.Write(column);

int[,] matrix = GetRandomMatrix( rows, column, 10, 5 );
PrintMatrix(matrix);
double[] averageColums = GetResultMatrix(matrix);

double[] GetResultMatrix(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double average = 0; 
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average += matrix[j, i];
        }
       result[i] = Math.Round(average / matrix.GetLength(0), 2);
       Console.WriteLine($"Среднее арифметическое{result[i]}");
        }
        return result;
}
int[,] GetRandomMatrix(int rows, int column, int maxVal = 10, int minVal = 5)
    {
        int[,] matrix = new int[rows, column];
            var random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matrix[i,j] = random.Next(minVal, maxVal+1);
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
            System.Console.Write(matrix[i,j] + " ");
        }
    System.Console.WriteLine();
    }
}