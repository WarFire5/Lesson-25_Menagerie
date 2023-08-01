using Menagerie.Classes;

namespace Menagerie.Tests.Classes
{
    public class PenguinTests
    {
        /// <summary>
        /// Проверка одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        /// <param name="oneMeal"></param>
        [TestCase(true, "Рыба", false)]
        [TestCase(false, "Хлеб", false)]
        public void EatingTests(bool expected, string food, bool oneMeal)
        {
            Penguin penguin = new Penguin("Петя", 3, 5);
            penguin.Eating(food, 1);
            if (penguin.CounterOfSatiety == 1)
            {
                oneMeal = true;
            }
            bool actual = oneMeal;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase(true, "Рыба")]
        [TestCase(false, "Хлеб")]
        public void EatingTests(bool expected, string food)
        {
            Penguin penguin = new Penguin("Петя", 3, 5);
            penguin.Eating(food, 1);
            penguin.Eating(food, 1);
            penguin.Eating(food, 1);
            bool actual = penguin.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
