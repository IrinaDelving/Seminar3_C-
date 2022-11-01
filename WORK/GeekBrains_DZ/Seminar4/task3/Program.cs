// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int size = 8;
int [] array = new int [8];
Random rnd = new Random();
int count = array.Length;
  
    for (int i=0; i < size; i++)
    {
    array [i] = rnd.Next(9);
    Console.Write(array[i]);
    }
  

   



