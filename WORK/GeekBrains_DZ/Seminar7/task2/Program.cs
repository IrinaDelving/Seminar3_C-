//Задача 50. Напишите программу, которая на вход принимает число в двумерном массиве, и возвращает координаты этого элемента или же указание, 
//что такого элемента нет.

int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int rows = SetNumber("Введите количество строк");
int column = SetNumber("Введите количество столбцов");
int num = SetNumber("Введите число");

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
int[,] matrix = GetRandomMatrix( rows, column, 10, 0 );


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
PrintMatrix(matrix);

void FindNumberInMatrix(int[,] matrix, int num)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == num) 
                {
                Console.WriteLine($"Координаты числа {num} - ({i}, {j})");
                break;  
                }
                
                else
                {
                    Console.WriteLine($"такого элемента нет");;
                }
            } 
    }
}
           
FindNumberInMatrix(matrix, num);


