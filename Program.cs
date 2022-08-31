Console.WriteLine("Введите целое число  ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int a = 0;
while (a < (userNumber-1))
{
    a += 2;
    Console.WriteLine(a +", " );
}
