// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int m = SetNumber("Введите число m: ");
int n = SetNumber("Введите  число n: ");
int temp = m;
Console.Write($"{m}, {n} ->");

void PrintSumNumbers(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m )
    {
      Console.Write($" {sum} ");
      return;  
    }
    PrintSumNumbers(m, n - 1, sum);
}

    if (m > n)
    {
        m = n;
        n = temp;
    }
PrintSumNumbers(m, n, temp = 0);  










