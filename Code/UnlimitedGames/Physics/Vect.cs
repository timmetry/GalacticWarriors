using System;
using Microsoft.Xna.Framework;

namespace UG.Physics
{
	public struct Vect
	{
		public double x;
		public double y;

		public double length
		{ get { return System.Math.Sqrt(x * x + y * y); } }

		//---------- common constructors ----------//

		public Vect(double x, double y)
		{ this.x = x; this.y = y; }

		//---------- Object overloads ----------//

		public override string ToString()
		{ return "(" + x.ToString() + ", " + y.ToString() + ")"; }

		public override int GetHashCode()
		{
			int hashCode = 1502939027;
			hashCode *= -1521134295 + base.GetHashCode();
			hashCode *= -1521134295 + x.GetHashCode();
			hashCode *= -1521134295 + y.GetHashCode();
			return hashCode;
		}

		//---------- common-use static vectors ----------//

		///<summary>Zero vector: (0,0)</summary>
		public static Vect ZERO { get { return new Vect(0, 0); } }
		///<summary>Unit vector on X coordinate: (1,0)
		///<para>To get negative unit vector, use unary - operator.</para></summary>
		public static Vect UNIT_X { get { return new Vect(1, 0); } }
		///<summary>Unit vector on Y coordinate: (0,1)
		///<para>To get negative unit vector, use unary - operator.</para></summary>
		public static Vect UNIT_Y { get { return new Vect(0, 1); } }

		//---------- operator overloads ----------//

		///<summary>Unary - operator: opposite/negative vector. 
		///<para>Both coordinates reversed: (-x,-y)</para></summary>
		public static Vect operator -(Vect a) { return new Vect(-a.x, -a.y); }

		public static Vect operator +(Vect a, Vect b) { return new Vect(a.x + b.x, a.y + b.y); }
		public static Vect operator -(Vect a, Vect b) { return new Vect(a.x - b.x, a.y - b.y); }
		public static Vect operator *(Vect a, double b) { return new Vect(a.x * b, a.y * b); }
		public static Vect operator *(double a, Vect b) { return new Vect(a * b.x, a * b.y); }
		public static Vect operator /(Vect a, double b) { return new Vect(a.x / b, a.y / b); }
		public static Vect operator /(double a, Vect b) { return new Vect(a / b.x, a / b.y); }
		public static Vect operator %(Vect a, double b) { return new Vect(a.x % b, a.y % b); }
		public static Vect operator %(double a, Vect b) { return new Vect(a % b.x, a % b.y); }

		//---------- MonoGame support for Vector2 ----------//

		public Vect(Vector2 v)
		{ this.x = v.X; this.y = v.Y; }

		public static explicit operator Vector2(Vect v)
		{ return new Vector2((float)v.x, (float)v.y); }
	}
}