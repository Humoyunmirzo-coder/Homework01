namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int box = 0;
            Console.WriteLine(" Enter number ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    box++;
                    Console.WriteLine(i);
                }
            }
            if (box == 2)
            {
                Console.WriteLine(" This is a prime number");
            }
            else
            {
                Console.WriteLine(" It is not a  prime   nomber");
            }
        }
    }
}