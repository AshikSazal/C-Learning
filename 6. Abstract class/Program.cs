using System.Diagnostics;
namespace MultipleInheritance
{
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Debug.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Dog : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Debug.WriteLine("The Dog is barking");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myPig = new Dog();  // Create a Pig object
            myPig.animalSound();
            myPig.sleep();
        }
    }
}
