// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int n = SetNumber("Введите число");

static String recursion(int n) 
{
if (n==1)
{
  return "1";  
}    
return recursion(n - 1) + " " + n;
}
{
    Console.WriteLine((recursion(n))); 
}
    
recursion(n);






