﻿Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2 && num1 >= num3)
{
    Console.Write("Максимальное чило " + num1);
}
else if (num2 >= num1 && num2 >= num3)
{
    Console.Write("Максимальное чило " + num2);
}
else if (num3 >= num1 && num3 >= num2)
{
    Console.Write("Максимальное чило " + num3);
};