using System.Threading;
Console.Clear();

void PulsationOFleColor(int namberOfLamps, int stepOfColor, int sleepTime)
{
	/* 
	! R--arrayOfLamps[0, namberOfLamps]; 
	! G--arrayOfLamps[1, namberOfLamps]; 
	! B--arrayOfLamps[2, namberOfLamps]; 
	условие--arrayOfLamps[3, namberOfLamps];
	*/

	int rgb = 3 + 1; // TODO для переполнения задать еще одну переменную в цикле и в нее записывать переполнение
	int[,] arrayOfLamps = new int[rgb, namberOfLamps];

	for (int i = 0; i <= arrayOfLamps.GetUpperBound(1); i++)
	{
		int count = 0;
		while (arrayOfLamps[3, i] == 0)
		{
			int checkFor1 = i * stepOfColor - (count * 255 * 4);
			int checkFor2 = i * stepOfColor - 255 - (count * 255 * 4);
			int checkFor3 = i * stepOfColor - 255 - 255 - (count * 255 * 4);
			int checkFor4 = i * stepOfColor - 255 - 255 - 255 - (count * 255 * 4);
			if (checkFor1 <= 255 - stepOfColor) 
			{
				arrayOfLamps[0, i] = 255;
				arrayOfLamps[1, i] = checkFor1;
				arrayOfLamps[3, i] = 1;
			}
			else if (checkFor2 <= 255 - stepOfColor) 
			{
				arrayOfLamps[0, i] = 255 - checkFor2;
				arrayOfLamps[1, i] = 255;
				arrayOfLamps[3, i] = 2;
			}
			else if (checkFor3 <= 255 - stepOfColor) 
			{
				arrayOfLamps[1, i] = 255 - checkFor3;
				arrayOfLamps[2, i] = checkFor3;
				arrayOfLamps[3, i] = 3;
			}
			else if (checkFor4 <= 255 - stepOfColor) 
			{
				arrayOfLamps[0, i] = checkFor4;
				arrayOfLamps[2, i] = 255 - checkFor4;
				arrayOfLamps[3, i] = 4;
			}
			count += 1;
		}
	}

	while (true)
	{
		Console.Write("{");
		for (int i = 0; i <= arrayOfLamps.GetUpperBound(1); i++)
		{
			if (i == 0) Console.Write($"({arrayOfLamps[0, i]}, {arrayOfLamps[1, i]}, {arrayOfLamps[2, i]})");
			else
				Console.Write($",({arrayOfLamps[0, i]}, {arrayOfLamps[1, i]}, {arrayOfLamps[2, i]})");
			
			if (arrayOfLamps[3, i] == 1)
			{
				arrayOfLamps[1, i] += stepOfColor;
				if (arrayOfLamps[1, i] >= 255) 
				{
					arrayOfLamps[3, i] = 2;
					arrayOfLamps[1, i] = 255;
				}
			}

			if (arrayOfLamps[3, i] == 2)
			{
				arrayOfLamps[0, i] -= stepOfColor;
				if (arrayOfLamps[0, i] <= 0) 
				{
					arrayOfLamps[3, i] = 3;
					arrayOfLamps[0, i] = 0;
				}
			}

			if (arrayOfLamps[3, i] == 3)
			{
				arrayOfLamps[1, i] -= stepOfColor;
				arrayOfLamps[2, i] += stepOfColor;
				if (arrayOfLamps[2, i] >= 255 || arrayOfLamps[1, i] <= 0) 
				{
					arrayOfLamps[3, i] = 4;
					arrayOfLamps[2, i] = 255;
					arrayOfLamps[1, i] = 0;
				}
			}

			if (arrayOfLamps[3, i] == 4)
			{
				arrayOfLamps[0, i] += stepOfColor;
				arrayOfLamps[2, i] -= stepOfColor;
				if (arrayOfLamps[0, i] >= 255 || arrayOfLamps[2, i] <= 0) 
				{
					arrayOfLamps[3, i] = 1;
					arrayOfLamps[2, i] = 0;
					arrayOfLamps[0, i] = 255;
				}
			}
		}
		Console.WriteLine("}");
		Console.WriteLine();
		Thread.Sleep(sleepTime);
		Console.Clear();
	}
}

PulsationOFleColor(60, 5, 1000);

/*
for (int i = 0; i <= 255; i++)
{
	Console.WriteLine($"{({255-i, i, 0})}");
}


{(255,0,0),(255,0,0),(255,0,0),(255,0,0)}

for (int i = 0; i < length; i++)
{
	
}

while(true)
{
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine();
Thread.Sleep(100);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine();
Thread.Sleep(100);
}*/
