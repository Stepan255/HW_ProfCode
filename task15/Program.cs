// Проверить является ли логическое выражение тождеством
// 1. ¬(X ⋀ Y) ⋀ (X ⋁ Y) = X ⊕ Y
// 2. ¬(X or Y) = ¬X ⋀ ¬Y
// 3. (X ⊕ Y) ⋀ X = X ⋀ ¬Y
Console.Clear();

bool TestPhrase(int index, bool[] arrayXY, int namberOfPhrase)
{
	bool check = true;
	if (index < 1)
	{
		bool x = arrayXY[0];
		bool y = arrayXY[1];
		// bool check = false;
		if (namberOfPhrase == 1) check = (!(x & y) & (x | y)) == (x ^ y);
		if (namberOfPhrase == 2) check = (!(x | y)) == (!x & !y);
		if (namberOfPhrase == 3) check = ((x ^ y) & x) == (x & !y);
		Console.WriteLine($"{namberOfPhrase} выражение {check} при X = {x}, Y = {y}");
		return check;
	}
	bool[] arrayBool = { false, true };
	foreach (bool value in arrayBool)
	{
		arrayXY[index - 1] = value;
		if (!TestPhrase(index - 1, arrayXY, namberOfPhrase)) return false;
		// TestPhrase(index - 1, arrayXY, namberOfPhrase);
	}
	return check;
}

int namberOfArguments = 2;
bool[] arrayXY = new bool[namberOfArguments];

if (TestPhrase(namberOfArguments, arrayXY, 1)) Console.WriteLine("1 выражение тождественно\n");
else Console.WriteLine("1 выражение НЕ тождественно\n");

if (TestPhrase(namberOfArguments, arrayXY, 2)) Console.WriteLine("2 выражение Тождественно\n");
else Console.WriteLine("2 выражение НЕ тождественно\n");

if (TestPhrase(namberOfArguments, arrayXY, 3)) Console.WriteLine("3 выражение тождественно\n");
else Console.WriteLine("3 выражение НЕ тождественно\n");