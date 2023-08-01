namespace Menagerie.Classes
{
    internal class Penguin : AbstractAnimal
    {
        public Penguin(string name, double volumeFeedPerDay, int age)
        {
            Type = "Пингвин";
            Biome = "Тундра";
            Square = 10;
            Feed = "Рыба";
            IsPredator = true;
            Sound = "Хрю";
            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
        }
        public override void Eating(string food, double portionOfFeed)
        {
            if (food == "Рыба")
            {
                Console.WriteLine($"{Name} покушал");
                CounterOfSatiety += portionOfFeed;
                if (CounterOfSatiety == 0.9)
                {
                    Satiety = true;
                    Console.WriteLine($"{Name} сыт");
                }
            }
            else
            {
                Console.WriteLine($"{Name} не стал есть");
            }
        }
    }
}
