namespace task04
{
	class StraightLine
	{
		// y = k * x + b - уравнение прямой
		public double kIndex;
		public double bIndex;
		public StraightLine(Point p1, Point p2)
		{
			if (p1.x == p2.x)
			{
				kIndex = 0;
				bIndex = 0;
			}else if (p1.y == p2.y)
			{
				kIndex = 0;
				bIndex = p1.y;
			} else 
			{
				kIndex = (p2.y - p1.y) / (p2.x - p1.x);
				bIndex = p1.y - kIndex * p1.x;
			}
		}

	}
}