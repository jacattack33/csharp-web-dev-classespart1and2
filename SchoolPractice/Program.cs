using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student jacque = new Student("Jacque", 1, 1, 4.0);
            Console.WriteLine("The Student class works! " + jacque.Name + " is a student!");
        }
    }
}
