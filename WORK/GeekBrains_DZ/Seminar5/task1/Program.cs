//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Random myRandom = new Random();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [size];
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = myRandom.Next(100, 1000);
    Console.Write(numbers[i] + " ");
}

for (int i = 0; i < numbers.Length; i ++)
{
   if (numbers[i] % 2 == 0) count++; 
}
Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");




