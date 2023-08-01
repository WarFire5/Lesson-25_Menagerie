using Menagerie.Classes;

namespace Menagerie.Tests.Classes
{
    public class ElephantTests
    {
        /// <summary>
        /// Проверка одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        /// <param name="oneMeal"></param>
        [TestCase(true, "Сено", false)]
        [TestCase(false, "Торт", false)]
        public void EatingTests(bool expected, string food, bool oneMeal)
        {
            Elephant elephant = new Elephant("Матильда", 15, 20);
            elephant.Eating(food, 5);
            if (elephant.CounterOfSatiety == 5)
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
        [TestCase(true, "Сено")]
        [TestCase(false, "Торт")]
        public void EatingTests(bool expected, string food)
        {
            Elephant elephant = new Elephant("Матильда", 15, 20);
            elephant.Eating(food, 5);
            elephant.Eating(food, 5);
            elephant.Eating(food, 5);
            bool actual = elephant.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
