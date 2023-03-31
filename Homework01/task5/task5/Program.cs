namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    THIS IS CODE NOT YET  FULL

            Console.WriteLine(" Enter number  ");
            int max = 0;
            int number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                max++;
                number = int.Parse(Console.ReadLine());
            }
            if (number == 0)
            {
                Console.WriteLine(max);
            }
        }
    }
}