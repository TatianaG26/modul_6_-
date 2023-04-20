using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_6_Наследлвание
{
    /*Задание 3
    Создать базовый класс «Музыкальный инструмент» и производные классы 
    «Скрипка», «Тромбон», «.Укулеле», «Виолончель». 
    С помощью конструктора установить имя каждого музыкального инструмента и его характеристики.
    Реализуйте для каждого из классов методы:
    ■ Sound — издает звук музыкального инструмента (пишем текстом в консоль);
    ■ Show — отображает название музыкального инструмента;
    ■ Desc — отображает описание музыкального инструмента;
    ■ History — отображает историю создания музыкального инструмента.*/
    internal class Задание_3
    {
        class MusicalInstrument // Базовый класс "Музыкальный инструмент"
        {
            public string Name { get; private set; }
            public string Characteristics { get; private set; }
            // Конструктор для установки имени и характеристик
            public MusicalInstrument(string name, string characteristics)
            {
                Name = name;
                Characteristics = characteristics;
            }
            // Методы для реализации в производных классах
            public virtual void Sound()
            {
                Console.WriteLine("Инструмент звучит!");
            }
            public virtual void Show()
            {
                Console.WriteLine("Музыкальный инструмент: " + Name);
            }
            public virtual void Desc()
            {
                Console.WriteLine("Характеристики инструмента: " + Characteristics);
            }
            public virtual void History()
            {
                Console.WriteLine("История создания инструмента");
            }
        }
        // Производный класс "Скрипка"
        class Violin : MusicalInstrument
        {
            // Конструктор для установки имени и характеристик скрипки
            public Violin(string name, string characteristics) : base(name, characteristics) { }
            public override void Sound()
            {
                Console.WriteLine("Скрипка издает красивый звук.");
            }
            public override void History()
            {
                Console.WriteLine("Скрипка была изобретена в XVI веке в Италии.");
            }
        }
        // Производный класс "Тромбон"
        class Trombone : MusicalInstrument
        {
            // Конструктор для установки имени и характеристик тромбона
            public Trombone(string name, string characteristics)
                : base(name, characteristics) { }
            public override void Sound()
            {
                Console.WriteLine("Тромбон издает глубокий звук.");
            }
            public override void Desc()
            {
                Console.WriteLine("Тромбон – духовой музыкальный инструмент, у которого есть трубчатая головка и скользящий затвор,\nпозволяющий изменять длину трубы и высоту звука.");
            }
            public override void History()
            {
                Console.WriteLine("Тромбон был изобретен в XV веке в Венеции для использования в красочных процессиях.");
            }
        }
        // Производный класс "Укулеле"
        class Ukulele : MusicalInstrument
        {
            // Конструктор для установки имени и характеристик укулеле
            public Ukulele(string name, string characteristics) : base(name, characteristics) { }
            public override void Sound()
            {
                Console.WriteLine("Укулеле создает звуки, которые напоминают звуки гитары.");
            }
            public override void Desc()
            {
                Console.WriteLine("Укулеле – маленький южно-тихоокеанский струнный музыкальный инструмент,\nкоторый стал популярным в Гавайях.");
            }
            public override void History()
            {
                Console.WriteLine("Первые укулеле были созданы в 1880 году на Гавайях.");
            }
        }
        // Производный класс "Виолончель"
        class Cello : MusicalInstrument
        {
            // Конструктор для установки имени и характеристик виолончели
            public Cello(string name, string characteristics) : base(name, characteristics) { }
            public override void Sound()
            {
                Console.WriteLine("Виолончель издает глубокий, теплый звук.");
            } public override void History()
            {
                Console.WriteLine("Виолончель была создана в XVI веке в Италии.");
            }
        }
        static void Main(string[] args)
        {
            // Создание музыкальных инструментов
            Violin violin = new Violin("Скрипка", "Четыре струны и смычок");
            Trombone trombone = new Trombone("Тромбон", "Большая труба с выступом и длинным скользящим затвором");
            Ukulele ukulele = new Ukulele("Укулеле", "Небольшой струнный инструмент с четырьмя струнами");
            Cello cello = new Cello("Виолончель", "Большой струнный инструмент, который держится между ног");
            // Вызов методов для каждого инструмента
            violin.Show();
            violin.Desc();
            violin.Sound();
            violin.History();
            Console.WriteLine();
            trombone.Show();
            trombone.Desc();
            trombone.Sound();
            trombone.History();
            Console.WriteLine();
            ukulele.Show();
            ukulele.Desc();
            ukulele.Sound();
            ukulele.History();
            Console.WriteLine();
            cello.Show();
            cello.Desc();
            cello.Sound();
            cello.History();
        }
    }
}
