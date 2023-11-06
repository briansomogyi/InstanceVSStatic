namespace InstanceVSStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.FirstName); Console.WriteLine(person.LastName);
            Console.WriteLine(Person.PopulationCount);
        }
    }
}