// Сформировать случайным образом N-элементный массив, заполненный однозначными целыми числами разных знаков. Задать k и выяснить
// сколько раз повторяется k в массиве
// сколько элементов находится между первым и последним k
// сколько раз встречается k

Console.Clear();
Console.Write("Введите число N: ");
int namberN = int.Parse(Console.ReadLine());

int[] arrayOfNamber = new int[namberN];
for (int i = 0; i < namberN; i++)
{
	arrayOfNamber[i] = new Random().Next(1, 10);
	Console.Write($"{arrayOfNamber[i]}[{i}]; ");
}

Console.Write("\nВведите число k: ");
int namberK = int.Parse(Console.ReadLine());

List<int> kList = new List<int>();
bool check = false;
for (int i = 0; i < namberN; i++)
	if (arrayOfNamber[i] == namberK) 
	{
		kList.Add(arrayOfNamber[i] + i * 10);
		check = true;
	}

Console.Write(kList.Count() - 1 < 0 ? (kList.Count()) : (kList.Count() - 1));
Console.WriteLine(" раз(а) повторяется k в массиве");

if (check)
{
	Console.Write((kList.Last() / 10 - kList.First() / 10 - 1) < 0 ? 0 : (kList.Last() / 10 - kList.First() / 10 - 1));
	Console.WriteLine(" элементa(-ов) находится между первым и последним k");
} else 
	Console.WriteLine($"Элементов равных {namberK} в массиве нет");

Console.WriteLine($"{kList.Count()} раз(а) встречается k");