namespace task04
{
	class LineSegment
	{
		public Point p1;
		public Point p2;
		StraightLine straightLine;
		public LineSegment(Point p1, Point p2)
		{
			// if (p1.x == p2.x && p1.y == p2.y)
			// {
			this.p1 = p1;
			this.p2 = p2;
			straightLine = new StraightLine(p1, p2);
			// }
			// else Console.WriteLine($"Невозможно создать отрезок по точкам");
		}

		public static LineSegment CreateLineSegment(string nameOfLineSegment, string nameOfFirstPoint, string nameOfSecondPoint)
		{
			Point p1 = Point.CreatePoint(nameOfLineSegment, nameOfFirstPoint);
			Point p2 = Point.CreatePoint(nameOfLineSegment, nameOfSecondPoint);
			return new LineSegment(p1, p2);
		}

		public static void FindCrossing(LineSegment line1, LineSegment line2)
		{
			if (InParallelOX(line1) || InParallelOX(line2)) FindCrossingPart1(line1, line2);
			else FindCrossingPart2(line1, line2);
		}

		public static void FindCrossingPart1(LineSegment line1, LineSegment line2)
		{
			if (InParallelOX(line1) && InParallelOX(line2))
			{
				if (line1.p1.x == line2.p1.x)
				{
					Console.WriteLine($"Вложенны");
				}
				else
				{
					Console.WriteLine("НЕ пересекаются");
				}
			}
			else
			{
				double x = 0;
				double y = 0;
				if (InParallelOX(line1))
				{
					x = line1.p1.x;
					y = line2.straightLine.kIndex * x + line2.straightLine.bIndex;
				}
				else if (InParallelOX(line2))
				{
					x = line2.p2.x;
					y = line1.straightLine.kIndex * x + line1.straightLine.bIndex;
				}
				Point p = new Point(x, y);
				if (p.CheckPoint1NestedInLineSegment2(line1.p1, line1.p2) && p.CheckPoint1NestedInLineSegment2(line2.p1, line2.p2))
				{
					Console.WriteLine($"пересекаются в точке ({x}, {y})");
				}
				else Console.WriteLine("НЕ пересекаются");
			}
		}

		public static void FindCrossingPart2(LineSegment line1, LineSegment line2)
		{
			double x = (line2.straightLine.bIndex - line1.straightLine.bIndex) / (line1.straightLine.kIndex - line2.straightLine.kIndex);
			if (Math.Round(line1.straightLine.kIndex * x + line1.straightLine.bIndex, 2) == Math.Round(line2.straightLine.kIndex * x + line2.straightLine.bIndex, 2))
			{
				double y = line1.straightLine.kIndex * x + line1.straightLine.bIndex;
				Point p = new Point(x, y);
				if (p.CheckPoint1NestedInLineSegment2(line1.p1, line1.p2) && p.CheckPoint1NestedInLineSegment2(line2.p1, line2.p2))
				{
					Console.WriteLine($"пересекаются в точке ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
				}
				else
				{
					Console.WriteLine("НЕ пересекаются");
				}
			}
			else if (line1.straightLine.bIndex == line2.straightLine.bIndex &&
			line1.straightLine.kIndex == line2.straightLine.kIndex &&
			CheckLineSegment1NestedInLineSegment2(line1, line2))
			{
				Console.WriteLine($"Вложенны");
			}
			else
			{
				Console.WriteLine("НЕ пересекаются");
			}
		}

		public static bool CheckLineSegment1NestedInLineSegment2(LineSegment line1, LineSegment line2)
		{
			if ((line1.p1.CheckPoint1NestedInLineSegment2(line2.p1, line2.p2) &&
			line1.p2.CheckPoint1NestedInLineSegment2(line2.p1, line2.p2)) ||
			(line2.p1.CheckPoint1NestedInLineSegment2(line1.p1, line1.p2) &&
			line2.p2.CheckPoint1NestedInLineSegment2(line1.p1, line1.p2))) return true;
			else return false;
		}

		public static bool InParallelOX(LineSegment line)
		{
			if (line.p1.x == line.p2.x) return true;
			else return false;
		}

		public void PrintLineSegment()
		{
			p1.PrintPoint();
			Console.Write(" ");
			p2.PrintPoint();
			Console.WriteLine();
		}
	}
}