﻿string numCubes(int num)
{
    int i = 2;
    string cubes = "1";
    while (i <= num)
    {
        cubes = cubes + "," + Convert.ToString(i * i * i);
        i++;
    }
    return cubes;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numCubes(num));