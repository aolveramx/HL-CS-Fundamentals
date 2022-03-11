using Entity;
using Microsoft.EntityFrameworkCore;

namespace Program
{
    public class EntityFrameworkSystem
    {
        static void Main(string[] args)
        {
            DbContextOptionsBuilder<CSDBContext> optionsBuilder = new DbContextOptionsBuilder<CSDBContext>();

            optionsBuilder.UseSqlServer("Server=SQL_ENGINE_DB_NAME; Database=DB_NAME; User=@DIR\\WIN_USER; Trusted_Connection=True");

            /* using (CSDBContext context = new CSDBContext(optionsBuilder.Options))
            {
                var beers = context.Beers.ToList();

                foreach (var beer in beers)
                {
                    Console.WriteLine(beer.Name);
                }
            }
            */

            bool again = true;
            int op = 0;

            do
            {
                ShowMenu();
                Console.WriteLine("Elige una opción: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Show(optionsBuilder);
                        break;
                    case 2:
                        Add(optionsBuilder);
                        break;
                    case 3:
                        Edit(optionsBuilder);
                        break;
                    case 4:
                        Delete(optionsBuilder);
                        break;
                    case 5:
                        again = false;
                        break;
                }
            } while (again);
        }

        public static void Show(DbContextOptionsBuilder<CSDBContext> optionBuilder)
        {
            Console.Clear();
            Console.WriteLine("Cervezas en la base de datos");

            using (var context = new CSDBContext(optionBuilder.Options))
            {
                List<Beer> beers = context.Beers.OrderBy(b => b.Name).ToList();
                // without OrderBy - lambda function
                List<Beer> beersTwo = (from b in context.Beers
                                       orderby b.Name
                                       select b).Include(b => b.Brand).ToList();

                foreach (Beer beer in beers)
                {
                    Console.WriteLine($"{beer.Id} - {beer.Name} - {beer.Brand.Name}");
                }
            }
        }

        public static void Add(DbContextOptionsBuilder<CSDBContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("Agregar nueva cerveza");
            Console.WriteLine("Escribe el nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de la marca");
            int brandId = int.Parse(Console.ReadLine());

            using (var context = new CSDBContext(optionsBuilder.Options))
            {
                Beer beer = new Beer()
                {
                    Name = name,
                    BrandId = brandId
                };
                context.Add(beer);
                context.SaveChanges();
            }

        }

        public static void Edit(DbContextOptionsBuilder<CSDBContext> optionsBuilder)
        {
            Console.Clear();
            Show(optionsBuilder);
            Console.WriteLine("Editar Cerveza");
            Console.WriteLine("Escribe el ID de la Cerveza a editar");
            int id = int.Parse(Console.ReadLine());

            using (var context = new CSDBContext(optionsBuilder.Options))
            {
                Beer beer = context.Beers.Find(id);

                if (beer != null)
                {
                    Console.WriteLine("Escribe el nombre: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Escribe el id de la marca");
                    int brandId = int.Parse(Console.ReadLine());
                    
                    beer.Name = name;
                    beer.BrandId = brandId;

                    context.Entry(beer).State = EntityState.Modified;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("La Cerveza no existe");
                }

            }

        }

        public static void Delete(DbContextOptionsBuilder<CSDBContext> optionsBuilder)
        {
            Console.Clear();
            Show(optionsBuilder);
            Console.WriteLine("Eliminar Cerveza");
            Console.WriteLine("Escribe el ID de la Cerveza a eliminar");
            int id = int.Parse(Console.ReadLine());

            using (var context = new CSDBContext(optionsBuilder.Options))
            {
                Beer beer = context.Beers.Find(id);

                if (beer != null)
                {
                    context.Beers.Remove(beer);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("La Cerveza no existe");
                }

            }

        }

        public static void ShowMenu()
        {
            Console.WriteLine("\n-------Menu--------");
            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir");
        }
    }
}