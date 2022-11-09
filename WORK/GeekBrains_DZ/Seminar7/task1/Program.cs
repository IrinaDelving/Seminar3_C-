//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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
double[,] GetRandomMatrix(int rows, int column, int max, int min)
 {
   
    double[,] matrix = new double[rows, column];
    var random = new Random();
     for (int i = 0; i < rows; i++)
    {
         for (int j = 0; j < column; j++)
         {
            matrix[i,j] = Math.Round(random.Next(min*10, max*10) * 0.1, 2);
        }
    }
    return matrix;
 }
double[,] matrix = GetRandomMatrix( rows, column, 10, 0 );
void PrintMatrix(double[,] matrix)
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
PrintMatrix(matrix);

