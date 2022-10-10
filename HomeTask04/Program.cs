Console.Clear();
Console.WriteLine("Введите число a: ");
Console.WriteLine("Введите число b: ");
Console.WriteLine("Введите число c: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (a > b)
{
    max = a;
}
else 
{
    max = b;
}
if (max > c)
{
    max = max;
}
else 
{
    max = c;
}
Console.WriteLine(max);