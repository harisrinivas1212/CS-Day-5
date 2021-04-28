using System;
 
public class ConstructorsAndDestructors
{
 
    public class Person
    {
        public string Name { get; set; }
 
        public Person(string name)
        {
            Name = name;
        }
 
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
 
        ~Person()
        {
            Name = string.Empty;
        }
    }
	
	public static void Main(string[] args)
    {
		
		Console.WriteLine("Enter Total no of names : ");
		int total = Convert.ToInt32(Console.ReadLine());
        Person[] persons = new Person[total];
 
        for (int i = 0; i < total; i++)
        {
            persons[i] = new Person(Console.ReadLine());
        }
 
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }
    }
}