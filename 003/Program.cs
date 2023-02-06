// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число");
int k=int.Parse(Console.ReadLine());
int sum=1;
for (int i=1; i<=k; i++) sum=sum*i;
Console.WriteLine($"Произведение чисел от 1 до {k} равно {sum}");