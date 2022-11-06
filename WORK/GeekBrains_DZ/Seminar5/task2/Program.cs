// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
Random myRandom = new Random();
int [] arr = new int [10];
int sum = 0;

 for (int i = 0; i < arr.Length; i++)
{
        arr[i] = myRandom.Next(1, 10);
        Console.Write(arr[i] + " ");
}

for (int i = 1; i < arr.Length; i = i+2)
{
    sum = sum + arr[i];   
}  

Console.WriteLine();                          
Console.WriteLine($"Всего {arr.Length} чисел, сумма элементов на нечетных позициях = {sum}");



//if (arr[i] % 2 != 0) sum = sum + arr[i];
