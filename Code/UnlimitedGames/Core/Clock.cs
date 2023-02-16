

namespace UG
{
	public abstract class Clock : Manager
	{
		public ulong t { get { return ticks; } }
		private ulong ticks = 0;

		public virtual void Tick()
		{
			++ticks;
			WakeUp();
		}
		public virtual void Tock()
		{
			Sleep();
		}
	}
}
