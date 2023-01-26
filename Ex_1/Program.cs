namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 5, 10, 45, -8, 13, 95, 14, -20, 4, -10 };

            var query = from num in numbers
                        where num % 2 == 0
                        where num < 0
                        select num;

            foreach (var item in query.Reverse())
            {
                Console.Write(item + " ");
            }

        }
    }
}