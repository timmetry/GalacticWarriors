

namespace UG
{
	public abstract class Entity
	{
		protected Entity owner;

		protected Entity(Entity owner) { this.owner = owner; }

		public virtual void Update(Clock clock) { }
		public virtual void Draw(Clock clock, Camera camera) { }
	}
}