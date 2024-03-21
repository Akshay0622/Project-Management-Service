using System;

namespace AnimalNamespace
{
   
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Define a derived class
    public class Dog : Animal
    {
        public string Breed { get; set; }

        // Constructor
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        // Method overriding
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects
            AnimalNamespace.Animal genericAnimal = new AnimalNamespace.Animal("Generic", 5);
            AnimalNamespace.Dog myDog = new AnimalNamespace.Dog("Buddy", 3, "Labrador");

            // Accessing properties and methods
            Console.WriteLine("Generic Animal:");
            Console.WriteLine($"Name: {genericAnimal.Name}, Age: {genericAnimal.Age}");
            genericAnimal.MakeSound();

            Console.WriteLine("\nMy Dog:");
            Console.WriteLine($"Name: {myDog.Name}, Age: {myDog.Age}, Breed: {myDog.Breed}");
            myDog.MakeSound();
        }
    }
}
