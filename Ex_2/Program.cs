using System.Collections;

namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings= new List<string> {"qwer", "new", "Task", "Octopus", "key", "water"};

            IEnumerable<char> query = strings.Select(x => x[0]).Reverse();

            foreach(var item in query) 
            {
                Console.Write(item + " ");
            }
        }
    }
}