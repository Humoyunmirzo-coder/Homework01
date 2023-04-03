namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, number2;
            Console.WriteLine(" This is code Finding perfect numbers!");
            Console.WriteLine(" Enter number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter number: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Below are the perfect number between " + number + " and " + number2);
            for (int i = number; i <= number2; i++)
            {
                decimal sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(" \t " + i);
                }
            }
            Console.ReadKey();
        }
    }
}