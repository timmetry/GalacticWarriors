

namespace UG
{
	public abstract class Manager
	{
		private bool isAwake = false;

		protected void RequireAwake()
		{
			if (!isAwake)
				throw new System.Exception("UG ERROR: This action cannot be performed while the manager is asleep!");
		}
		protected void RequireSleep()
		{
			if (isAwake)
				throw new System.Exception("UG ERROR: This action cannot be performed while the manager is awake!");
		}

		protected void WakeUp()
		{
			RequireSleep(); // TODO - figure out why this doesn't work!
			isAwake = true;
		}
		protected void Sleep()
		{
			RequireAwake(); // TODO - figure out why this doesn't work!
			isAwake = false;
		}
	}
}
