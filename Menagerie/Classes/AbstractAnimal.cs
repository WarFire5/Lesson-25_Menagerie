namespace Menagerie.Classes
{
    public abstract class AbstractAnimal
    {
        public string Type { get; protected set; }
        public string Biome { get; protected set; }
        public int Square { get; set; }
        public string Feed { get; protected set; }
        public bool IsPredator { get; protected set; }
        public string Sound { get; protected set; }
        public string Name { get; set; }
        public int VolumeFeedPerDay { get; set; }
        public int Age { get; set; }
        public int Ate { get; protected set; }
        public bool Satiety { get; protected set; }

        public abstract bool EatingPortionOfFeed(string food, int portionOfFeed);
        public void MakeASound()
        {
            Console.WriteLine($"{Name} издал(а) звук {Sound}");
        }
        public void Playing()
        {
            Console.WriteLine($"{Name} поиграл(а)");
        }
    }
}
