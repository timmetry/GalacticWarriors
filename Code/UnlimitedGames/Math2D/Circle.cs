using Microsoft.Xna.Framework;

namespace UG.Math2d
{
	public struct Circle
	{
		public Vect center;
		public double diameter;
		public double radius
		{ readonly get => diameter / 2; set => diameter = value * 2; }

		public double x { readonly get => center.x; set => center.x = value; }
		public double y { readonly get => center.y; set => center.y = value; }
		public double width { readonly get => diameter; set => diameter = value; }
		public double height { readonly get => diameter; set => diameter = value; }

		public double left { readonly get => center.x - radius; set => center.x = value + radius; }
		public double right { readonly get => center.x + radius; set => center.x = value - radius; }
		public double top { readonly get => center.y - radius; set => center.y = value + radius; }
		public double bottom { readonly get => center.y + radius; set => center.y = value - radius; }

		//---------- common constructors ----------//

		public Circle(Vect center, double diameter)
		{ this.center = center; this.diameter = diameter; }
		public Circle(double x, double y, double diameter)
		{ this.center = new Vect(x, y); this.diameter = diameter; }

		//---------- Object overloads ----------//

		public override readonly string ToString()
		{ return "Circle(" + center.x.ToString() + ", " + center.y.ToString() + ", " + diameter.ToString() + ")"; }

		public override readonly int GetHashCode()
		{
			int hashCode = 1502939027;
			hashCode *= -1521134295 + base.GetHashCode();
			hashCode *= -1521134295 + diameter.GetHashCode();
			hashCode *= -1521134295 + center.GetHashCode();
			return hashCode;
		}

		//---------- common-use static circles ----------//

		///<summary>Square at origin with all sides length 0: (0,0,0)</summary>
		public static Circle ZERO_CIRCLE { get => new Circle(0, 0, 0); }
		///<summary>Square at origin with all sides length 1: (0,0,1)</summary>
		public static Circle UNIT_CIRCLE { get => new Circle(0, 0, 1); }
		///<summary>Flat line rectangle on X: (1,0,0)</summary>
		public static Circle LINE_CIRCLE_X { get => new Circle(1, 0, 0); }
		///<summary>Flat line rectangle on Y: (0,1,0)</summary>
		public static Circle LINE_CIRCLE_Y { get => new Circle(0, 1, 0); }

		//---------- MonoGame support for Vector2 ----------//

		public Circle(Vector2 center, double diameter)
		{ this.center = new Vect(center); this.diameter = diameter; }
	}
}