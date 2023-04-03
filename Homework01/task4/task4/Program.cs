namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter number : ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < 100; i++)
            {

                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}