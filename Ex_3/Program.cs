using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Clients> clients = new List<Clients>
            {
                new Clients { Id= 1, Month = 7, Year = 2022, TrainingTime = 40},
                new Clients { Id= 2, Month = 6, Year = 2023, TrainingTime = 38},
                new Clients { Id= 3, Month = 9, Year = 2022, TrainingTime = 30},
                new Clients { Id= 4, Month = 8, Year = 2023, TrainingTime = 50},
                new Clients { Id= 4, Month = 4, Year = 2021, TrainingTime = 50},
                new Clients { Id= 4, Month = 3, Year = 2021, TrainingTime = 38},
            };

            var query = clients.GroupBy(x => x.Year).Select(x => $"{x.Sum(x => x.TrainingTime)} часов - в {x.Key}").Last();

            Console.WriteLine(query);
        }
    }

    class Clients
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int TrainingTime { get; set; }
        public int Id { get; set; }
    }
}