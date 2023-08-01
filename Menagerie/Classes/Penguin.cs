namespace Menagerie.Classes
{
    public class Penguin : AbstractAnimal
    {
        public Penguin(string name, int volumeFeedPerDay, int age)
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
        public override void Eating(string food, int portionOfFeed)
        {
            if (food == "Рыба" & portionOfFeed == 1)
            {
                Console.WriteLine($"{Name} покушал");
                CounterOfSatiety += portionOfFeed;
                if (CounterOfSatiety == 3)
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
