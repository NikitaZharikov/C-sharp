Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 2;
if (result == 0)
{
    Console.Write("Число " + num + " четное");
}
else
{
    Console.Write("Число " + num + " нечетное");
};
