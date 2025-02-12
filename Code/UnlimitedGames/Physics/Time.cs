using System;
using Microsoft.Xna.Framework;

namespace UG.Physics
{
	public struct Time
	{
		//---------- foundational constants ----------//

		public const long MCS_PER_MICROSECOND = 1L;
		public const long MCS_PER_MILISECOND = 1000L;
		public const long MCS_PER_SECOND = MCS_PER_MILISECOND * 1000L;
		public const long MCS_PER_MINUTE = MCS_PER_SECOND * 60L;
		public const long MCS_PER_HOUR = MCS_PER_MINUTE * 60L;
		public const long MCS_PER_DAY = MCS_PER_HOUR * 24L;
		public const long MCS_PER_YEAR = MCS_PER_DAY * 365L;

		//---------- variables & accessors ----------//

		public long mcs;

		public double ms { readonly get => (double)mcs / MCS_PER_MILISECOND; set => mcs = (long)Math.Round(value * MCS_PER_MILISECOND); }
		public double s { readonly get => (double)mcs / MCS_PER_SECOND; set => mcs = (long)Math.Round(value * MCS_PER_SECOND); }
		public double m { readonly get => (double)mcs / MCS_PER_MINUTE; set => mcs = (long)Math.Round(value * MCS_PER_MINUTE; }
		public double h { readonly get => (double)mcs / MCS_PER_HOUR; set => mcs = (long)Math.Round(value * MCS_PER_HOUR); }
		public double d { readonly get => (double)mcs / MCS_PER_DAY; set => mcs = (long)Math.Round(value * MCS_PER_DAY); }
		public double y { readonly get => (double)mcs / MCS_PER_YEAR; set => mcs = (long)Math.Round(value * MCS_PER_YEAR); }

		//---------- common constructors ----------//

		public Time(long microSeconds) { this.mcs = microSeconds; }

		public Time(double hours, double minutes, double seconds) 
		{ this.mcs = (long)Math.Round(hours * MCS_PER_HOUR + minutes * MCS_PER_MINUTE + seconds * MCS_PER_SECOND); }

		//---------- Object overloads ----------//

		public override readonly string ToString()
		{ return ms.ToString() + "ms"; }

		public override readonly int GetHashCode()
		{
			int hashCode = 1502939027;
			hashCode *= -1521134295 + base.GetHashCode();
			hashCode *= -1521134295 + ms.GetHashCode();
			return hashCode;
		}

		//---------- common-use static times ----------//

		public static Time MICROSECOND { get => new Time(MCS_PER_MICROSECOND); }
		public static Time MILISECOND { get => new Time(MCS_PER_MILISECOND); }
		public static Time SECOND { get => new Time(MCS_PER_SECOND); }
		public static Time MINUTE { get => new Time(MCS_PER_MINUTE); }
		public static Time HOUR { get => new Time(MCS_PER_HOUR); }
		public static Time DAY { get => new Time(MCS_PER_DAY); }
		public static Time YEAR { get => new Time(MCS_PER_YEAR); }

		//---------- operator overloads ----------//



		//---------- MonoGame support for TimeSpan ----------//
	}
}
