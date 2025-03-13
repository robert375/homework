using System.Diagnostics;

namespace domasna
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 10;
            int num2 = 15;
            int num3 = num1 + num2;
            Console.WriteLine(num3);






            int ave1 = 10;
            int ave2 = 15;
            int ave3 = 20;
            int ave4 = 30;

            int avg =( ave1 + ave2 + ave3 + ave4) / 4;
            Console.WriteLine(avg);


            int firstNum = 5;
            int secondNum = 8;

            (firstNum, secondNum) = (secondNum, firstNum);
            Console.WriteLine($"firstNum={firstNum} secondNum={secondNum}");
            


            Console.WriteLine("Hello, World!");
        }
    }
}
