using System.Threading.Channels;

namespace Domasna_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sumOfEven = new int[6];
            for (int i = 0; i < sumOfEven.Length; i++)
                
                { 
                string input = Console.ReadLine();
                int number = int.Parse(input);
                sumOfEven[i] = number;

            }

            {

                int sum = 0;
                foreach (int number in sumOfEven)
                    if (number % 2 == 0)
                    {
                        sum += number;
                    }else

                    {
                        Console.WriteLine("please enter even number");
                    }
                        Console.WriteLine(sum);
                Console.WriteLine("Hello, World!");
            }
        }
    }
}
