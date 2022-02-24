using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Beer> beers = new List<Beer>()
            {
                new Beer(){
                    Name = "Corona",
                    Country = "México"
                },
                new Beer(){
                    Name = "Delirium",
                    Country = "Bélgica"
                },
                new Beer(){
                    Name = "Erdinger",
                    Country = "Deutschland"
                }
            };

            foreach (Beer beer in beers)
                Console.WriteLine($"Beer: {beer.Name}, Country: {beer.Country}");

            Console.WriteLine("--------------------");

            // select
            var beersName = from b in beers
                            select new
                            {
                                Name = b.Name,
                                Letters = b.Name.Length,
                                Fixed = 1
                            };

            foreach (var beer in beersName)
                Console.WriteLine($"{beer.Name} {beer.Letters} {beer.Fixed}");

            Console.WriteLine("--------------------");

            var beerRealName = from b in beersName
                               select new
                               {
                                   Name = b.Name
                               };

            foreach(var beer in beerRealName)
                Console.WriteLine($"{beer.Name}");

            // filter
            var beerMéxico = from b in beers
                             where b.Country == "México"
                             || b.Country == "Deutschland"
                             select b;

            foreach (var beer in beerMéxico)
                Console.WriteLine(beer);

            Console.WriteLine("--------------------");

            // sort
            var orderedBeers = from b in beers
                               orderby b.Country descending
                               select b;

            foreach (var beer in orderedBeers)
                Console.WriteLine(beer);


        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name}, País: {Country}";
        }
    }
}