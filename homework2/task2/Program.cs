Console.Write("Введите трехзначное число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int result = num1 % 100 % 10;
if (num1 < 1)
{
    Console.WriteLine("Введено неверное число");
}
else if (num1 < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine("Третья цифра числа " + num1 + " будет " + result);
};