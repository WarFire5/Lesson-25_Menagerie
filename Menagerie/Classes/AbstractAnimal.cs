namespace Menagerie.Classes
{
    abstract class AbstractAnimal
    {
        public string Type { get; protected set; }
        public string Biome { get; protected set; }
        public int Square { get; set; }
        public string Feed { get; protected set; }
        public bool IsPredator { get; protected set; }
        public string Sound { get; protected set; }
        public string Name { get; set; }
        public double VolumeFeedPerDay { get; set; }
        public int Age { get; set; }
        public double CounterOfSatiety { get; protected set; }
        public bool Satiety { get; protected set; }

        public abstract void Eating(string food, double portionOfFeed);
        public void MakeASound()
        {
            Console.WriteLine($"{Name} издала звук {Sound}");
        }
        public void Playing()
        {
            Console.WriteLine($"{Name} поиграла");
        }
    }
}
