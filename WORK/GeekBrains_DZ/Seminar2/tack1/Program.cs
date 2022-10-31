Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int division10 = 0;
int result = 0;

if (num > 99 && num < 1000)
    {
        division10 = num / 10;
        result = division10 % 10;
     Console.WriteLine($"{num} вторая цифра {result}");
    }

else {
     Console.WriteLine("Число не трехзначное");

}

