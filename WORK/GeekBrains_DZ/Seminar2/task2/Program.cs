// Напишите программу, которая выводит третью цифру заданного числа, или сообщает, что ее нет
Console.WriteLine("Введите число, ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100) 
{
   Console.WriteLine($"Третьей цифры нет");
}
else
{
    while (num > 1000)
    {
       num /= 10;
    } 
    int result = num % 10;
    Console.WriteLine($"Третья цифра в числе {num} -> {result}");
}


    
  

