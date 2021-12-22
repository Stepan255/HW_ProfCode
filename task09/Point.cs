namespace task09
{
	class Point
	{
		public int x;
		public int y;
		public char sym;
		public Point(int x, int y, char sym)
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public Point(Point p)
		{
			this.x = p.x;
			this.y = p.y;
			this.sym = p.sym;
		}

		public static Point PointFromConsole(char sym)
		{
			Console.Write("Введите координату x для точки: x = ");
			int x = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите координату y для точки: y = ");
			int y = Convert.ToInt32(Console.ReadLine());
			return new Point(x, y, sym);
		}

		public void OffsetPoint(int offsetLeft, int offsetTop)
		{
			x += offsetLeft;
			y += offsetTop;
		}

		public void Draw()
		{
		// 	Console.Write($"({x}, {y}, {sym}) ");
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}

		public bool IsHit(Point p)
		{
			if (this.x == p.x && this.y == p.y) return true;
			else return false;
		}
	}
}