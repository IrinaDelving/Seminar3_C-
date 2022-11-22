//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int m = SetNumber("Введите число m: ");
int n = SetNumber("Введите число n: ");
int AkkermanFunction = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {AkkermanFunction} ");

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0) 
    {
        return Akkerman(m - 1, 1);
    }
else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
 Akkerman (m, n);
