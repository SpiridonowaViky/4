Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B = " + step);