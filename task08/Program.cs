// Даны пять целых чисел. Выяснить, что
// 1. три из них равны пяти
// 2. больше трёх из них равны пяти
// 3. менее трёх из них равны пяти

Console.Clear();

int[] arrayOfNamber = new int[5];
int count = 0;
for (int i = 0; i < arrayOfNamber.Length; i++)
{
	arrayOfNamber[i] = new Random().Next(4, 7);
	Console.Write($"{arrayOfNamber[i]}; ");
	if (arrayOfNamber[i] == 5) count += 1;
}

string text = string.Empty;
if (count == 3) text += "три из них равны пяти\n";
if (count > 3) text += "больше трёх из них равны пяти\n";
if (count < 3) text += "менее трёх из них равны пяти\n";

Console.WriteLine();
Console.WriteLine(text);