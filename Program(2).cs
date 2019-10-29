using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Array MyArray_1 = new Array();// Создание двух новых объектов
            Array MyArray_2 = new Array();
            MyArray_1 = MyArray_1 * (-1);   MyArray_1 = MyArray_1 * (2);    MyArray_1 = MyArray_1 * (-3); // Наполнение массива новыми элементами
            MyArray_2 = MyArray_2 * (4);    MyArray_2 = MyArray_2 * (-5);   MyArray_2 = MyArray_2 * (6);
            Console.Write("Элементы массива №1:\t"); // Вывод элементов массива
            for (int i = 0; i < MyArray_1.Count; i++)
                Console.Write($"{MyArray_1[i]}\t");
            Console.WriteLine();
            Console.Write("Элементы массива №2:\t");
            for (int i = 0; i < MyArray_2.Count; i++)
                Console.Write($"{MyArray_2[i]}\t");
            Console.WriteLine();
            string str_1 = "Чашка зелёного чая стояла на столике возле камина..."; // Удаление гласных из строки
            Console.WriteLine($"\nНаша исходная строка: {str_1}");
            Console.WriteLine($"Наша строка без гласных: {str_1.Symbol_Find()} \n");
            string str_2 = "Лоза-Орхидея"; // Удаление первых пяти элементов
            Console.WriteLine($"Наша исходная строка: {str_2}");
            Console.WriteLine($"Наша строка без пяти первых элементов: {str_2.Delete_Five()} \n");
            int number = -1;
            Console.WriteLine($"Верно ли, что число {number} принадлежит массиву №1?"); // Проверка на вхождение элемента в данный массив
            bool flag_1 = (MyArray_1 > number);
            Console.WriteLine($"\nСоединим массив №1 и массив №2."); // Объединение двух массивов
            int h = (MyArray_1 + MyArray_2); Console.WriteLine("\n");
            int w = 7; // Разность со скалярным значением
            Console.WriteLine($"Отнимим от элементов массива №2 число {w}.");
            int v = (MyArray_2 - w);
            Console.Read();
        }
    }
    static class Operation
    {
        public static string Symbol_Find(this string Str)  // Метод удаления гласных из строки
        {
            string[] Str_0 = {"а", "е", "ё", "и", "о", "у", "ы", "э", "ю", "я", "А", "Е", "Ё", "И", "О", "У", "Ы", "Э", "Ю", "Я" };
            foreach (var c in Str_0)
            {
                Str = Str.Replace(c, string.Empty);
            }
            return Str;
        }
        public static string Delete_Five(this string Str)  // Метод удаления первых пяти элементов
        {
            string New_String = Str.Remove(0, 5);
            return New_String;
        }
    }
    class Array
    {
        private List<int> storage; // Инициализация коллекции int элементов
        public Owner owner;
        public Date date;
        public class Owner
        {
            public int id;
            public string name;
            public string organisation;
            public Owner(int id, string name, string organisation) // Конструктор-инициализатор
            {
                this.id = id;
                this.name = name;
                this.organisation = organisation;
            }
        }
        public class Date
        {
            DateTime Date_Time = DateTime.Now;
            public override String ToString()
            { return Date_Time.ToShortDateString(); }
        }
        public Array()
        {
            this.storage = new List<int>();
            this.owner = new Owner(754231, "Anastasia", "BSTU");
            this.date = new Date();
        }
        public List<int> Storage
        {
            get
            { return this.storage; }
        }
        public int Count // Подсчёт элементов в массиве
        {
            get
            { return this.storage.Count; }
        }        
        public int Push(int element) // Добавление в массив элемента
        {
            this.storage.Add(element);
            return element;
        }
        public bool Remove(Predicate<int> match)
        { return this.storage.Remove(this.storage.Find(match)); }
        public int this[int index] // Индексатор
        {
            get
            { return this.storage[index]; }
            set
            { this.storage[index] = value; }
        }
        public static Array operator *(Array stack, int element) // Добавление элемента в массив
        {
            stack.Push(element);
            return stack;
        }
        public static bool operator >(Array a, int b) // Проверка на вхождение элемента
        {
            int n = 0; bool flag = true;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == b)
                {
                    Console.WriteLine("Да, данное число принадлежит нашему массиву.");
                    n++;
                    break;
                }
            }
            if (n == 0)
            {
                Console.WriteLine("Нет, данное число не принадлежит нашему массиву."); flag = false;
            }
            return flag;
        }
        public static bool operator <(Array a, int b)
        {
            int n = 0; bool flag = true;
            for (int j = 0; j < a.Count; j++)
            {
                if (a[j] != b) { break; }
                else
                {
                    Console.WriteLine("Да, данное число принадлежит нашему массиву.");
                    n++;
                    break; 
                }
            }
            if (n == 0)
            {
                Console.WriteLine("Нет, данное число не принадлежит нашему массиву."); flag = false;
            }
            return flag;
        }
        public static int operator +(Array a, Array b) // Объединение двух массивов
        {
            var c = new int[a.Count + b.Count];
            int k = 0;
            for (int i = 0; i < a.Count; i++)
            {
                c[k] = a[i];
                k++;
            }
            for (int i = 0; i < b.Count; i++)
            {
                c[k] = b[i];
                k++;
            }
            Console.Write("Наш новый массив:\t");
            for (int i = 0; i < (a.Count + b.Count); i++)
            {
                Console.Write($"{c[i]}\t");
            }
            return k;
        }
        public static int operator -(Array a, int b) // Разность со скалярным значением
        {
            int k = 0;
            for (int i = 0; i < a.Count; i++)
            {
                a[i] = a[i] - b;
            }
            Console.Write("Получаем такой массив:\t");
            for (int i = 0; i < a.Count; i++)
            {
                Console.Write($"{a[i]}\t");
            }
            return k;
        }
    }
}
