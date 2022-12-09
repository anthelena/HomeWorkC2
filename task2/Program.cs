// // Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
// // и находит расстояние между ними в 3D пространстве.
double AB = 0;
double [] points = new double [6];
Console.WriteLine("Введите координаты А(x, y, z) и B(x1, y1, z1): ");
for (int i = 0; i < points.Length; i++)
{
    points[i] = Convert.ToDouble(Console.ReadLine());
    AB = Math.Sqrt((points[0] - points[3]) * (points[0] - points[3]) + (points[1] - points[4]) * (points[1] - points[4]) + (points[2] - points[5]) * (points[2] - points[5]));
}
Console.WriteLine($"Длинна отрезка {AB}");
