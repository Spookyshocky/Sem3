Console.Clear();

Console.WriteLine("Введите Х1" );
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1" );
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z1" );
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Х2" );
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2" );
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z2" );
int z2 = int.Parse(Console.ReadLine());

double len = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));

len = Math.Round(len,2);

Console.WriteLine(len);