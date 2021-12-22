// Проверить, что точка с координатами (x, y) принадлежит фигуре начало координат находится в верхнем левом углу
// 1          2          3 

// █████      █████      █   █
// █   █      █   █      █   █
// █   █      █████      █   █
// █   █          █      █████

namespace task09
{
	class Program
	{
		static void DrawRedLine(int top)
		{
			Console.SetCursorPosition(0, top);
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine();
			Console.ResetColor();
		}

		static void DrawAndFindPoint(Figure figure, Point pointToFind, int namberOfFigure)
		{
			Point temproraryPoint = new Point(pointToFind);
			int offsetLeft = 1;
			int offsetTop = 5;
			temproraryPoint.OffsetPoint(offsetLeft, offsetTop * namberOfFigure);
			figure.OffsetFigure(offsetLeft, offsetTop * namberOfFigure);
			figure.Draw();
			figure.FindPointAtFigure(temproraryPoint);
			int offsetLeftOfText = 10;
			Console.SetCursorPosition(offsetLeftOfText, offsetTop * namberOfFigure);
			Console.Write($"Точка с координатами ({pointToFind.x}, {pointToFind.y}){figure.text} принадлежит {namberOfFigure} фигуре");
		}
		static void Main(string[] args)
		{
			Console.Clear();
			Point pointToFind = Point.PointFromConsole('█');

			int namberOfFigure = 1;
			Figure figure = new Figure(namberOfFigure);
			DrawAndFindPoint(figure, pointToFind, namberOfFigure);

			namberOfFigure = 2;
			figure = new Figure(namberOfFigure);
			DrawAndFindPoint(figure, pointToFind, namberOfFigure);

			namberOfFigure = 3;
			figure = new Figure(namberOfFigure);
			DrawAndFindPoint(figure, pointToFind, namberOfFigure);

			int offsetTop = 5;
			Console.SetCursorPosition(0, offsetTop * 4);
		}
	}
}