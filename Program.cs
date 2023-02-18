// Задача 21 Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53


Point first_point;
Point second_point;

Console.WriteLine($"Введите координату х first_point: ");
double.TryParse(Console.ReadLine(), out first_point.x);

Console.WriteLine($"Введите координату y first_point: ");
double.TryParse(Console.ReadLine(), out first_point.y);

Console.WriteLine($"Введите координату z first_point: ");
double.TryParse(Console.ReadLine(), out first_point.z);


Console.WriteLine($"Введите координату х second_point: ");
double.TryParse(Console.ReadLine(), out second_point.x);

Console.WriteLine($"Введите координату y second_point: ");
double.TryParse(Console.ReadLine(), out second_point.y);

Console.WriteLine($"Введите координату z second_point: ");
double.TryParse(Console.ReadLine(), out second_point.z);


double result = Math.Sqrt(Math.Pow(second_point.x - first_point.x, 2) +
    Math.Pow(second_point.y - first_point.y, 2) + Math.Pow(second_point.z - first_point.z, 2));

Console.WriteLine($"first_point({first_point.x}; {first_point.y}; {first_point.z}) -> {result}");

struct Point
{
    public double x;
    public double y;
    public double z;
}




