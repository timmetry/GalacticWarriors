

namespace UG
{
	public abstract class Clock : Manager
	{
		public ulong t { get { return ticks; } }
		private ulong ticks = 0;

		protected virtual void Tick() 
		{
			//RequireSleep();
			++ticks;
		}
	}
}
