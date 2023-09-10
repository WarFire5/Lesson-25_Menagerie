namespace Menagerie.Classes
{
    public class Tiger : AbstractAnimal
    {
        public Tiger(string name, int volumeFeedPerDay, int age)
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
        public override bool Eating(string food, int portionOfFeed)
        {
            if (food == "Мясо" & portionOfFeed == 5)
            {
                Console.WriteLine($"{Name} покушал");
                CounterOfSatiety += portionOfFeed;
                if (CounterOfSatiety == 15)
                {
                    Satiety = true;
                    Console.WriteLine($"{Name} сыт");
                }
                else
                {
                    Satiety = false;
                    Console.WriteLine($"{Name} не наелся");
                }
            }
            else
            {
                Satiety = false;
                Console.WriteLine($"{Name} не стал есть");
            }
            return Satiety;
        }
    }
}
