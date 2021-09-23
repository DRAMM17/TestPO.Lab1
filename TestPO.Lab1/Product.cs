using System.ComponentModel.DataAnnotations;

// Написать программу, в которой описать классы по заданной тематике.
// Реализовать не менее 5 методов.
// - Каждый метод должен возвращать числовые значения. (не надо)
// Подготовить тестовые методы, проверяющие различные варианты и наборы данных.
// Провести тестирование используя подготовленные классы.

// !Побольше тестов, которые проходят и не проходят
// - Посмотреть про аннотации
// Загрузить на гитхаб и тогда его смогут проверить
// Больше методов

namespace TestPO.Lab1
{
    public class Product {
        string name; // Наименование
        int cost; // Цена
        int count; // Количество товара (шт)
        string manufacturer; // Производитель
        int shelfLife; // Срок годности
        string type; // Тип продукта
        string sort; // Сорт (при наличии)
        int spoiledPerWeek; // Испорчено за неделю
        int deliveryAcrossAmountDays; // Доставка через n дней
        int soldPerWeek; // Продано за неделю

        public Product(string name, int cost, int count, string manufacturer, int shelfLife, string type, string sort, int spoiledPerWeek, int deliveryAcrossAmountDays, int soldPerWeek) {
            this.name = name;
            this.cost = cost;
            this.count = count;
            this.manufacturer = manufacturer;
            this.shelfLife = shelfLife;
            this.type = type;
            this.sort = sort;
            this.spoiledPerWeek = spoiledPerWeek;
            this.deliveryAcrossAmountDays = deliveryAcrossAmountDays;
            this.soldPerWeek = soldPerWeek;
        }

        // Минимальное количество проданных товаров в день, до истечения срока годности за один привоз
        // 60
        // 5
        // 60/5 = 12
        public int minSellPerDayNotSpoiled(int count, int shelfLife) {
            return count / shelfLife;
        }

        // Упущенная выгода за неделю
        public int lostProfit(int cost, int countSpoiledProductsPerWeek) {
            return cost * countSpoiledProductsPerWeek;
        }

        // Прибыль за месяц
        // sold 10
        // 15p
        // 10*15=150
        // 7 - 150
        // 30 - x
        // 150*30/7=642
        public int profitPerWeek(int soldPerWeek, int cost) {
            return (soldPerWeek * cost * 30) / 7;
        }

        // Минимальное кол-во продажи товара в день до следующего привоза
        // 60 count
        // 3 days
        // 60 * 3 = 180
        // count / days = 60 / 3 = 20
        public int mixCountBeforeDelivery(int count, int deliveryAcrossAmountDays) {
            return count / deliveryAcrossAmountDays;
        }

        // Прибыль за день
        // 13
        // 9
        // 13 - 7
        // x - 1
        // 13*1/7
        public int profitPerDay(int soldPerWeek, int cost) {
        return (soldPerWeek / 7) * cost;
        }

        // Товар: Яблоки, Цена: 75р, 15 шт., Производитель: Яблоки России, срок годности: 7 дней,
        // Яблоки (фрукт)
        // Молоко (молочная продукция)
        public string getProduct() {
            return "Продукт: " + name + ", Цена: " + cost + ", Количество: " + count + " шт., " + "Производитель: " + manufacturer + ", Срок годности: " + shelfLife + ", Тип продукта: " + type + ", Доставка каждые " + deliveryAcrossAmountDays + " дней, Продано за неделю: " + soldPerWeek;
        }
    }
}
