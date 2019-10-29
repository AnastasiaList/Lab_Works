using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise__2
{
    class Airline // Создаём класс Airline
    {
        private string PointOfDestination; // Создаём поля (переменные класса)
        private string NumberRice;
        private string TypeOfPlane;
        private string TimeTo;
        private string DaysOfWeek;
        public string Point_Of_Destination // Задаём свойства класса
        {
            get
            {
                return this.PointOfDestination;
            }
            set
            {
                this.PointOfDestination = value;
            }
        }
        public string Number_Rice
        {
            get
            {
                return this.NumberRice;
            }
            set
            {
                this.NumberRice = value;
            }
        }
        public string Type_Of_Plane
        {
            get
            {
                return this.TypeOfPlane;
            }
            set
            {
                this.TypeOfPlane = value;
            }
        }
        public string Time_To
        {
            get
            {
                return this.TimeTo;
            }
            set
            {
                this.TimeTo = value;
            }
        }
        public string Days_Of_Week
        {
            get
            {
                return this.DaysOfWeek;
            }
            set
            {
                this.DaysOfWeek = value;
            }
        }
        public void GetInfo() // Создаём метод для вывода данных
        {
            Console.WriteLine($"Пункт отправления и назначения: {Point_Of_Destination} \nНомер рейса: {Number_Rice} \nТип самолёта: {Type_Of_Plane}");
            Console.Write($"Время отправления: {Time_To} \nДни полётов: {Days_Of_Week} \n");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Airline person_1 = new Airline // Создаём новые экземпляры класса + Используем конструктор по умолчанию
            {
                Point_Of_Destination = "Минск-Москва",
                Number_Rice = "А152",
                Type_Of_Plane = "Туполев ТУ-134",
                Time_To = "17.34",
                Days_Of_Week = "Четверг",
            };
            Airline person_2 = new Airline
            {
                Point_Of_Destination = "Москва-Сингапур",
                Number_Rice = "К5698",
                Type_Of_Plane = "Ильюшин ИЛ-62",
                Time_To = "2.13",
                Days_Of_Week = "Пятница",
            };
            Airline person_3 = new Airline
            {
                Point_Of_Destination = "Сингапур-Австралия-Новая Зеландия",
                Number_Rice = "Ф54872",
                Type_Of_Plane = "Боинг-747",
                Time_To = "11.15",
                Days_Of_Week = "Вторник",
            };
            Console.WriteLine("План рейсов на неделю:\n"); // Вывод данных
            person_1.GetInfo(); person_2.GetInfo(); person_3.GetInfo();
            Console.Write("Введите название маршрута, который вас интересует: "); // Поиск рейсов по маршруту
            string Point = Console.ReadLine();
            Console.WriteLine($"Рейсы по маршруту {Point}:\n");
            if (Point == person_1.Point_Of_Destination)
            {
                person_1.GetInfo();
            }
            if (Point == person_2.Point_Of_Destination)
            {
                person_2.GetInfo();
            }
            if (Point == person_3.Point_Of_Destination)
            {
                person_3.GetInfo();
            }
            Console.Write("Введите день недели, на который вам нужен билет: "); // Поиск рейсов по дню недели
            string Day = Console.ReadLine();
            Console.WriteLine($"Рейсы в {Day}:\n");
            if (Day == person_1.Days_Of_Week)
            {
                person_1.GetInfo();
            }
            if (Day == person_2.Days_Of_Week)
            {
                person_2.GetInfo();
            }
            if (Day == person_3.Days_Of_Week)
            {
                person_3.GetInfo();
            }
            Console.ReadKey();
        }
    }
}
