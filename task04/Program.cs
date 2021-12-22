// Даны координаты концов двух отрезков [a; b], [c; d]. Верно ли, что
// 1. отрезки не пересекаются
// 2. отрезки пересекаются строго в одной точке
// 3. один отрезок вложен в другой

namespace task04
{
	class Program
	{
		static void Main(string[] args)
		{
			// LineSegment firstLineSegment = LineSegment.CreateLineSegment("№1", "a", "b");
			// LineSegment secondLineSegment = LineSegment.CreateLineSegment("№2", "c", "d");
			// LineSegment.FindCrossing(firstLineSegment, secondLineSegment);

			double[,] arrayCheck = new double[,]{{1, 0, 2, 1, 1, 0, 2, 0},
												{-1, 1, 2, -2, 0, -2, 1, 3},
												{1, 1, 2, 2, 2, 2, 1, 1},
												{-1, 1, -1, 2, 1, 1, 2, 2},
												{-2, -1, -2, 3, 0, -1, 0, 3},
												{-2, 0, 0, 2, 0, -2, 1, 1}
												};
			
			string[] arrayCheckResalt = new string[]{"отрезки пересекаются строго в одной точке",
													"отрезки пересекаются строго в одной точке",
													"один отрезок вложен в другой",
													"отрезки не пересекаются",
													"отрезки не пересекаются",
													"отрезки не пересекаются",};

			for (int i = 0; i < arrayCheck.GetLength(0); i++)
			{
				Point a = new Point(arrayCheck[i, 0], arrayCheck[i, 1]);
				Point b = new Point(arrayCheck[i, 2], arrayCheck[i, 3]);
				Point c = new Point(arrayCheck[i, 4], arrayCheck[i, 5]);
				Point d = new Point(arrayCheck[i, 6], arrayCheck[i, 7]);
				LineSegment firstLineSegment = new LineSegment(a, b);
				LineSegment secondLineSegment = new LineSegment(c, d);
				firstLineSegment.PrintLineSegment();
				secondLineSegment.PrintLineSegment();
				Console.WriteLine($"Верный ответ: {arrayCheckResalt[i]}");
				// Console.WriteLine($"({arrayCheck[i, 0]}, {arrayCheck[i, 1]});({arrayCheck[i, 2]}, {arrayCheck[i, 3]}); ({arrayCheck[i, 4]}, {arrayCheck[i, 5]}); ({arrayCheck[i, 6]}, {arrayCheck[i, 7]})");
				Console.Write($"Ответ программы: ");
				LineSegment.FindCrossing(firstLineSegment, secondLineSegment);
				Console.WriteLine();
			}
		}
	}
}