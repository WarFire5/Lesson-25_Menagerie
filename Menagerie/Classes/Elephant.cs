namespace Menagerie.Classes
{
    internal class Elephant : AbstractAnimal
    {
        public Elephant(string name, double volumeFeedPerDay, int age)
        {
            Type = "Слон";
            Biome = "Пустыня";
            Square = 10;
            Feed = "Сено";
            IsPredator = false;
            Sound = "Ауф";
            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
        }
        public override void Eating(string food, double portionOfFeed)
        {
            if (food == "Сено" & portionOfFeed == 5)
            {
                Console.WriteLine($"{Name} покушала");
                CounterOfSatiety += portionOfFeed;
                if (CounterOfSatiety == 15)
                {
                    Satiety = true;
                    Console.WriteLine($"{Name} сыта");
                }
            }
            else
            {
                Console.WriteLine($"{Name} не стала есть");
            }
        }
    }
}
