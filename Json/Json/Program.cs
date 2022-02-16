using System.Text.Json;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer myBeer = new Beer()
            {
                Name = "Pikantus",
                Brand = "Erdinger"
            };

            // string json = "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}";

            string json = JsonSerializer.Serialize(myBeer);
            Beer beer = JsonSerializer.Deserialize<Beer>(json); 

            Beer[] beers = new Beer[]
            {
                new Beer()
                {
                    Name = "Pikantus",
                    Brand = "Erdinger"
                },
                new Beer()
                {
                    Name = "Corona",
                    Brand = "Modelo"
                }
            };

            /* string jsonTwo = "[" + "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}," +
                "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}" + "]"; */

            string jsonTwo = JsonSerializer.Serialize(beers);
            Beer[] beersTwo = JsonSerializer.Deserialize<Beer[]>(jsonTwo);
        }

        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }   
        }
    }
}