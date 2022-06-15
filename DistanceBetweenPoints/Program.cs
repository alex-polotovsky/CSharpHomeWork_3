/* Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */


Console.Write("Точка А, координата x: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Точка А, координата y: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Точка А, координата z: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Точка B, координата x: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Точка B, координата y: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Точка B, координата z: ");
int z2 = int.Parse(Console.ReadLine());

int x = x1 - x2;
int y = y1 - y2;
int z = z1 - z2;

double D = Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)), 3);
Console.WriteLine("Distance AB: " + D);
