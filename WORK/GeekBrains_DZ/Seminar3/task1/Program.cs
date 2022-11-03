// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число, ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100000 && num > 9999)
{
    int num5 = num%10;
    int num4 = num/10%10;
    int num3 = num/100%10;
    int num2 = num/1000%10;
    int num1 = num/10000%10;
   
    if (num1 == num5 && num2 == num4)
            
        Console.WriteLine("Число палиндром");
    
        else 
    {
        Console.WriteLine("Число не палиндром"); 
    }
}   
    else
{
    Console.WriteLine("Введите верное число");  
}

