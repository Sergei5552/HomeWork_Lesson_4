Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int sumDigit = 0;

while (userNumber > 0)
{
    int digit = userNumber % 10;
    sumDigit += digit;
    userNumber /= 10;
}

Console.WriteLine(sumDigit);