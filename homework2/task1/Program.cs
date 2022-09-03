Console.Write("Введите трехзначное число ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 100 && num1 > 0)
{
    Console.WriteLine("Число введено неверно");
}
else
{
    Console.WriteLine("Вторая цифра числа " + num1 + " будет " + (num1 / 10 % 10));
};