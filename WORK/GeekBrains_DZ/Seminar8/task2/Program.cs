// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int rows = SetNumber("Введите количество строк");
int column = SetNumber("Введите количество столбцов");

int[,] matrix = GetRandomMatrix( rows, column, 10, 5 );
PrintMatrix(matrix);
int SumLineElements(int[,] matrix, int i);


int minSumLine = 0;
int sumLine = SumLineElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

int SumLineElements(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}

int[,] GetRandomMatrix(int rows, int column, int max , int min )
 {
    int[,] matrix = new int[rows, column];
    var random = new Random();
     for (int i = 0; i < rows; i++)
    {
         for (int j = 0; j < column; j++)
         {
            matrix[i,j] = random.Next(min, max);
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
