// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void Get3DMatrix(int x, int y, int z)
{
int[,,] Array3D = new int[x, y, z];
int[] Array = RandomArrayNotRepeat(x*y*z, 10, 99);
int index1 = 0;

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        for (int k = 0; k < z; k++)
        {
            Array3D[i,j,k] = Array[index1];
            index1++;
            Console.Write($"({i}, {j}, {k}) = {Array3D[i,j,k]}  ");
        }
        Console.WriteLine();
    }
}
}


int[] RandomArrayNotRepeat(int size, int begin, int last)
{
    int[] arr = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(begin, last+1);
        for (int j = 0; j < i; j++)
        {
            while(arr[i] == arr [j])
            {
                arr[i] = random.Next(begin, last+1);
                j = 0;
            }
        }
    }
return arr;
}
int x = SetNumber("Введите X: ");
int y = SetNumber("Введите Y: ");
int z = SetNumber("Введите Z: ");
Get3DMatrix( x, y, z);








