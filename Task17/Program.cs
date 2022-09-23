// Задача 17 Напишите программу, которая принимает на вход координаты точки (x и y), причем x не равно 0 и y не равно 0 и выдаёт номер четверти плоскости, в которой находится эта точка. 
Random random = new Random();
int x = random.Next(-10, 11);
int y = random.Next(-10, 11);
Console.WriteLine($"A({x},{y})");
CoordChek(x,y);

void CoordChek(int x, int y)
{
    if (x > 0 && y > 0)
{
    Console.WriteLine("Точка лежит в 1-й четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка лежит в 2-й четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка лежит в 3-й четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка лежит в 4-й четверти");
}
else
{
    Console.WriteLine("Точка лежит на одной оси");
}
}

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N
// {
//     Console.WriteLine("Задача 21");

//     Random random = new Random();

//     int x1 = random.Next(0, 100);
//     int y1 = random.Next(0, 100);
//     int x2 = random.Next(0, 100);
//     int y2 = random.Next(0, 100);

//     Console.WriteLine($"A {x1}, {y1}");
//     Console.WriteLine($"B {x2}, {y2}");
//     Dist(x1, y1, x2, y2);
// }

// void Dist(int x1, int y1, int x2,  int y2)
// {
//  Console.WriteLine($"Расстояние между точками = {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))}");   
// }

// oid Zadacha22()
// {
//     Console.WriteLine("Введите число");
//     int N = Convert.ToInt32(Console.ReadLine());
//     int i = 1;
//     double Sqw;
//     while (i <= N)
//     {
//         Sqw = Math.Pow(i,2);
//         Console.WriteLine($"|{i}|{Sqw}|");
//         i++;
//     }
// }
// // Zadacha22();
// Console.WriteLine("Задача 22");
//     Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     result(num);
// }

// void result(int num)
// {
//     int i = 1;
//     if (num > 1)
//     {
//         while (i <= num)
//            {
//              Console.WriteLine($"Квадрат числа {i} = {Math.Pow((i), 2)}");
//            i++;
//            }
//     }
//     else
//     {
//          while (num <= 1)
//            {
//              Console.WriteLine($"Квадрат числа {num} = {Math.Pow((num), 2)}");
//            num++;
//            }
//     }

// }


