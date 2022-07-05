using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
	public static class FigureArea
	{
		public static double GetArea()
		{
			var values = GetConsoleValues();

			var figure = GetTypeOfFigure(values);

			return figure is null ? 0 : figure.GetArea();
		}

		private static double[] GetConsoleValues()
		{
			List<double> values = new();

			string input = Console.ReadLine();

			while (input.Length != 0)
			{
				try
				{
					values.Add(double.Parse(input));
				}
				catch
				{
					Console.WriteLine("Irregular Params!");
				}

				input = Console.ReadLine();
			}

			return values.ToArray();
		}

		private static IFigure? GetTypeOfFigure(params double[] values)
		{
			switch (values.Length)
			{
				case 1:
					return new Circle(values[0]);
				case 3:
					return new Triangle(values[0], values[1], values[2]);
				default:
					return null;
			}
		}
	}
}
