Console.Clear();
Console.WriteLine("Введите число a: ");
Console.WriteLine("Введите число b: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max = {0}", a);
    Console.WriteLine("min = {0}", b);
}
else 
{
    Console.WriteLine("max = {0}", b);
    Console.WriteLine("min = {0}", a);
}