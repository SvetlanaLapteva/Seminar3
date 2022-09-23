// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Random random = new Random();
int x1 = random.Next(-100, 100);
int x2 = random.Next(-100, 100);
int y1 = random.Next(-100, 100);
int y2 = random.Next(-100, 100);
int z1 = random.Next(-100, 100);
int z2 = random.Next(-100, 100);
double dist;
dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
Console.WriteLine(dist);