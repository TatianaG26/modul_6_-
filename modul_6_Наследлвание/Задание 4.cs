using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_6_Наследлвание
{
    /*Задание 4
    Создать абстрактный базовый класс Worker (работника) с методом Print(). 
    Создайте четыре производных класса:
    President, Security, Manager, Engineer. 
    Переопределите метод Print() для вывода информации, соответствующей каждому типу работника.*/
    internal class Задание_4
    {
        abstract class Worker // абстрактный базовый класс Worker
        {
            // метод, который будет переопределяться в производных классах
            public abstract void Print();
        }
        // производный класс President
        class President : Worker
        {
            public override void Print()
            {
                Console.WriteLine("I am the President.\n");
            }
        }

        // производный класс Security
        class Security : Worker
        {
            public override void Print()
            {
                Console.WriteLine("I am a security guard.\n");
            }
        }

        // производный класс Manager
        class Manager : Worker
        {
            public override void Print()
            {
                Console.WriteLine("I am a manager.\n");
            }
        }

        // производный класс Engineer
        class Engineer : Worker
        {
            public override void Print()
            {
                Console.WriteLine("I am an engineer.\n");
            }
        }
        static void Main(string[] args)
        {
            Worker president = new President();
            president.Print(); 

            Worker security = new Security();
            security.Print();  

            Worker manager = new Manager();
            manager.Print();  

            Worker engineer = new Engineer();
            engineer.Print(); 
        }
    }
}
