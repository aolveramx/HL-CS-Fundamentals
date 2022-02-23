namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var ari = new
            {
                Name = "Ari",
                Country = "Mexico"
            };

            Console.WriteLine($"{ari.Name} {ari.Country}");

            var beers = new[]
            {
                new { Name = "red", Brand = "Delirium" },
                new { Name = "London Porter", Brand = "Fullers" }
            };

            foreach (var b in beers)
            {
                Console.WriteLine($"cerveza {b.Name} {b.Brand}");
            }
        }
    }
}