void Compare()
{
    int x = new Random().Next(10, 100);
    int x1 = x / 10;
    int x2 = x % 10;
    Console.WriteLine($"Сгенерировано случайное число {x} ");
    if (x1 > x2) Console.WriteLine("Первая цифра больше");
    else if (x2 > x1) Console.WriteLine("Вторая цифра больше");
    else Console.WriteLine("Это паллиндром!");
}

Compare();
Compare();

// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет
// вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
void delSrcondNumber()
{
    int randNum = new Random().Next(100, 1000);
    int randFirst = randNum / 100;
    int randLast = randNum % 10;
    int result = randFirst * 10 + randLast;
    Console.WriteLine($"Сгенерировано случайное число" + randNum);
    Console.WriteLine($"Удалено вторая цифра" + result);
}

delSrcondNumber();
delSrcondNumber();

// 12. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то 
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

void Division(int num1, int num2)
{
    if (num1 % num2 == 0)
        Console.WriteLine($"Число {num1} кратно числу {num2}");
    else
        Console.WriteLine($"Число {num1} не кратно числу {num2}, остаток от деления {num1 % num2}");
}

Division(1, 2);


