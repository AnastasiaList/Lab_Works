using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__5
{
    class Geometric_figure : Type
    {
        public int Angle;
        public int Square;
        public int Angle_Quantity
        {
            get
            { return this.Angle; }
            set
            { this.Angle = value; }
        }
        public int Square_Figure
        {
            get
            { return this.Square; }
            set
            { this.Square = value; }
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Тип фигуры: {Type_Of_Figure} \nКоличество углов: {Angle_Quantity} \nПлощадь фигуры: {Square_Figure} (м^2)");
            Console.WriteLine();
        }
        public override string Smile()
        {
            string symbol = "~(@^_^@)~";
            return symbol;
        }
    }
    abstract class Type
    {
        public string TypeOfFigure;
        public string Type_Of_Figure
        {
            get
            { return this.TypeOfFigure; }
            set
            { this.TypeOfFigure = value; }
        }
        public abstract string Smile();
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
        public override void GetInfo()
        {
            Console.WriteLine($"Радиус круга: {Radius_Circle} \nДлина окружности: {Length_Circle}");
            Console.WriteLine();
        }
    }
    sealed class Rectangle : Geometric_figure
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
        public override string ToString()
        {
            return ("Type: " + base.ToString() + "; Length: " + Length_Rectangle + "; Width: " + Width_Rectangle);
        }
        public static Boolean
        ReferenceEquals(Object A, Object B)
        {
            return (A == B);
        }
        public override int GetHashCode()
        {
            int hash_code = 270;
            hash_code = string.IsNullOrEmpty(Width_Rectangle) ? 0 : Width_Rectangle.GetHashCode();
            hash_code = (hash_code * 50);
            return hash_code;
        }
    }
    class Button : IControl
    {
        public string Smile()
        {
            string symbol = "(:3)";
            return symbol;
        }
    }
    interface IControl
    { string Smile(); }

    /* Начало лабораторной работы №6 */
    enum Glass // Перечисление
    {
        Blue_Glass = 1,
        Violet_Glass,
        Green_Glass,
        Yellow_Glass,
        Red_Glass,
    };
    struct Tea // Структура
    {
        public int Green;
        public int Black;
        public int White;
        public int Green_Tea
        {
            get
            { return this.Green; }
            set
            { this.Green = value; }
        }
        public int Black_Tea
        {
            get
            { return this.Black; }
            set
            { this.Black = value; }
        }
        public int White_Tea
        {
            get
            { return this.White; }
            set
            { this.White = value; }
        }
        public void Created_Tea()
        {
            Console.WriteLine($"Состав личности (чайное соотношение)\nЗелёный чай: {Green_Tea}%\nЧёрный чай: {Black_Tea}%\nБелый чай: {White_Tea}%\n");
        }
    }
    public partial class Socks_With_Bears // Частичный класс
    {
        public void Find()
        {
            Console.WriteLine("В поисках второго носка с мишками...");
        }
    }
    class UI:Geometric_figure // Класс-контейнер
    {
        public List<object> massiv;
        public void Massiv() // Метод создания коллекции
        {
            this.massiv = new List<object>();
            this.massiv.Add(Type_Of_Figure);
            this.massiv.Add(Angle_Quantity);
            this.massiv.Add(Square_Figure);
            Console.WriteLine("Параметры нашей фигуры:");
            for(int i = 0; i < this.massiv.Count; i++)
            {
                if(i==0)
                    Console.WriteLine("Тип: " + this.massiv[i]);
                if(i==1)
                    Console.WriteLine("Количество углов: " + this.massiv[i]);
                if(i==2)
                    Console.WriteLine("Площадь: " + this.massiv[i] + "\n");
            }
        }
        public void Read_Massiv(List<UI> A) // Метод вывода коллекции
        {
            int m = 0;
            Console.WriteLine("Сколько у нас в коллекции объектов?");   Console.Write("Ответ: ");
            for (int k = 0; k < A.Count; k++)
            {   m++;   }
            Console.WriteLine(m + "\n"); 
        }
        public void Delete_Massiv(List<UI> A, int i) // Метод удаления одного элемента из коллекции
        {
            int q = 0;
            for (int j = 0; j < A.Count; j++)
            {
                if (j == i)
                    A.Remove(A[j]);
            }
            Console.WriteLine("Сколько у нас в коллекции объектов после операции удаления?");   Console.Write("Ответ: ");
            for (int k = 0; k < A.Count; k++)
            {   q++;   }
            Console.WriteLine(q + "\n");
        }
    }
    class Controller:UI // Класс-контроллер
    {
        public static int Squre_Number(List<UI> A) // Подсчёт общей площади фигур
        {
            int s = 0;
            for(int w = 0; w < A.Count; w++)
            {   s += A[w].Square_Figure;    }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №5");
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
            Console.WriteLine(figure_1.Smile());
            Button button_1 = new Button { };
            Console.WriteLine(button_1.Smile());
            if (figure_1 is Circle)
            { Console.WriteLine("Да, первая фигура является кружочком!"); }
            else
            { Console.WriteLine("Это точно не кружочек..."); }
            Rectangle figure_4 = figure_3 as Rectangle;
            if (figure_4 == null)
            { Console.WriteLine("Провальное преобразование. Грустно...\n"); }
            else
            { Console.WriteLine("Миссия выполнена!\n"); }

            /* Начало лабораторной работы №6 (тест работы написанного кода) */
            Console.WriteLine("Лабораторная работа №6");
            Glass bubble; // Перечисление
            bubble = Glass.Violet_Glass;
            Console.WriteLine(bubble);
            Console.WriteLine((int)bubble);
            Console.WriteLine();
            Tea person_1 = new Tea() // Структура
            {
                Green_Tea = 42,
                Black_Tea = 38,
                White_Tea = 20,
            };
            person_1.Created_Tea();
            Socks_With_Bears socks_1 = new Socks_With_Bears(); // Частичный класс
            Console.WriteLine("Сегодня одеваем носки с мишками. Найден один насок. Где же второй?");
            socks_1.Find();
            socks_1.Success();
            UI figure_5 = new UI() // Класс-контейнер
            {
                Type_Of_Figure = "Кружок",
                Angle_Quantity = 0,
                Square_Figure = 26,
            };
            figure_5.Massiv();
            UI figure_6 = new UI()
            {
                Type_Of_Figure = "Квадрат",
                Angle_Quantity = 4,
                Square_Figure = 25,
            };
            figure_6.Massiv();
            List<UI> Massiv_1 = new List<UI> {figure_5, figure_6};
            figure_5.Read_Massiv(Massiv_1);
            Console.WriteLine("Общая площадь всех фигур UI: " + Controller.Squre_Number(Massiv_1) + " м^2 \n");
            figure_5.Delete_Massiv(Massiv_1, 1);
            Console.WriteLine("Общая площадь всех фигур UI: " + Controller.Squre_Number(Massiv_1) + " м^2 \n");
            Console.ReadKey();
        }
    }
}