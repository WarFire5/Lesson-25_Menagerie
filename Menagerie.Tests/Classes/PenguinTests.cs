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
        [TestCase(1, "Рыба")]
        [TestCase(0, "Хлеб")]
        public void EatingTests(int expected, string food)
        {
            Penguin penguin = new Penguin("Петя", 3, 5);
            penguin.Eating(food, 1);
            int actual = penguin.CounterOfSatiety;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase(true, "Рыба")]
        [TestCase(false, "Хлеб")]
        [TestCase(false, "Хлеб и Рыба")]
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
