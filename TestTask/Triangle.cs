using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
	public class Triangle : IFigure
	{
		private readonly double _a, _b, _c;

		private double _p { get => (_a + _b + _c) / 2; }

		public bool IsRectangular
		{
			get
			{
				List<double> list = new(new double[] { _a, _b, _c });

				double c = list.Find(c => c == list.Max());
				list.Remove(list.Max());

				return Math.Pow(c, 2) == Math.Pow(list[0], 2) + Math.Pow(list[1], 2);
			}
		}

		public Triangle(double a, double b, double c)
		{
			_a = a;
			_b = b;
			_c = c;
		}

		public double GetArea()
		{
			Console.WriteLine($"Is Triangle Rectangular: {IsRectangular}");

			return Math.Sqrt(_p * (_p - _a) * (_p - _b) * (_p - _c));
		}
	}
}
