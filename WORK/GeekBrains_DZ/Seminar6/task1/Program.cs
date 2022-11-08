// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
Console.Write("Введите элементы(через пробел): ");
string elements = Console.ReadLine();

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}
int[] arr = GetArrayFromString(elements);
PrintArray(arr);
void PrintArray(int[] arr)
{ 
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
        System.Console.WriteLine();
}
int CountNumbers(int[] arr)
{
    int count = 0;
 
  for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}  
    return count;
}
int count = arr.Count(i => i > 0);
 Console.WriteLine($"Кол-во элементов > 0: {count}");

