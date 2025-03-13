namespace Domasna_3
{
    internal class Program
    {
        static void Main(string[] args)
            
        {

            
            string stringDate = "1997-6-18";

            DateTime convertDate = DateTime.Parse(stringDate);
            Console.WriteLine(stringDate);
            DateTime currentDay = DateTime.Today;
            Console.WriteLine(currentDay);

            Console.WriteLine(convertDate.Month);




           


            static int AgeCalculator(DateTime birthDate)
            {
                int age = DateTime.Today.Year - birthDate.Year;
                return age;
                    }


                    Console.WriteLine("Hello, World!");



        }
    }
}
