// Найдите положительный корень уравнения с точностью d
// x = Sin(x)
// ex = x + 1
// -x = -Cos(x)

double x1Find(double[] count)
{
	while (true)
	{
		count[0] += 1;
		double x = new Random().NextDouble();
		if (x > 0 && x == Math.Sin(x)) return x;
	}
}

double x2Find(double[] count)
{
	while (true)
	{
		count[1] += 1;
		double x = new Random().NextDouble();
		if (x > 0 && x + 1 == Math.Exp(x)) return x;
	}
}

double x3Find(double[] count)
{
	while (true)
	{
		count[2] += 1;
		double x = new Random().NextDouble();
		if (x > 0 && Math.Round(- x, 7) == Math.Round(-Math.Cos(x), 7)) return x;
	}
}

int d = 5;
double[] count = new double[3];

Console.Clear();
DateTime saveTime = DateTime.Now;
Console.WriteLine($"x1 = {Math.Round(x1Find(count), d)}");
Console.WriteLine($"Для поиска x1 прошло: {DateTime.Now - saveTime}, count = {count[0]}");

saveTime = DateTime.Now;
Console.WriteLine($"x1 = {Math.Round(x2Find(count), d)}");
Console.WriteLine($"Для поиска x2 прошло: {DateTime.Now - saveTime}, count = {count[1]}");

saveTime = DateTime.Now;
Console.WriteLine($"x1 = {Math.Round(x3Find(count), d)}");
Console.WriteLine($"Для поиска x3 прошло: {DateTime.Now - saveTime}, count = {count[2]}");
Console.ReadLine();