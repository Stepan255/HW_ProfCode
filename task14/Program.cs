// TODO Составить программу для поиска целочисленных неотрицательных решений (x,y) уравнения с параметром a

// x2 + 3y2 = a
// x + y + y2 = a
// x2 + y2 = a
namespace task14
{
	class Program
	{
		static string ConverResaltToText(List<Resalt> resaltList)
		{
			string text= string.Empty;
			foreach (Resalt resalt in resaltList)
			{
				text += "(" + resalt.x.ToString() + "," + resalt.y.ToString() + ") ";
			}
			return text;
		}
		static void Main(string[] args)
		{
			Console.Clear();
			Console.Write("Введите число A: ");
			double namberA = Convert.ToInt32(Console.ReadLine());

			List<Resalt> firstResaltList = new List<Resalt>();
			List<Resalt> secondResaltList = new List<Resalt>();
			List<Resalt> thirdResaltList = new List<Resalt>();

			double x = 0;
			for (double y = 0; y <= namberA; y++)
			{
				x = Math.Sqrt(namberA - 3 * y * y) - Math.Sqrt(namberA - 3 * y * y) % 1;
				if (x * x + 3 * y * y == namberA && x >= 0) firstResaltList.Add(new Resalt(x, y));

				x = (namberA - y - y * y) - ((namberA - y - y * y) % 1);
				// Console.WriteLine(y);
				if (x + y + y * y == namberA && x >= 0) secondResaltList.Add(new Resalt(x, y));

				x = Math.Sqrt(namberA - y * y) - Math.Sqrt(namberA - y * y) % 1;
				if (x * x + y * y == namberA && x >= 0) thirdResaltList.Add(new Resalt(x, y));
			}

			Console.WriteLine("Решения для , при а = " + namberA + " - " + ConverResaltToText(firstResaltList));
			Console.WriteLine("Решения для , при а = " + namberA + " - " + ConverResaltToText(secondResaltList));
			Console.WriteLine("Решения для , при а = " + namberA + " - " + ConverResaltToText(thirdResaltList));


		}
	}
}
