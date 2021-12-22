// Разложите натуральное число n на простые множители и определите
// 1. сколько раз встречается множитель 2 в произведении
// 2. наименьший множитель произведения
// 3. сколько различных множителе

Console.Clear();
Console.Write("Введите натуральное число: n = ");
int nNamber = Convert.ToInt32(Console.ReadLine());

List<int> multipliersList = new List<int>();
List<int> multipliersOriginList = new List<int>();

int temporaryNamber = nNamber;
int countMultiplier2 = 0;
int minMultiplier = nNamber;

for (int i = 2; i <= temporaryNamber; i++)
{
	bool check = true;
	while (temporaryNamber == (temporaryNamber / i) * i)
	{
		multipliersList.Add(i);
		if (i == 2) countMultiplier2 += 1;
		temporaryNamber /= i;
		if (check)
		{
			if (i < minMultiplier) minMultiplier = i;
			multipliersOriginList.Add(i);
			check = false;
		}
	}
}

Console.WriteLine($"Множители натурального числа n:");
foreach (int multiplier in multipliersList)
{
	Console.Write($"{multiplier}; ");
}
Console.WriteLine($"\n{countMultiplier2} раз(а) встречается множитель 2");
Console.WriteLine($"{minMultiplier} - наименьший множитель произведения");
Console.WriteLine($"{multipliersOriginList.Count()} - колличество различных множителей");