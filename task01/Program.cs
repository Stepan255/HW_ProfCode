// TODO Подсчитать количество натуральных чисел, не превосходящих заданного числа n, которые
// 1. делятся на k, но не на l
// 2. делятся хотябы на k или на l
// 3. не делятся на (k + l)
Console.Clear();
Console.WriteLine("Подсчитать количество натуральных чисел, не превосходящих заданного числа n, которые");

int k = 2;
int l = 5;
Console.WriteLine($"1. делятся на {k}, но не на {l}");
Console.WriteLine($"2. делятся хотябы на {k} или на {l}");
Console.WriteLine($"3. не делятся на ({k} + {l})");
Console.Write("Введите число n = ");
int namberN = Convert.ToInt32(Console.ReadLine());

int countFor1 = 0;
int countFor2 = 0;
int countFor3 = 0;
for (int i = 1; i <= namberN; i++)
{
	if (i % k == 0 && i % l != 0) countFor1 += 1;
	if (i % k == 0 || i % l == 0) countFor2 += 1;
	if (i % (k + l) != 0) countFor3 += 1;
}

Console.WriteLine($"1. {countFor1}\n2. {countFor2}\n3. {countFor3}");