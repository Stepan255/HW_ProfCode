// Написать программу, вычисляющую значение периодической функции f(x), в произвольной точке x, если на промежутке [a;b], 
// который составляет один её период, значения функции вычисляются по формуле
// 1. [-3; 3], f(x) = |x| - 1
// 2. [-10; -2], f(x) = 1/x + 0.6
// 3. [-4; 3], f(x) = Cos(|π*x|)

Console.Clear();

void CheckFunction1(int fromNamber, int toNamber)
{
	int heightOfFunction = 5;
	int count = 0;
	for (int x = fromNamber; x <= toNamber; x++)
	{
		int xNamberForFirstFunction = x;
		if (Math.Abs(xNamberForFirstFunction) > 3)
		{
			if (xNamberForFirstFunction > 0)
			{
				if ((xNamberForFirstFunction / 3) % 2 == 0) xNamberForFirstFunction %= 3;
				else xNamberForFirstFunction = xNamberForFirstFunction % 3 - 3;
			}
			else
			{
				if ((xNamberForFirstFunction / 3) % 2 == 0) xNamberForFirstFunction %= 3;
				else xNamberForFirstFunction = xNamberForFirstFunction % 3 + 3;
			}
		}
		Console.SetCursorPosition(x - fromNamber + count, -(Math.Abs(xNamberForFirstFunction) - 1) + heightOfFunction);
		Console.Write("+");
		if (x == 0)
		{
			Console.SetCursorPosition(x - fromNamber + count, heightOfFunction + 2);
			Console.Write("0");
		}
		else if (x == -3)
		{
			Console.SetCursorPosition(x - fromNamber + count - 1, heightOfFunction + 2);
			Console.Write("-3");
		}
		else if (x == 3)
		{
			Console.SetCursorPosition(x - fromNamber + count, heightOfFunction + 2);
			Console.Write("3");
		}
		count += 1;
	}
	Console.SetCursorPosition(0, heightOfFunction + 3);
}

void CheckFunction2(int fromNamber, int toNamber)
{
	int heightOfFunction = 5;
	int count = 0;
	for (int x = fromNamber; x <= toNamber; x++)
	{
		double xNamberForSecondFunction = x;
		while (xNamberForSecondFunction < -10)
		{
			xNamberForSecondFunction += 8;
		}
		while (xNamberForSecondFunction > -2)
		{
			xNamberForSecondFunction -= 8;
		}
		Console.SetCursorPosition(x - fromNamber + count, Convert.ToInt32(-((Math.Round(1 / xNamberForSecondFunction + 0.6, 1)) * 10)) + heightOfFunction);
		Console.Write("+");
		if (x == -2)
		{
			Console.SetCursorPosition(x - fromNamber + count - 2, heightOfFunction + 1);
			Console.Write("-2; ");
		}
		else if (x == -10)
		{
			Console.SetCursorPosition(x - fromNamber + count - 2, heightOfFunction + 1);
			Console.Write("-10; ");
		}
		count += 1;
	}
	Console.SetCursorPosition(0, heightOfFunction + 2);
}

void CheckFunction3(double fromNamber, double toNamber)
{
	int heightOfFunction = 15;
	int count = 0;
	for (double x = fromNamber; x <= toNamber + 0.1; x += 0.1)
	{
		double xNamberForThirdFunction = x;
		while (xNamberForThirdFunction < -4)
		{
			xNamberForThirdFunction += 7;
		}
		while (xNamberForThirdFunction > 3)
		{
			xNamberForThirdFunction -= 7;
		}
		Console.SetCursorPosition(Convert.ToInt32(x - fromNamber + count), Convert.ToInt32(-((Math.Round(Math.Cos(Math.Abs(Math.PI * xNamberForThirdFunction)), 1)) * 10)) + heightOfFunction);
		Console.Write("+");
		// if (Math.Round(x, 0) == -4)
		// {
		// 	Console.SetCursorPosition(Convert.ToInt32(x - fromNamber + count), heightOfFunction * 2 - 3);
		// 	Console.Write("-4; ");
		// }
		// else if (Math.Round(x, 0) == 3)
		// {
		// 	Console.SetCursorPosition(Convert.ToInt32(x - fromNamber + count), heightOfFunction * 2 - 3);
		// 	Console.Write("3");
		// }
		count += 1;
	}
	Console.SetCursorPosition(0, heightOfFunction * 2);
}

double StartProgram()
{
	Console.WriteLine("Периодическая функция f(x) определена на промежутке [a; b], который составляет один ее период, значения функции вычисляются по формуле");
	Console.Write("Введите x = ");
	return Convert.ToDouble(Console.ReadLine());
}

void ResultForFirstFunction(double xNamber)
{
	double xNamberForFirstFunction = xNamber;
	if (Math.Abs(xNamberForFirstFunction) > 3)
	{
		if (xNamberForFirstFunction > 0)
		{
			if ((xNamberForFirstFunction / 3) % 2 == 0) xNamberForFirstFunction %= 3;
			else xNamberForFirstFunction = xNamberForFirstFunction % 3 - 3;
		}
		else
		{
			if ((xNamberForFirstFunction / 3) % 2 != 0) xNamberForFirstFunction %= 3;
			else xNamberForFirstFunction = xNamberForFirstFunction % 3 + 3;
		}
	}
	Console.WriteLine($"1. f({xNamber}) = {Math.Abs(xNamberForFirstFunction) - 1}. Промежуток: [-10; -2], формула: f(x) = |x| - 1.");
}

void ResultForSecondFunction(double xNamber)
{
	double xNamberForSecondFunction = xNamber;
	while (xNamberForSecondFunction < -10)
	{
		xNamberForSecondFunction += 8;
	}
	while (xNamberForSecondFunction > -2)
	{
		xNamberForSecondFunction -= 8;
	}
	Console.WriteLine($"2. f({xNamber}) = {Math.Round(1 / xNamberForSecondFunction + 0.6, 2)}. Промежуток: [-10; -2], формула: f(x) = 1/x + 0.6.");
}

void ResultForThirdFunction(double xNamber)
{
	double xNamberForThirdFunction = xNamber;
	while (xNamberForThirdFunction < -4)
	{
		xNamberForThirdFunction += 8;
	}
	while (xNamberForThirdFunction > 3)
	{
		xNamberForThirdFunction -= 7;
	}
	Console.WriteLine($"3. f({xNamber}) = {Math.Round(Math.Cos(Math.Abs(Math.PI * xNamberForThirdFunction)), 2)}. Промежуток: [-4; 3], формула: f(x) = Cos(|pi*x|).");
}

// CheckFunction1(-30, 30);
// CheckFunction2(-40, 30);
// CheckFunction3(-4, 19);

double xNamber = StartProgram();
ResultForFirstFunction(xNamber);
ResultForSecondFunction(xNamber);
ResultForThirdFunction(xNamber);