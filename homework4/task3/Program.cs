Console.Write("Введите размер массива ");
int arrayCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayCount];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент №" + (i + 1) + " ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Вывод массива:");

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] + " ");
}