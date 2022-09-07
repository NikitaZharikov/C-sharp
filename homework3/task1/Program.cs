Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int oldValue = number;
int newValue = 0;
int dig = 0;

while (number > 0)
{
    dig = number % 10;
    newValue = newValue * 10 + dig;
    number = number / 10;
}

if (newValue == oldValue)
    Console.WriteLine("Число является палиндромом");

else
    Console.WriteLine("Число не является палиндромом");