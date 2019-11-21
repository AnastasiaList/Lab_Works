using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__4
{
    class Geometric_figure : Type
    {     
        public int Angle; // Создаём поля (переменные класса)
        public int Square; 
        public int Angle_Quantity // Задаём свойства класса
        {
            get
            {   return this.Angle;  }
            set
            {   this.Angle = value; }
        }
        public int Square_Figure
        {
            get
            {   return this.Square;     }
            set
            {   this.Square = value;    }
        }
        public virtual void GetInfo() // Создаём виртуальный метод для вывода данных
        {
            Console.WriteLine($"Тип фигуры: {Type_Of_Figure} \nКоличество углов: {Angle_Quantity} \nПлощадь фигуры: {Square_Figure} (м^2)");
            Console.WriteLine();
        }
        public override string Smile() // Одноименный метод
        {
            string symbol = "~(@^_^@)~";
            return symbol;
        }
    }
    abstract class Type // Абстрактный класс Type (Конструктор не вызывается для создания объекта!)
    {
        public string TypeOfFigure;
        public string Type_Of_Figure 
        {
            get
            {   return this.TypeOfFigure;     }
            set
            {   this.TypeOfFigure = value;    }
        }
        public abstract string Smile(); // Одноименный метод в абстрактном классе
    }
    class Circle : Geometric_figure
    {
        public int Radius;
        public double Length;
        public int Radius_Circle
        {
            get
            { return this.Radius; }
            set
            { this.Radius = value; }
        }
        public double Length_Circle
        {
            get
            { return this.Length; }
            set
            { this.Length = value; }
        }
        public override void GetInfo() // Переопределение метода GetInfo()
        {
            Console.WriteLine($"Радиус круга: {Radius_Circle} \nДлина окружности: {Length_Circle}");
            Console.WriteLine();
        }
    }
    sealed class Rectangle : Geometric_figure // Модификатор sealed (герметизированный класс)
    {
        public int Length;
        public string Width;
        public int Length_Rectangle
        {
            get
            { return this.Length; }
            set
            { this.Length = value; }
        }
        public string Width_Rectangle
        {
            get
            { return this.Width; }
            set
            { this.Width = value; }
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Длина прямоугольника: {Length_Rectangle} \nШирина прямоугольника: {Width_Rectangle}");
            Console.WriteLine();
        }
        public override string ToString() // Переопределение метода ToString()
        {
            return ("Type: " + base.ToString() + "; Length: " + Length_Rectangle + "; Width: " + Width_Rectangle);
        }
        public static Boolean // Переопределение метода Equals() [не тождество, а равентсво]
        ReferenceEquals(Object A, Object B)
        {
            return (A == B);
        }
        public override int GetHashCode() // Переопределение метода GetHashCode()
        {
            int hash_code = 270;
            hash_code = string.IsNullOrEmpty(Width_Rectangle) ? 0 : Width_Rectangle.GetHashCode();
            hash_code = (hash_code * 50);
            return hash_code;
        }
    }
    class Button:IControl
    {
        public string Smile() // Одноименный метод
        {
            string symbol = "(:3)";
            return symbol;
        }
    }
    interface IControl // Одноименный метод в интерфейсе
    {   string Smile();   }
    class Program
    {
        static void Main(string[] args)
        {
            Geometric_figure figure_1 = new Geometric_figure
            {
                Type_Of_Figure = "Многоугольник",
                Angle_Quantity = 12,
                Square_Figure = 345,
            };
            Console.WriteLine("Фигура №1");
            figure_1.GetInfo();
            Circle figure_2 = new Circle
            {
                Radius_Circle = 4,
                Length_Circle = 2 * 3.14 * 4,
            };
            Console.WriteLine("Фигура №2");
            figure_2.GetInfo();
            Rectangle figure_3 = new Rectangle
            {
                Length_Rectangle = 4,
                Width_Rectangle = "15",
            };
            Console.WriteLine("Фигура №3");
            figure_3.GetInfo();
            Console.WriteLine(figure_3.ToString());
            Console.WriteLine($"Фигура №1 и фигура №3 равны? -> {ReferenceEquals(figure_1, figure_3)}");
            Console.WriteLine($"Хэш-код: {figure_3.GetHashCode()}");
            Console.WriteLine(figure_1.Smile()); // Тест нашего одноименного метода
            Button button_1 = new Button{ };
            Console.WriteLine(button_1.Smile());
            if (figure_1 is Circle) // Проверка совместимости объекта с данным типом (is)
            {   Console.WriteLine("Да, первая фигура является кружочком!"); }
            else
            {   Console.WriteLine("Это точно не кружочек...");  }
            Rectangle figure_4 = figure_3 as Rectangle; // Выполнение преобразования типов (as)
            if (figure_4 == null)
            {   Console.WriteLine("Провальное преобразование. Грустно..."); }
            else
            {   Console.WriteLine("Миссия выполнена!"); }
            Console.ReadKey();
        }
    }
}