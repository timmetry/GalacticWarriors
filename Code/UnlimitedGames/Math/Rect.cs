using Microsoft.Xna.Framework;

namespace UG.Math
{
	public struct Rect
	{
		public Vect center;
		public Vect size;

		public Rect(Vect center, Vect size)
		{ this.center = center; this.size = size; }
		public Rect(Vect center, double width, double height)
		{ this.center = center; this.size = new Vect(width, height); }
		public Rect(double x, double y, Vect size)
		{ this.center = new Vect(x, y); this.size = size; }
		public Rect(double x, double y, double width, double height)
		{ this.center = new Vect(x, y); this.size = new Vect(width, height); }

		public Rect(Vector2 center, Vector2 size)
		{ this.center = new Vect(center); this.size = new Vect(size); }
		public Rect(Vector2 center, double width, double height)
		{ this.center = new Vect(center); this.size = new Vect(width, height); }
		public Rect(double x, double y, Vector2 size)
		{ this.center = new Vect(x, y); this.size = new Vect(size); }
		public Rect(Rectangle rect)
		{ this.center = new Vect(x, y); this.size = new Vect(width, height); }
	}
}