Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 0; i < numberB; i++)
{
    result *= numberA;
}
Console.WriteLine(result);