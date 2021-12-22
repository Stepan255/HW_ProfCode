// TODO Задать положительное вещественное число m. Cоставить целое число n из цифр
// десятков и сотых m
// единиц и сотых m
// сотен и десятых m
Console.Clear();

Console.Write("Введите вещественное m = "); 
string stringNamber = Console.ReadLine();
double namberA = double.Parse(stringNamber);

Console.WriteLine($"число {namberA} из десятков и сотых m: {Math.Abs((namberA / 10 - namberA / 10 % 1) % 10 * 10) + Math.Abs((namberA * 100 - namberA * 100 % 1) % 10)}");
Console.WriteLine($"число {namberA} единиц и сотых m: {Math.Abs((namberA - namberA % 1) % 10 * 10) + Math.Abs((namberA * 100 - namberA * 100 % 1) % 10)}");
Console.WriteLine($"число {namberA} сотен и десятых m: {Math.Abs((namberA / 100 - namberA / 100 % 1) % 10 * 10) + Math.Abs((namberA * 10 - namberA * 10 % 1) % 10)}");
