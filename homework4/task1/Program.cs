Console.WriteLine("Введите число которое хотите возвести в степень ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень в которую хотите возвести ");
double numberToPower = Convert.ToDouble(Console.ReadLine());
double powerOfNumber = Math.Pow(number, numberToPower);
Console.WriteLine("Возведение числа " + number + " в степень " + numberToPower + " будет равна " + powerOfNumber);