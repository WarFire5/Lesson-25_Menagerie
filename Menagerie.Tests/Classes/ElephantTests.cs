using Menagerie.Classes;

namespace Menagerie.Tests.Classes
{
    public class ElephantTests
    {
        /// <summary>
        /// Проверка факта одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Сено", 5, true)]
        [TestCase("Торт", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Elephant elephant = new Elephant("Матильда", 15, 20);
            bool actual = elephant.EatingPortionOfFeed(food, portionOfFeed);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Сено", true)]
        [TestCase("Торт", false)]
        [TestCase("Сено и Торт", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            Elephant elephant = new Elephant("Матильда", 15, 20);
            elephant.EatingPortionOfFeed(food, 5);
            elephant.EatingPortionOfFeed(food, 5);
            elephant.EatingPortionOfFeed(food, 5);
            bool actual = elephant.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
