using Microsoft.Xna.Framework;

namespace UG.Physics
{
	public struct Rect
	{
		public Vect center;
		public Vect size;

		public double x { get { return center.x; } set { center.x = value; } }
		public double y { get { return center.x; } set { center.y = value; } }
		public double width { get { return size.x; } set { size.x = value; } }
		public double height { get { return size.y; } set { size.y = value; } }

		public double left { get { return center.x - size.x / 2; } set { center.x = value + size.x / 2; } }
		public double right { get { return center.x + size.x / 2; } set { center.x = value - size.x / 2; } }
		public double top { get { return center.y - size.y / 2; } set { center.y = value + size.y / 2; } }
		public double bottom { get { return center.y + size.y / 2; } set { center.y = value - size.y / 2; } }


		//---------- common constructors ----------//

		public Rect(Vect center, Vect size)
		{ this.center = center; 
			this.size = size; }
		public Rect(Vect center, double width, double height)
		{ this.center = center; 
			this.size = new Vect(width, height); }
		public Rect(double x, double y, Vect size)
		{ this.center = new Vect(x, y); 
			this.size = size; }
		public Rect(double x, double y, double width, double height)
		{ this.center = new Vect(x, y); 
			this.size = new Vect(width, height);
		}

		//---------- Object overloads ----------//

		public override string ToString()
		{ return "(" + center.x.ToString() + ", " + center.y.ToString() + size.x.ToString() + ", " + size.y.ToString() + ")"; }

		public override int GetHashCode()
		{
			var hashCode = 1502939027;
			hashCode *= -1521134295 + base.GetHashCode();
			hashCode *= -1521134295 + center.GetHashCode();
			hashCode *= -1521134295 + size.GetHashCode();
			return hashCode;
		}

		//---------- common-use static vectors ----------//

		///<summary>Square at origin with all sides length 0: (0,0,0,0)</summary>
		public static Rect ZERO_SQUARE { get { return new Rect(0, 0, 0, 0); } }
		///<summary>Square at origin with all sides length 1: (0,0,1,1)</summary>
		public static Rect UNIT_SQUARE { get { return new Rect(0, 0, 1, 1); } }
		///<summary>Flat line rectangle on X: (1,0,1,0)</summary>
		//public static Rect LINE_RECT_X { get { return new Rect(1, 0, 1, 0); } }
		///<summary>Flat line rectangle on Y: (0,1,0,1)</summary>
		//public static Rect LINE_RECT_Y { get { return new Rect(0, 1, 0, 1); } }

		//---------- MonoGame support for Vector2 ----------//

		public Rect(Vector2 center, Vector2 size)
		{ this.center = new Vect(center); 
			this.size = new Vect(size); }
		public Rect(Vector2 center, double width, double height)
		{ this.center = new Vect(center); 
			this.size = new Vect(width, height); }
		public Rect(double x, double y, Vector2 size)
		{ this.center = new Vect(x, y); 
			this.size = new Vect(size); }

		//---------- MonoGame support for Rectangle ----------//

		public Rect(Rectangle r)
		{ this.center = new Vect(r.X + r.Width / 2, r.Y + r.Height / 2); 
			this.size = new Vect(r.Width, r.Height); }
	}
}