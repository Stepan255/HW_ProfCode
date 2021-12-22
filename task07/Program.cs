// Даны четыре логические значения f1, f2, f3, f4. Записать условие того, что
// 1. более трёх значений истинны
// 2. хотя бы три значения истинны
// 3. менее трёх значений истинны

Console.Clear();
bool CreateRandomBool()
{
	int randomNamber = new Random().Next(0, 2);
	if (randomNamber == 0) return false;
	else return true;
}

List<bool> fListOfBool = new List<bool>();
for (int i = 0; i < 4; i++)
{
	fListOfBool.Add(CreateRandomBool());
	Console.Write($"{fListOfBool[i]}; ");
}

int count = 0;
foreach (bool f in fListOfBool)
{
	if (f) count += 1;
}


string text = string.Empty;
if (count > 3) text += "более трёх значений истинны\n";
if (count >= 3) text += "хотя бы три значения истинны\n";
if (count < 3) text += "менее трёх значений истинны\n";

Console.WriteLine();
Console.WriteLine(text);