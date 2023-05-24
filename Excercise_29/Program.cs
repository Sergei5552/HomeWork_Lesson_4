int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    int number = 0;
    Console.Write("Введите число: " );
    number = Convert.ToInt32(Console.ReadLine());
    array[i] = number;
}

Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}