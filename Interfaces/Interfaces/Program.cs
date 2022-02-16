namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark[] sharks = new Shark[]
            {
                new Shark("Timbu", 50),
                new Shark("Jar", 65)
            };

            IFish[] fishes = new IFish[]
            {
                new Siren(100),
                new Shark("Tib", 50)
            };

            ShowFish(sharks);
            ShowAnimals(sharks);
            ShowFish(fishes);
        }
        public static void ShowAnimals(IAnimal[] animals)
        {
            Console.WriteLine("-Animals");
            int i = 0;
            while (i < animals.Length)
            {
                Console.WriteLine(animals[i].Name);
                i++;
            }
        }

        public static void ShowFish(IFish[] fishes)
        {
            Console.WriteLine("-Fishes");
            int i = 0;
            while (i < fishes.Length)
            {
                Console.WriteLine(fishes[i].Swim());
                i++;
            }
        }
    }

    public class Siren: IFish
    {
        public int Speed { get; set; }

        public Siren(int Speed)
        {
            this.Speed = Speed;
        }

        public string Swim()
        {
            return $"Siren swims at {Speed} km/h";
        }
    }


    public class Shark: IAnimal, IFish
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Shark(string Name, int Speed)
        {
            this.Name = Name;
            this.Speed = Speed; 
        }
        public string Swim()
        {
            return $"{Name} swim at {Speed} km/h";
        }
    }

    public interface IAnimal
    {
        public string Name { get; set; }
    }

    public interface IFish
    {
        public int Speed { get; set; }
        public string Swim();
    }
}