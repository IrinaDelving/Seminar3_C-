//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int m = SetNumber("Введите число строк 1-й матрицы: ");
int n = SetNumber("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int c = SetNumber("Введите число столбцов 2-й матрицы: ");

int[,] firstMartrix = new int[n, m];
firstMartrix = GetRandomMatrix(n,m, 10, 1);
Console.WriteLine($"\nПервая матрица:");
PrintMatrix(firstMartrix);

int[,] secomdMartrix = new int[m, c];
secomdMartrix = GetRandomMatrix(m,c,10, 1);
Console.WriteLine($"\nВторая матрица:");
PrintMatrix(secomdMartrix);

int[,] resultMatrix = new int[m,c];

void MultiMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int[,] GetRandomMatrix(int m, int n, int max , int min )
 {
    int[,] matrix = new int[m, n];
    var random = new Random();
     for (int i = 0; i < m; i++)
    {
         for (int j = 0; j < n; j++)
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
