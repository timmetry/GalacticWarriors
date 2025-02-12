using System;
using UG.Math2d;

namespace UG.Environment2d
{
	public abstract class StaticEntity : Entity
	{
		public Vect pos;

		public StaticEntity(Entity owner, Vect startPos)
			: base(owner)
		{ this.pos = startPos; }
		public StaticEntity(Entity owner, double startX, double startY)
			: base(owner)
		{ this.pos = new Vect(startX, startY); }
	}
}
