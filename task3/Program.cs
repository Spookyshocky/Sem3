Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = 1;
while (count<num)
{
 double result = Math.Pow(count,3);
 Console.Write($"{result}, ");
 count++;
}
Console.Write(num*num*num);