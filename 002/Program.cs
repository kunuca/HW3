// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");
int n=int.Parse(Console.ReadLine());
int sum=0;
while (n>0)
{
    int k=n%10;
    sum=sum+k;
    n=n/10;
}
Console.WriteLine(sum);