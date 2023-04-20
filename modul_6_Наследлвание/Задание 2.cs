using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_6_Наследлвание
{
    /*Задание 2
    Создать базовый класс «Устройство» и производные классы «Чайник», «Микроволновка», «Автомобиль», «Пароход». 
    С помощью конструктора установить имя каждого устройства и его характеристики.
    Реализуйте для каждого из классов методы:
    ■ Sound — издает звук устройства (пишем текстом в консоль);
    ■ Show — отображает название устройства;
    ■ Desc — отображает описание устройства.*/
    internal class Задание_2
    {
        public class Device //// Базовый класс "Устройство"
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public Device(string name, string description)
            {
                Name = name;
                Description = description;
            }
            public virtual void Sound()
            {
                Console.WriteLine("Звук устройства " + Name);
            }
            public void Show()
            {
                Console.WriteLine(Name);
            }
            public void Desc()
            {
                Console.WriteLine(Description);
            }
        }
        // Производные классы
        public class Kettle : Device
        {
            public Kettle(string name, string description) : base(name, description) { }

            public override void Sound()
            {
                Console.WriteLine("Кипит " + Name);
            }
        }
        public class Microwave : Device
        {
            public Microwave(string name, string description) : base(name, description) { }

            public override void Sound()
            {
                Console.WriteLine("Шумит " + Name);
            }
        }
        public class Car : Device
        {
            public Car(string name, string description) : base(name, description) { }

            public override void Sound()
            {
                Console.WriteLine("Сигналит " + Name);
            }
        }
        public class Ship : Device
        {
            public Ship(string name, string description) : base(name, description) { }

            public override void Sound()
            {
                Console.WriteLine("Гудит " + Name);
            }
        }
        static void Main(string[] args)
        {
            Kettle kettle = new Kettle("Bosch", "Электрический чайник");
            Microwave microwave = new Microwave("Samsung", "Микроволновая печь");
            Car car = new Car("Audi", "Автомобиль");
            Ship ship = new Ship("Queen Mary II", "Лайнер");
            
            kettle.Show();
            kettle.Sound();
            kettle.Desc();
            Console.WriteLine();
            microwave.Show();
            microwave.Sound();
            microwave.Desc();
            Console.WriteLine();
            car.Show();
            car.Sound();
            car.Desc();
            Console.WriteLine();
            ship.Show();
            ship.Sound();
            ship.Desc();
            
        }
    }
}
