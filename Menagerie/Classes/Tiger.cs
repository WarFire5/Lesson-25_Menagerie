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
        public override bool EatingPortionOfFeed(string food, int portionOfFeed)
        {
            if (food == "Мясо" & portionOfFeed == 5)
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
            if (Ate == 15)
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
        //    if (food == "Мясо" & portionOfFeed == 5)
        //    {
        //        Console.WriteLine($"{Name} покушал");
        //        Ate += portionOfFeed;
        //        if (Ate == 15)
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
