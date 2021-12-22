// Cформировать случайным образом целочисленный массив из M натуральных двузначных чисел. Найти среднее арифметическое значение A и
// число элементов, меньших A
// два соседних элемента, между которыми находится A
// элемент, наиболее близкий к A

Console.Clear();

Console.Clear();
Console.Write("Введите число M: ");
int length = int.Parse(Console.ReadLine());

int[] arrayOfNamber = new int[length];
int sum = 0;
for (int i = 0; i < length; i++)
{
	arrayOfNamber[i] = new Random().Next(10, 100);
	Console.Write($"{arrayOfNamber[i]}, ");
	sum += arrayOfNamber[i];
}

double average = Convert.ToDouble(sum) / Convert.ToDouble(length);
int countMin = 0;
if (arrayOfNamber[0] < average) countMin += 1;
double namberMin = Math.Abs(Convert.ToDouble(arrayOfNamber[0]) - average);
int indexMin = 0;
int firstIndex = -1;
int secondIndex = -1;
for (int i = 1; i < length; i++)
{
	if (arrayOfNamber[i] < average) countMin += 1;

	if ((arrayOfNamber[i] > average && arrayOfNamber[i - 1] < average) ||
		(arrayOfNamber[i] < average && arrayOfNamber[i - 1] > average))
		{
			firstIndex = i;
			secondIndex = i - 1;
		}

	if (Math.Abs(Convert.ToDouble(arrayOfNamber[i]) - average) < namberMin)
	{
		indexMin = i;
		namberMin = Math.Abs(Convert.ToDouble(arrayOfNamber[i]) - average);
	}
}

Console.WriteLine($"\nСреднее арифметическое: A = {average}");

Console.WriteLine($"Число элементов, меньших A - {countMin}");

Console.WriteLine($"Два соседних элемента, между которыми находится A: {arrayOfNamber[firstIndex]}, {arrayOfNamber[secondIndex]}");

Console.WriteLine($"Элемент, наиболее близкий к A: {arrayOfNamber[indexMin]}");