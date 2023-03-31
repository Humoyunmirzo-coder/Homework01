namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeral;
            Console.WriteLine(" Enter number");
            int.TryParse(Console.ReadLine(), out numeral);

            if (numeral == 0)
            {
                Console.WriteLine(" This is number defauld has value !");
            }
            for (int i = 0; i < numeral; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}