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
        [TestCase(5, "Сено")]
        [TestCase(0, "Торт")]
        public void EatingTests(int expected, string food)
        {
            Elephant elephant = new Elephant("Матильда", 15, 20);                       
            elephant.Eating(food, 5);
            int actual = elephant.CounterOfSatiety;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase(true, "Сено")]
        [TestCase(false, "Торт")]
        [TestCase(false, "Сено и Торт")]
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
