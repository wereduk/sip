using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sip
{
	class Program
	{
		static void Main(string[] args)
		{

			double time;
			double step;
			double sizeStep;
			double remainingTime = 0;
			double size;
			for (; ; )
			{
				Console.WriteLine("Witam w symulacji prof. Krupy");
				Console.Write("Proszę podać ilość czasu: ");
				bool result1 = double.TryParse(Console.ReadLine(), out time);
				Console.Write("Proszę podać krok: ");
				bool result2 = double.TryParse(Console.ReadLine(), out step);
				Console.Write("Proszę podać krok przyrostu kuli: ");
				bool result3 = double.TryParse(Console.ReadLine(), out sizeStep);
				Console.Write("Proszę podać rozmiar początkowy kuli: ");
				bool result4 = double.TryParse(Console.ReadLine(), out size);

				++sizeStep;
				Console.WriteLine("Czas		rozmiar");

				if (((result1 && result2) && (result1 && result3)) && (result4))
				{
					do
					{
						Console.Write(remainingTime);
						Console.Write("		");
						Console.WriteLine("{0:N2}", size);
						size *= sizeStep;
						remainingTime += step;
					} while (remainingTime <= time);
				}
				else
				{
					Console.WriteLine("Podane złe dane.");
					if (!result1)
					{
						Console.WriteLine("result1");
					}
					if (!result2)
					{
						Console.WriteLine("result2");
					}
					if (!result3)
					{
						Console.WriteLine("result3");
					}
					if (!result4)
					{
						Console.WriteLine("result4");
					}
				}



				Console.ReadKey();

			}
		}
	}
}
