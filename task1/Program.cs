Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

int n = num;
int rev = 0;
while (num > 0)
{
    int dig = num % 10;
    rev = rev * 10 + dig;
    num = num / 10;
}
if (n == rev)
Console.WriteLine($"Число {n} является палиндромом");

else
Console.WriteLine($"Число {n} не является палиндромом");

