using Microsoft.Xna.Framework;

namespace UG.Math
{
	public struct Vect
	{
		public static Vect ZERO { get { return new Vect(0, 0); } }
		public static Vect UNIT { get { return new Vect(1, 1); } }

		public double x;
		public double y;

		public Vect(double x, double y)
		{ this.x = x; this.y = y; }
		public Vect(Vector2 v)
		{ this.x = v.X; this.y = v.Y; }
	}
}