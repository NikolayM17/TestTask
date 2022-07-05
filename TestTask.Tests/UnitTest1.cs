using System;
using TestTask;

using Xunit;

namespace TestTask.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void TestIrregularInput()
		{
			//	Arrange
			double a = 1, b = 2, c = 3;

			//	Act
			IFigure figure = new Triangle(a, b, c);

			double figureArea = figure.GetArea();

			//	Assert

			Assert.Equal(0, figureArea);
		}

		[Fact]
		public void TestCircleArea()
		{
			//	Arrange
			double r = 1;

			//	Act
			IFigure figure = new Circle(r);

			double figureArea = figure.GetArea();

			//	Assert

			Assert.Equal(Math.PI, figureArea);
		}

		[Fact]
		public void TestTriangleArea()
		{
			//	Arrange
			double a = 4, b = 5, c = 6;

			//	Act
			IFigure figure = new Triangle(a, b, c);

			double figureArea = figure.GetArea();

			//	Assert

			Assert.Equal(9, (int)figureArea);
		}

		[Fact]
		public void TestIsTriangleRectangular()
		{
			//	Arrange
			double a = 3, b = 4, c = 5;

			//	Act
			IFigure figure = new Triangle(a, b, c);

			bool isRectangular = ((Triangle)figure).IsRectangular;

			//	Assert

			Assert.True(isRectangular);
		}
	}
}
