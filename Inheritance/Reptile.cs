using System;
namespace Inheritance
{
	public class Reptile : Animals
	{
		public Reptile()
		{
			LiveBirth = false;
			NumberOfLungs = 0;
			NumberOfLegs = 0;
		}
		public int NumberOfLegs { get; set; }
		public bool LiveBirth { get; set; }
		//some reptiles lay eggs others birth live young
		public int NumberOfLungs { get; set; }
		//all reptiles have at least 1 lung
		public string Habitat { get; set; }
	}
}

