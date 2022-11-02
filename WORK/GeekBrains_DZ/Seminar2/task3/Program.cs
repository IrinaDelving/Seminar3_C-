// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день 
// выходным. 

Console.WriteLine("Введите число, ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 7 && num >= 1)
{
    if (num > 5)
    {
        Console.WriteLine("Выходной день"); 
    }
    else 
    {
        Console.WriteLine("Будний день"); 
    }
}
else
{
    Console.WriteLine("Неверный день недели");  
}
   

