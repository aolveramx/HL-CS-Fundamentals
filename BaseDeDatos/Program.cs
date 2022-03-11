using System.Data.SqlClient;

namespace BaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
#pragma warning disable CS8604 // Possible null reference argument.
                BeerDB beerDB = new BeerDB(
                    Environment.GetEnvironmentVariable("SERVER"), 
                    Environment.GetEnvironmentVariable("DATABASE"),
                    Environment.GetEnvironmentVariable("USER"),
                    Environment.GetEnvironmentVariable("PASS")
                    );
#pragma warning restore CS8604 // Possible null reference argument.

                bool again = true;
                int operation = 0;

                do
                {
                    ShowMenu();
                    Console.WriteLine("Elige una opción: ");
                    operation = int.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case 1:
                            Show(beerDB);
                            break;
                        case 2:
                            Add(beerDB);
                            break;
                        case 3:
                            Edit(beerDB);
                            break;
                        case 4:
                            Delete(beerDB);
                            break;
                        case 5:
                            again = false;
                            break;
                    }
                } while (again);

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void ShowMenu()
        {
            Console.WriteLine("\n----------Menu----------");
            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir");
        }

        public static void Show(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Cervezas de la base de datos");
            List<Beer> beers = beerDB.GetAll();

            foreach (var beer in beers)
            {
                Console.WriteLine($"ID: {beer.Id} Nombre: {beer.Name}");
            }
        }

        public static void Add(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Agregar nueva cerveza");
            Console.WriteLine("Escribe el nombre de la cerveza:");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de la marca:");
            int brandId = int.Parse(Console.ReadLine());
            Beer beer = new Beer(name, brandId);
            beerDB.Add(beer);
        }

        public static void Edit(BeerDB beerDB)
        {
            Console.Clear();
            Show(beerDB);
            Console.WriteLine("Editar Cerveza");
            Console.WriteLine("Escribe el id de tu cerveza a editar: ");
            int id = int.Parse(Console.ReadLine());

            Beer beer = beerDB.Get(id);
            if (beer != null)
            {
                Console.WriteLine("Escribe el nombre: ");
                string name = Console.ReadLine();
                Console.WriteLine("Escribe el id de la marca:");
                int brandId = int.Parse(Console.ReadLine());

                beer.Name = name;
                beer.BrandId = brandId;
                beerDB.Edit(beer);
            }
            else
            {
                Console.WriteLine("La cerveza no existe");
            }

        }

        public static void Delete(BeerDB beerDB)
        {
            Console.Clear();
            Show(beerDB);
            Console.WriteLine("Eliminar Cerveza");
            Console.WriteLine("Escribe el id de tu cerveza a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            Beer beer = beerDB.Get(id);
            if (beer != null)
            {
                beerDB.Delete(id);
            }
            else
            {
                Console.WriteLine("La cerveza no existe");
            }
        }
    }
}