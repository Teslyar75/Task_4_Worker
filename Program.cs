/*Завдання 4
Створити абстрактний базовий клас Worker (працівник)
з методом Print(). Створіть чотири похідні класи: President,
Security, Manager, Engineer. Перевизначте метод.
Print() для виведення інформації, яка відповідає кожному типу працівника.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Worker
{
    abstract class Worker
    {
        public abstract void Print();
    }

    class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Президент компании. Руководство всей компанией");
        }
    }

    class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Охранник. Безопастность");
        }
    }

    class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Менеджер. Управление проектами и командой");
        }
    }

    class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Инженер. Разработка новых продуктов компании.");
        }
    }

    class Program
    {
        static void Main()
        {
            Worker president = new President();
            Worker security = new Security();
            Worker manager = new Manager();
            Worker engineer = new Engineer();

            Console.WriteLine("Информация о работниках:");

            Console.WriteLine("\nПрезидент:");
            president.Print();

            Console.WriteLine("\nОхранник:");
            security.Print();

            Console.WriteLine("\nМенеджер:");
            manager.Print();

            Console.WriteLine("\nИнженер:");
            engineer.Print();
            Console.ReadKey();
        }
    }

}
