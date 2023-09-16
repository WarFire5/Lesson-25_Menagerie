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
        public override bool EatingPortionOfFeed(string food, int portionOfFeed)
        {
            if (food == "Рыба" & portionOfFeed == 1)
            {
                Console.WriteLine($"{Name} покушал");
                Ate += portionOfFeed;
                SatietyCheck();
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} не стал есть");
            }
            return false;
        }
        public bool SatietyCheck()
        {
            if (Ate == 3)
            {
                Satiety = true;
                Console.WriteLine($"{Name} сыт");
            }
            else
            {
                Satiety = false;
                Console.WriteLine($"{Name} не наелся");
            }
            return Satiety;
        }

        ////2-й вариант разбивки метода на два
        //public override bool EatingPortionOfFeed(string food, int portionOfFeed)
        //{
        //    if (food == "Рыба" & portionOfFeed == 1)
        //    {
        //        Console.WriteLine($"{Name} покушал");
        //        Ate += portionOfFeed;
        //        if (Ate == 3)
        //        {
        //            Satiety = true;
        //            Console.WriteLine($"{Name} сыт");
        //        }
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{Name} не стал есть");
        //    }
        //    return false;
        //}
        //public bool SatietyCheck()
        //{
        //    return Satiety;
        //}
    }
}