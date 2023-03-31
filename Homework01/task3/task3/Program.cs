namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter number : ");
            int numbe1 = int.Parse(Console.ReadLine());
            Console.Write(" Enter number : ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write(" Enter number : ");
            int number3 = int.Parse(Console.ReadLine());
            Console.Write(" Enter number : ");
            int number4 = int.Parse(Console.ReadLine());
            Console.Write(" The smallest of numbers : ");
            Console.WriteLine(Math.Max(Math.Max(numbe1, number2), Math.Max(number3, number4))); 

        }
    }
}