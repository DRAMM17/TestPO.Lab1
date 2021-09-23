using System;
using NUnit.Framework;

// Написать программу, в которой описать классы по заданной тематике.
// Реализовать не менее 5 методов.
// - Каждый метод должен возвращать числовые значения. (не надо)
// Подготовить тестовые методы, проверяющие различные варианты и наборы данных.
// Провести тестирование используя подготовленные классы.

// !Побольше тестов, которые проходят и не проходят

namespace TestPO.Lab1
{
    [TestFixture]
    public class ProductTest
    {
        Product milk;
        Product apple;

        [SetUp]
        public void SetUp()
        {
            milk = new Product("Молоко", 49, 68, "Подворье", 7, "Молочная продукция", "Отсутствует", 5, 4, 44);
            apple = new Product("Яблоки", 75, 223, "Яблоки России", 7, "Фрукты", "Папировка", 0, 3, 0);
        }

        [Test]
        public void profitPerWeekTest() {
            Assert.AreEqual(9240, milk.profitPerWeek(44, 49)); // Равны ли значения
            Assert.IsInstanceOf<Product>(milk); // Сравнение объекта
        }

        //[Test]
        //public void getProductTest() {
        //    Assert.IsNotNull
        //}
    }
}
