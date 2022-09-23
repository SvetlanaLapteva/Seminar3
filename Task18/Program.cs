// Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти.
Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
Check(num);

void Check(int num)
{
if(num == 1)
{
    Console.WriteLine($"в 1-й четверти x в диапазоне (0, +∞), y в диапазоне (0, +∞)");
}
else if(num == 2)
{
    Console.WriteLine($"во 2-й четверти x в диапазоне (0, -∞), y в диапазоне (0, +∞)");
}
else if(num == 3)
{
    Console.WriteLine($"в 3-й четверти x в диапазоне (0, -∞), y в диапазоне (0, -∞)");
}
else if(num == 4)
{
    Console.WriteLine($"в 4-й четверти x в диапазоне (0, +∞), y в диапазоне (0, -∞)");
}
else 
{
    Console.WriteLine("Неверный ввод");
}
}
