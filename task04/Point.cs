namespace task04
{
	class Point
	{
		public double x;
		public double y;
		public Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public static Point CreatePoint(string nameOfLineSegment, string nameOfPoint)
		{
			Console.Write($"Введите координату x точки {nameOfPoint}, для отрезка {nameOfLineSegment} x = ");
			double x = Convert.ToDouble(Console.ReadLine());
			Console.Write($"Введите координату y точки {nameOfPoint}, для отрезка {nameOfLineSegment} y = ");
			double y = Convert.ToDouble(Console.ReadLine());
			return new Point(x, y);
		}

		public void PrintPoint()
		{
			Console.Write($"({x}, {y})");
		}

		public bool CheckPoint1NestedInLineSegment2(Point pOut1, Point pOut2)
		{
			double x1 = 0;
			double y1 = 0;
			double x2 = 0;
			double y2 = 0;
			if (pOut1.x < pOut2.x)
			{
				x1 = pOut1.x;
				x2 = pOut2.x;
			}
			else
			{
				x1 = pOut2.x;
				x2 = pOut1.x;
			}
			if (pOut1.y < pOut2.y)
			{
				y1 = pOut1.y;
				y2 = pOut2.y;
			}
			else
			{
				y1 = pOut2.y;
				y2 = pOut1.y;
			}
			if ((x >= x1 && x <= x2 && 
			y >= y1 && y <= y2))
			return true;
			else return false;
		}
	}
}