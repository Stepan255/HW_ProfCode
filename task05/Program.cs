// Проверить, что натуральное число m
// 1. является счастливым пятизначным
// 2. образовано тремя цифрами, составляющими арифметическую прогрессию
// 3. образовано четырмя одинаковыми цифрами

void PrintColorWrite(string textColor, string text)
{
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.Write(textColor);
	Console.ForegroundColor = ConsoleColor.White;
	Console.WriteLine($" {text}");
}

Console.Clear();

Console.Write("Введите натуральное число m = ");
int mNamber = Convert.ToInt32(Console.ReadLine());

int newNamber = mNamber;
int length = 0;

List<int> listOfSymbol = new List<int>();

while (newNamber > 0)
{
	listOfSymbol.Add(newNamber % 10);
	newNamber /= 10;
	length += 1;
}

string textForHappyNamber = "НЕ";
string textForArithmeticProgression = "НЕ";
string textForIdenticalNumbers = "НЕ";
bool check = true;
if (length == 5)
	for (int i = 0; i < length / 2; i++)
	{
		if (listOfSymbol[i] == listOfSymbol[length - i]) textForHappyNamber = "";
		else
		{
			textForHappyNamber = "НЕ";
			break;
		}
	}
else if (length == 3)
	for (int i = 1; i < length - 1; i++)
	{
		if (listOfSymbol[0] - listOfSymbol[1] == listOfSymbol[i] - listOfSymbol[i + 1]) textForArithmeticProgression = "";
		else
		{
			textForArithmeticProgression = "НЕ";
			break;
		}
	}
else if (length == 4)
	for (int i = 0; i < length - 1; i++)
	{
		if (listOfSymbol[i] == listOfSymbol[i + 1]) textForIdenticalNumbers = "";
		else
		{
			textForIdenticalNumbers = "НЕ";
			break;
		}
	}
else
{
	Console.WriteLine("НЕТ");
	check = false;
}

if (check)
{
	PrintColorWrite(textForHappyNamber, "является счастливым пятизначным");
	PrintColorWrite(textForArithmeticProgression, "образовано тремя цифрами, составляющими арифметическую прогрессию");
	PrintColorWrite(textForIdenticalNumbers, "образовано четырмя одинаковыми цифрами");
}
