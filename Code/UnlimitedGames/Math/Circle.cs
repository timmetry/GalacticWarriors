

namespace UG.Math
{
	public struct Circle
	{
		public Vect center;
		public double diameter;
		public double radius
		{ get { return diameter / 2; } set { diameter = value * 2; } }

		public Circle(Vect center, double diameter)
		{ this.center = center; this.diameter = diameter; }
		public Circle(double x, double y, double diameter)
		{ this.center = new Vect(x, y); this.diameter = diameter; }
	}
}