using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var newBird = new Bird();
            newBird.Age = 7;
            newBird.AnimalClass = "Aves";
            newBird.Color = "Green";
            newBird.IsCarnivorous = false;
            newBird.IsFlightless = false;
            newBird.Size = "Medium";
            newBird.Species = "Green Parakeet";
            newBird.WingSpanInches = 18;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var Iguana = new Reptile()
            {
                NumberOfLegs = 4,
                NumberOfLungs = 2,
                LiveBirth = false,
                Habitat = "Tropical",
                Age = 12
            };

            var myAnimals = new Animals[] { newBird, Iguana };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Age: {animal.Age} years old");
                Console.WriteLine($"Class: {animal.AnimalClass}");
                Console.WriteLine($"Color: {animal.Color}");
                Console.WriteLine("");
            }
        }
    }
}
