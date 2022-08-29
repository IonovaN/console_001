Console.WriteLine("Введите целое число  ");
    int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число  ");
    int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число  ");
    int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > number1)
{
    if (number2 > number3)
    {
        max = number2;
        Console.WriteLine(number2 + " - это максимум ");
    }
    else
    
        max = number3;
        Console.WriteLine(number3 + " - это максимум ");

}
else
{
    if (number3 > number1)
    {
        max = number3;
        Console.WriteLine(number3 + " - это максимум ");
    }
    else
    Console.WriteLine(number1 + " - это максимум ");
}