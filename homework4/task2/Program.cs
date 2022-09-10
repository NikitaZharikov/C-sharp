Console.WriteLine("Введите число чтобы узнать сумму цифр");
int numb = Convert.ToInt32(Console.ReadLine());
int sumOfNumb = 0;
while (numb != 0)
{
    sumOfNumb += numb % 10;
    numb /= 10;
}
Console.WriteLine("Сумма всех цифр в числе равна " + sumOfNumb);