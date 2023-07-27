using System.Net.NetworkInformation;

namespace MethodOverLoadingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();//hold cntrl and click on the method to see what it does
            var addedInts = Add(2, 2);
            Console.WriteLine(addedInts);
            var addedDoubles = Add(2.5, 2.5);
            var addedDecs = Add(3.00m, 3.00m);
            Greet("Erik");
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static void Greet(string firstName)
        {
            Console.WriteLine($"Hello {firstName}");
        }
        public static void Greet(string firstName, string lastName)
        {
            Console.WriteLine($"Hello {firstName} {lastName}.");
        }
        public static void Greet(string firstName, string lastName, int age)
        {
            Console.WriteLine($"Hello {firstName} {lastName}.  You are {age}.");
        }
            
    }
}