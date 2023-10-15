Console.Write("Введите два числа: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int square = Convert.ToInt32(Console.ReadLine());

if (square % numbers == 0){
    System.Console.WriteLine("Первое число является квадратом второго");
}
else {
    System.Console.WriteLine("Первое число не является квадратом второго");
}