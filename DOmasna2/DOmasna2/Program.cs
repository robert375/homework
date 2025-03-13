using System.Diagnostics;

namespace DOmasna2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "rob", "bob", "stob", "shlob", "mob" };
            string[] studentsG2 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            Console.WriteLine("select number 1 or 2");
            string input=Console.ReadLine();
            int groupNUmber = int.Parse(input);
            if (groupNUmber == 1)
            {
                Console.WriteLine("the students in g1 are:");
                foreach(string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else if (groupNUmber == 2)
            {
                Console.WriteLine("The students in G2 are:");
                foreach(string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Yo selected wrond number");
            }
                Console.WriteLine("Hello, World!");
        }
    }
}
