

namespace UG
{
	public abstract class Entity
	{
		public virtual void Update(Clock clock) { }
		public virtual void Draw(Clock clock, Camera camera) { }
	}
}