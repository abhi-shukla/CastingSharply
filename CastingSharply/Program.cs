using System;
using System.Diagnostics;

namespace CastingSharply
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p0 = new Person { Name = "Abhi" };

            object originalPerson = (object)p0;

            Person originalPerson1 = originalPerson as Person;
            Console.WriteLine(originalPerson1.Name);

            bool originalPerson2 = originalPerson1 is Person;
            Console.WriteLine("Result of casting of a type object dto person is - " + originalPerson2);

            Person originalPerson3 = (Person)originalPerson;
            Console.WriteLine(originalPerson3.Name);

            object obj1 = new object();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                Person person1 = (Person)obj1;
                Console.WriteLine(person1);
            }
            catch(InvalidCastException castException)
            {
                Console.WriteLine(castException.Message);
            }
            stopwatch.Stop();
            Console.WriteLine("Total time taken to handle invalid cast in standard type casting is " + stopwatch.ElapsedMilliseconds);


            stopwatch.Restart();
            Person person2 = obj1 as Person;
            if (person2 != null)
            {
                Console.WriteLine(person2);
            }
            else
            {
                Console.WriteLine("The person was not the original type of the object");
            }
            stopwatch.Stop();
            Console.WriteLine("Total time taken to handle invalid cast using as is " + stopwatch.ElapsedMilliseconds);

            bool person3 = obj1 is Person;
            Console.WriteLine("Result of casting of a type object dto person is - " + person2);


            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
