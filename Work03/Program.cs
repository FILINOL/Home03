Console.Write("Введите число для таблицы квадратов: ");
string text1 = Console.ReadLine();
int a = Convert.ToInt32(text1);

for (int i = 1; i <= a ; i++)
{
    double x = Math.Pow(i, 3);
    Console.WriteLine(x); // Вывод в консоль переменной i

}