namespace Menagerie.Classes
{
    public class Elephant : AbstractAnimal
    {
        public Elephant(string name, int volumeFeedPerDay, int age)
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
        public override bool Eating(string food, int portionOfFeed)
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
                else
                {
                    Satiety = false;
                    Console.WriteLine($"{Name} не наелась");
                }
            }
            else
            {
                Satiety = false;
                Console.WriteLine($"{Name} не стала есть");
            }
            return Satiety;
        }
    }
}
