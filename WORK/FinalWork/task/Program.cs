// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 

string[] array = new string[5] {"23", "11", "hello", "Wednesday", "lol"};
string[] newArray = new string[array.Length];

void ComparisonArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }

}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ComparisonArray(array, newArray);
PrintArray(newArray);
