// Выяснить является ли вещественное m
// 1. целой степенью числа 3
// 2. корнем целой степени из 5,
// 3. синусом угла кратного 45 градусам

void PrintColorWrite(string textColor, string text)
{
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.Write(textColor);
	Console.ForegroundColor = ConsoleColor.White;
	Console.WriteLine($" {text}");
}

Console.Clear();
Console.Write("Введите вещественное число m = ");
double mNamber = Convert.ToDouble(Console.ReadLine());


double temporaryNamber = 1;
string textForPowOfNamber = "НЕ";
if (mNamber >= 3)
{
	while (temporaryNamber < mNamber)
		temporaryNamber *= 3;
	if (temporaryNamber == mNamber) textForPowOfNamber = "";
}


temporaryNamber = 5;
double temporaryPowOfNamber = 0;
string textForSqrtOfNamber = "НЕ";
if (mNamber <= temporaryNamber && mNamber > 1)
{
	temporaryPowOfNamber = 1;
	while (Math.Round(Math.Pow(temporaryNamber, 1.0 / temporaryPowOfNamber), 5) > Math.Round(mNamber, 5))
		temporaryPowOfNamber += 1;
	if (Math.Round(Math.Pow(temporaryNamber, 1 / temporaryPowOfNamber), 5) == Math.Round(mNamber, 5)) textForSqrtOfNamber = "";
	Console.WriteLine($"{temporaryPowOfNamber}; {Math.Pow(temporaryNamber, 1.0 / temporaryPowOfNamber)} = {Math.Round(mNamber, 5)}; {Math.Round(Math.Pow(27, 1.0/3.0), 5)}");
}
else if (mNamber > temporaryNamber)
{
	temporaryPowOfNamber = 1;
	while (Math.Round(Math.Pow(temporaryNamber, temporaryPowOfNamber), 0) < Math.Round(mNamber, 0))
		temporaryPowOfNamber += 1;
	if (Math.Round(Math.Pow(temporaryNamber, 1 / temporaryPowOfNamber), 0) == Math.Round(mNamber, 0)) textForSqrtOfNamber = "";
}


string textForSin = "НЕ";
for (int i = 0; i < 8; i++)
{
	if (mNamber == Math.Round(Math.Sin(i * Math.PI / 4), 4))
	{
		textForSin = "";
		break;
	}
}

Console.WriteLine("Число m: ");
PrintColorWrite(textForPowOfNamber, "является целой степенью числа 3");
PrintColorWrite(textForSqrtOfNamber, "является корнем целой степени из 5");
PrintColorWrite(textForSin, "является синусом угла кратного 45 градусам");