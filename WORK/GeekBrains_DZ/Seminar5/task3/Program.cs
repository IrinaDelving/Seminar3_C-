// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int [] myArray = {3, 7, 22, 2, 78, 42,5};
int minValue = myArray[0];
int maxValue = myArray[0];

for (int i = 1; i < myArray.Length; i++)
{
    if (myArray[i] < minValue)
    {
        minValue = myArray[i];
    }
}
Console.WriteLine(minValue);

for (int i = 1; i < myArray.Length; i++)
{
    if (myArray[i] > maxValue)
    {
       maxValue = myArray[i];
    }
}
Console.WriteLine(maxValue);
Console.WriteLine("Разница максимального и минимального: " +(maxValue -  minValue));











