namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            (int id, string name) product = (1, "Tupla tipada");

            Console.WriteLine($"{product.id} {product.name}");

            product.name = "Dato modificado";

            var person = (1, "Tupla sin tipar");

            Console.WriteLine($"persona {person.Item1} {person.Item2}");

            var people = new[]
            {
                (1, "Ari"),
                (2, "Jorge"),
                (3, "Pedro")
            };

            foreach (var p in people)
            {
                Console.WriteLine($"{p.Item1} {p.Item2}");
            }

            (int id, string name)[] people2 = new[]
            {
                (1, "Ari"),
                (2, "Jorge"),
                (3, "Pedro")
            };

            foreach (var p in people2)
            {
                Console.WriteLine($"{p.id} {p.name}");
            }

            var cityInfo = getLocationCDMX();
            Console.WriteLine($"lat: {cityInfo.lat}, lng: {cityInfo.lng}, name: {cityInfo.name}");

            var (_, lng, _) = getLocationCDMX();

            Console.WriteLine(lng);
        }
        public static (float lat, float lng, string name) getLocationCDMX()
        {
            float lat = 19.12121f;
            float lng = -99.19212f;
            string name = "CDMX";

            return (lat, lng, name);
        }
    }
}