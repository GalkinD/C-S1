System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 999)
{
    System.Console.WriteLine(number % 10);
}
else
{
    System.Console.WriteLine("Введите трехзначное число!");
}
