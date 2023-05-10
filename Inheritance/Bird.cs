using System;
namespace Inheritance
{
	public class Bird : Animals
	{
		public Bird()
		{
			IsFlightless = true;
			IsCarnivorous = true;
		}
		public bool IsFlightless { get; set; }
		public int WingSpanInches { get; set; }
		public bool IsCarnivorous { get; set; }
		public string Species { get; set; }
	}
}

