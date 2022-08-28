
Console.Write("Введите k1: ");
double k1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2= Convert.ToInt32(Console.ReadLine());

if (k1==k2 && b1==b2)
{
Console.WriteLine("Прямые совпадают");
}

if (k1==k2 && b1!=b2)
{
Console.WriteLine("Прямые параллельны");
}

if (k1!=k2)
{
    double resX= (b2-b1)/(k1-k2); 
    double resY= k1*resX+b1;
    Console.WriteLine($"Точка пересечения прямых: x={resX}, y={resY}");
}