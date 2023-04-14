Console.WriteLine("Напишите пяти значное число, проверим его на палиндромность: ");
string str = Console.ReadLine();
int a = str[0];
int b = str[1];
int c = str[3];
int d = str[4];

if (a == d && b == c)
{
    Console.WriteLine($"Это значение {str} является палиндромным ");
}
else
{
    Console.WriteLine($"Это значение {str} не является палиндромным ");
}

