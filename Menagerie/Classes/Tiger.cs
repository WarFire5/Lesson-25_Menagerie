namespace Menagerie.Classes
{
    internal class Tiger : AbstractAnimal
    {
        public Tiger(string name, double volumeFeedPerDay, int age)
        {
            Type = "Тигр";
            Biome = "Тропики";
            Square = 10;
            Feed = "Мясо";
            IsPredator = true;
            Sound = "Рррр";
            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
        }
        public override void Eating(string food, double portionOfFeed)
        {
            if (food == "Мясо")
            {
                Console.WriteLine($"{Name} покушал");
                CounterOfSatiety += portionOfFeed;
                if (CounterOfSatiety == 15)
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
