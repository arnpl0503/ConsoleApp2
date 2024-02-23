using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter 5 grades separated by new line: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());
            double grade2 = Convert.ToDouble(Console.ReadLine());
            double grade3 = Convert.ToDouble(Console.ReadLine());
            double grade4 = Convert.ToDouble(Console.ReadLine());
            double grade5 = Convert.ToDouble(Console.ReadLine());

            double total = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            double SquareRoot = Math.Round(total);
            Console.WriteLine("The average is " +  total +  " round of to " + SquareRoot);
            Console.WriteLine("Press any key to exit...");
          
        }
    }
}