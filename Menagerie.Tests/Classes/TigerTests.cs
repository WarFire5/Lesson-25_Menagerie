using Menagerie.Classes;

namespace Menagerie.Tests.Classes
{
    public class TigerTests
    {
        /// <summary>
        /// Проверка одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase(5, "Мясо")]
        [TestCase(0, "Трава")]
        public void EatingTests(int expected, string food)
        {
            Tiger tiger = new Tiger("Симба", 15, 5);
            tiger.Eating(food, 5);
            int actual = tiger.CounterOfSatiety;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase(true, "Мясо")]
        [TestCase(false, "Трава")]
        [TestCase(false, "Мясо и Трава")]
        public void EatingTests(bool expected, string food)
        {
            Tiger tiger = new Tiger("Симба", 15, 5);
            tiger.Eating(food, 5);
            tiger.Eating(food, 5);
            tiger.Eating(food, 5);
            bool actual = tiger.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
