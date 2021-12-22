namespace task09
{
	class Figure
	{
		public List<Point> pListFigure;
		public string text;
		public Figure(int namberFigure)
		{
			pListFigure = new List<Point>();
			pListFigure.Clear();
			text = " НЕ";
			if (namberFigure == 1) FirstFigure(pListFigure);
			else if (namberFigure == 2) SecondFigure(pListFigure);
			else if (namberFigure == 3) ThirdFigure(pListFigure);
		}

		public static void AddPointToFigure(int x, int y, List<Point> pListFigure)
		{
			Point p = new Point(x, y, '█');
			pListFigure.Add(p);
		}

		public void Draw()
		{
			foreach (Point p in pListFigure)
			{
				p.Draw();
			}
		}

		public void FindPointAtFigure(Point pToFind)
		{
			foreach (Point p in pListFigure)
			{
				if (p.IsHit(pToFind))
				{
					text = "";
					Console.SetCursorPosition(pToFind.x, pToFind.y);
					Console.ForegroundColor = ConsoleColor.DarkRed;
					pToFind.Draw();
					Console.ResetColor();
					break;
				}
			}
			if (text != "")
			{
				Console.SetCursorPosition(pToFind.x, pToFind.y);
				Console.ForegroundColor = ConsoleColor.DarkBlue;
				pToFind.Draw();
				Console.ResetColor();
			}
		}

		public void OffsetFigure(int offsetLeft, int offsetTop)
		{
			foreach (Point p in pListFigure)
			{
				p.OffsetPoint(offsetLeft, offsetTop);
			}
		}

		public static void FirstFigure(List<Point> pListFigure)
		{
			for (int i = 0; i <= 3; i++)
			{
				AddPointToFigure(0, i, pListFigure);
				AddPointToFigure(4, i, pListFigure);
			}
			AddPointToFigure(1, 0, pListFigure);
			AddPointToFigure(2, 0, pListFigure);
			AddPointToFigure(3, 0, pListFigure);
		}

		public static void SecondFigure(List<Point> pListFigure)
		{
			for (int i = 0; i <= 4; i++)
			{
				AddPointToFigure(i, 0, pListFigure);
				AddPointToFigure(i, 2, pListFigure);
			}
			AddPointToFigure(0, 1, pListFigure);
			AddPointToFigure(4, 1, pListFigure);
			AddPointToFigure(4, 3, pListFigure);
		}

		public static void ThirdFigure(List<Point> pListFigure)
		{
			for (int i = 0; i <= 3; i++)
			{
				AddPointToFigure(0, i, pListFigure);
				AddPointToFigure(4, i, pListFigure);
			}
			AddPointToFigure(1, 3, pListFigure);
			AddPointToFigure(2, 3, pListFigure);
			AddPointToFigure(3, 3, pListFigure);
		}
	}
}