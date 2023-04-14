Console.WriteLine("Вводим координаты А(xА, yА, zA)");
Console.Write("xA ");
int xA = int.Parse(Console.ReadLine());

Console.Write("yA ");
int yA = int.Parse(Console.ReadLine());

Console.Write("zA ");
int zA = int.Parse(Console.ReadLine());

Console.WriteLine("Вводим координаты B(xB, yB, zB)");

Console.Write("xB ");
int xB = int.Parse(Console.ReadLine());

Console.Write("yB ");
int yB = int.Parse(Console.ReadLine());

Console.Write("zB ");
int zB = int.Parse(Console.ReadLine());



double result = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA)* (zB - zA));
Console.WriteLine(result);