using System;
public class AbstractClass
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public abstract class Animal
    {
        private string Name;
 
        public void SetName(string name)
        {
            Name = name;
        }
 
        public string GetName()
        {
            return Name;
        }
 
        public abstract void Eat();
    }
	public static void Main(string[] args)
    {
        Dog dog = new Dog();
        Console.WriteLine("Enter the Dog name ");
        dog.SetName(Console.ReadLine());
        Console.WriteLine(dog.GetName());
        dog.Eat();
    }
}