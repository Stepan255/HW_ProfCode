namespace task12
{
	public class Speed
	{
		public char[] arrayChar;
		int[] symArr;

		List<int[]> symArrList;

		public Speed()
		{
			arrayChar = new char[] { 'С', 'К', 'О', 'Р', 'Т', 'Ь' }; // 6
			symArr = new int[arrayChar.Length];
			symArrList = new List<int[]>();
		}

		public void SpeedFill(int index)
		{
			if (index < 1)
			{

				if (SpeedCheck(symArr))
				{
					int[] array = new int[symArr.Length];
					for (int i = 0; i < symArr.Length; i++)
					{
						array[i] = symArr[i];
					}
					symArrList.Add(array);
				}
				return;
			}
			for (int i = 0; i < 10; i++)
			{
				symArr[index - 1] = i;
				SpeedFill(index - 1);
			}
		}
		// СК*ОР=ОСТЬ
		// СКО-РО=СТЬ
		// СКО+РО=СТЬ
		public bool SpeedCheck(int[] symArr)
		{
			int firstNamber = symArr[0] * 100 + symArr[1] * 10 + symArr[2];
			int secondNamber = symArr[3] * 10 + symArr[2];
			int resalt = symArr[0] * 100 + symArr[4] * 10 + symArr[5];
			if ((symArr[0] * 10 + symArr[1]) * (symArr[2] * 10 + symArr[3]) == (symArr[2] * 1000 + resalt) &&
				firstNamber - secondNamber == resalt &&
				firstNamber + secondNamber == resalt) return true;
			else return false;
		}

		public int BigestSpeed()
		{
			int indexOfMaxSpeed = 0;
			int index = 0;
			int maxSpeed = SpeedValue(symArrList[0]);
			foreach (int[] array in symArrList)
			{
				if (maxSpeed < SpeedValue(array))
				{
					indexOfMaxSpeed = index;
					maxSpeed = SpeedValue(array);
				}
				index++;
			}
			return indexOfMaxSpeed;
		}

		public int SpeedValue(int[] array)
		{
			return array[0] * PowerOfTen(7) + array[1] * PowerOfTen(6) + array[2] *
			PowerOfTen(5) + array[3] * PowerOfTen(4) + array[2] * PowerOfTen(3) +
			array[0] * PowerOfTen(2) + array[4] * 10 + array[5];
		}

		public int PowerOfTen(int pow)
		{
			return Convert.ToInt32(Math.Pow(10, pow));
		}

		public void Print(int index)
		{
			for (int i = 0; i < arrayChar.Length; i++)
			{
				Console.WriteLine($"{arrayChar[i]} = {symArrList[index][i]}");
			}
			Console.WriteLine($"Наибольшая СКОРОСТЬ = {SpeedValue(symArrList[index])}");
		}

		public static void PrintArray(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i]);
			}
			Console.WriteLine();
		}

		public void PrintSymArrList()
		{
			int index = 0;
			foreach (var array in symArrList)
			{
				Print(index);
				index++;
			}
		}
	}
}