Console.Clear();
Console.WriteLine("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());
int num = n % 2;

if (num == 0)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}