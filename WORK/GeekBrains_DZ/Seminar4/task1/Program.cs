// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень
Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= numB; i++)
{
    result = result * numA; 
}
Console.Write(result); 
