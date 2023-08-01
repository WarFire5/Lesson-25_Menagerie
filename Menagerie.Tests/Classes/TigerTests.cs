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
        /// <param name="oneMeal"></param>
        [TestCase(true, "Мясо", false)]
        [TestCase(false, "Трава", false)]
        public void EatingTests(bool expected, string food, bool oneMeal)
        {
            Tiger tiger = new Tiger("Симба", 15, 5);
            tiger.Eating(food, 5);
            if (tiger.CounterOfSatiety == 5)
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
        [TestCase(true, "Мясо")]
        [TestCase(false, "Трава")]
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
