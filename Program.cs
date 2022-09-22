// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance(int x1, int y1, int x2, int y2)
{
    double res = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
    return res;
}
try
{
    Console.Write("Введите координату x1 первой точки ");
    int x1 = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Введите координату y1 первой точки ");
    int y1 = Convert.ToInt32 (Console.ReadLine());
    
    Console.Write("Введите координату x2 первой точки ");
    int x2 = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Введите координату y2 первой точки ");
    int y2 = Convert.ToInt32 (Console.ReadLine());

    Console.Write($"Расстояние между точками будет {Distance(x1, y1, x2, y2)}");
}
catch
{
    Console.WriteLine("Надо было вводить именно целые числа");
}