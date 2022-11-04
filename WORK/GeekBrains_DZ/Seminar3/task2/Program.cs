// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1 = Coor("x", "A");
int y1 = Coor("y", "A");
int z1 = Coor("z", "A");
int x2 = Coor("x", "B");
int y2 = Coor("y", "B");
int z2 = Coor("z", "B");

int Coor(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
double Decision(double x1, double x2,  double y1, double y2, double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) +  Math.Pow((z2-z1), 2));
}
double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
