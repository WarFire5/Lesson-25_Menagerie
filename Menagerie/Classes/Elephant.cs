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
        public override bool EatingPortionOfFeed(string food, int portionOfFeed)
        {
            if (food == "Сено" & portionOfFeed == 5)
            {
                Console.WriteLine($"{Name} покушала");
                Ate += portionOfFeed;
                SatietyCheck();
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} не стала есть");
            }
            return false;
        }
        public bool SatietyCheck()
        {
            if (Ate == 15)
            {
                Satiety = true;
                Console.WriteLine($"{Name} сыта");
            }
            else
            {
                Satiety = false;
                Console.WriteLine($"{Name} не наелась");
            }
            return Satiety;
        }

        ////2-й вариант разбивки метода на два
        //public override bool EatingPortionOfFeed(string food, int portionOfFeed)
        //{
        //    if (food == "Сено" & portionOfFeed == 5)
        //    {
        //        Console.WriteLine($"{Name} покушала");
        //        Ate += portionOfFeed;
        //        if (Ate == 15)
        //        {
        //            Satiety = true;
        //            Console.WriteLine($"{Name} сыта");
        //        }
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{Name} не стала есть");
        //    }
        //    return false;
        //}
        //public bool SatietyCheck()
        //{
        //    return Satiety;
        //}
    }
}
