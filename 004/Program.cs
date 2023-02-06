// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число");
int step=int.Parse(Console.ReadLine());
double q=1;

for (int count=1; count <=step; count++)
{
    q=Math.Pow(count, 3);
    if (q%2==0) Console.WriteLine(q);
    
}