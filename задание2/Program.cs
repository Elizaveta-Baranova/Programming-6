// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int b1 = ReadInt("Введите начало точки b: ");
int b2 = ReadInt("Введите окончание точки b: ");
int k1 = ReadInt("Введите начало точки k: ");
int k2 = ReadInt("Введите окончание точки k: ");
if (b1==b2 & k1==k2) 
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1==k2) 
{
    Console.WriteLine("Прямые параллельны друг другу");
}

double x = (k1 - k2);
x = (b2-b1)/ x;
double y = k1 * x + b1;

Console.Write($"Точка пересечения двух прямых: {x}; {y}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}