// Среди четырёхзначных полных квадратов найти
// 1. последний, у которого совпадают крайние цифры
// 2. первый, у которого совпадают две любых цифры
// 3. второй, у которого какая то крайняя цифра равна 5

using System.Collections.Generic;

Console.Clear();

List<string> namberListFullSquare = new List<string>();
for (int i = 1000; i < 10000; i++)
{
	if (Math.Sqrt(i) % 1 == 0) namberListFullSquare.Add(i.ToString());
}

string resalt1 = namberListFullSquare.FindLast(
	delegate(string namber)
	{
		return namber[0] == namber[3];
	}
);

string resalt2 = namberListFullSquare.Find(
	delegate(string namber)
	{
		return namber[0] == namber[1] || namber[0] == namber[2] || namber[0] == namber[3] ||
				namber[1] == namber[2] || namber[1] == namber[3] || namber[2] == namber[3];
	}
);

List<string> resalt3 = namberListFullSquare.FindAll(
	delegate(string namber)
	{
		return namber[0] == '5' || namber[3] == '5';
	}
);

Console.WriteLine("Четырёхзначные полные квадраты которые удовлетворяют условиям:");
Console.WriteLine($"Последний, у которого совпадают крайние цифры: {resalt1}");
Console.WriteLine($"Первый, у которого совпадают две любых цифры: {resalt2}");
Console.WriteLine($"Второй, у которого какая то крайняя цифра равна 5: {resalt3[1]}");