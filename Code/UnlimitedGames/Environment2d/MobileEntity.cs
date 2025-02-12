using System;
using UG.Math2d;

namespace UG.Environment2d
{
	public abstract class MobileEntity : StaticEntity
	{
		public Vect mov;

		public MobileEntity(Entity owner, Vect startPos) : base(owner, startPos) { }
		public MobileEntity(Entity owner, double startX, double startY) : base(owner, startX, startY) { }
	}
}
