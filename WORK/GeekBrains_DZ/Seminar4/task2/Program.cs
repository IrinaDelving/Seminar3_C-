// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число, ");

int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int digit = 0;

while (num > 0)
{
    digit = num % 10;
    sum = sum + digit;
    num = num /10;
}
Console.WriteLine($"Сумма цифр в числе равна {sum}");