﻿Console.WriteLine("Введите число:");
int i = int.Parse(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("Сумма цифр в числе = " + sum);
