
namespace modul_6_Наследлвание
{
    /*Задание 1
    Запрограммируйте класс Money (объект класса оперирует одной валютой) для работы с деньгами.
    В классе должны быть предусмотрены поле для хранения целой части денег 
    (доллары, евро, гривны и т.д.) и поле для хранения копеек (центы, евроценты, копейки и т.д.).
    Реализовать методы для вывода суммы на экран, задания значений для частей.
    На базе класса Money создать класс Product для работы с продуктом или товаром. 
    Реализовать метод, позволяющий уменьшить цену на заданное число.
    Для каждого из классов реализовать необходимые методы и поля.*/
    public class Money
    {
        public int Dollars { get; set; } // Целая часть денег
        public int Cents { get; set; } // 

        public Money(int dollars, int cents) // Конструктор
        {
            Dollars = dollars;
            Cents = cents;
        }

        public void Print() // Вывод суммы на экран
        {
            Console.WriteLine("{0}.{1}", Dollars, Cents);
        }

        public void SetMoney(int dollars, int cents) // Задание значений для частей
        {
            Dollars = dollars;
            Cents = cents;
        }
    }

    class Product:Money
    {
        public string Name { get; set; }
        public Product(string name, int dollars, int cents):base (dollars, cents) 
        {
            Name = name;
        }
        public void SetPrice(int dollars, int cents) // задать цену продукта
        {
            SetMoney(dollars, cents);
        }
        public void DecreasePrice(int dollars, int cents) // уменьшить цену на заданное число
        {
            int newDollars = Dollars - dollars;
            int newCents = Cents - cents;

            if (newCents < 0)
            {
                newDollars--;    // занимаем один доллар из целой части
                newCents += 100; // добавляем 100 центов
            }
            SetPrice(newDollars, newCents);            
        }
        public void PrintPrice() // вывести цену на экран
        {
            Console.Write("Цена продукта: " + Name + " - ");
            Print();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Игрушка", 10, 99);
            product.PrintPrice();
            int d = 2, c = 30;
            Console.WriteLine("Уменьшаем цену на ${0},{1}", d, c);
            product.DecreasePrice(d, c);
            product.PrintPrice();
        }
    }
}
