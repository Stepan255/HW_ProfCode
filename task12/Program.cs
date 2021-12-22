// Каждая буква замещает некоторую десятичную цифру 0 - 9. Расшифруйте равенство и найдите наибольшую СКОРОСТЬ.

// СК*ОР=ОСТЬ
// СКО-РО=СТЬ
// СКО+РО=СТЬ
namespace task12
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();
			// List<Speed> speedList = new List<Speed>();

			Speed speed = new Speed();
			// speed.Print();
			speed.SpeedFill(speed.arrayChar.Length);

			int index = speed.BigestSpeed();
			speed.Print(index);
			// speed.PrintSymArrList();
		}
	}
}
