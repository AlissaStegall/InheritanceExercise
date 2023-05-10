using System;
namespace Inheritance
{
	public class Animals
	{
		public Animals()
		{
			Color = "Green";
			Size = "Large";
			AnimalClass = "Reptile";
			Age = 0;
		}
		public string Color { get; set; }
		public string Size { get; set; }
		public string AnimalClass { get; set; } //reptile, mammal, etc.
		public int Age { get; set; }
	}
}

