// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число");
int step=int.Parse(Console.ReadLine());
for (int count=1; count <=step; count++)
{
    Console.WriteLine($"Куб числа {count} равен {Math.Pow(count, 3)} ");
}
