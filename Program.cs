using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Литералы */
            Console.WriteLine("Блок №1"); // Строковый литерал
            {   Console.WriteLine("Блок №2");   }
            string name = "Toren";
            Console.WriteLine($"А меня зовут {name}!");
            Console.ReadKey();
            Console.WriteLine(true); // Логические литералы
            Console.WriteLine(false);
            Console.WriteLine(-13); // Целочисленные литералы
            Console.WriteLine(13.13); // Вещественные литералы
            Console.WriteLine(3.2e3);
            Console.WriteLine('*'); // Символьные литералы

            /* Типы данных */
            bool Alive = true;
            bool IsDead = false;
            Console.WriteLine(Alive);
            Console.WriteLine(IsDead);
            byte bit_1 = 231; // Целые числа от 0 до 255 (1 байт)
            Console.WriteLine(bit_1);
            sbyte bit_2 = -128; // Целые числа от -128 до 127 (1 байт)
            Console.WriteLine(bit_2);
            short number_1 = 32506; // Целые числа от -32768 до 32767 (2 байта)
            Console.WriteLine(number_1);
            ushort number_2 = 65535; // Целые числа от 0 до 65535 (2 байта)
            Console.WriteLine(number_2);
            int number_3 = -2147483648; // Целые числа от -2147483648 до 2147483647 (4 байта)
            Console.WriteLine(number_3);
            uint number_4 = 4294967295u; // Целые  числа от 0 до 4294967295 (4 байта) [Суффикс U/u]
            Console.WriteLine(number_4);
            long number_5 = -15486246l; // Целые числа от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 (8 байт) [Суффикс L/l]
            Console.WriteLine(number_5);
            ulong number_6 = 214254824757ul; // Целые числа от 0 до 18 446 744 073 709 551 615 (8 байт) [Суффикс UL/ul]
            Console.WriteLine(number_6);
            float number_7 = 1.12f; // Числа с плавующей точкой от -3.4*1038 до 3.4*1038 (4 байта) [Суффикс F/f]
            Console.WriteLine(number_7);
            double number_8 = 456.1235; // Числа с плавующей точкой от ±5.0*10-324 до ±1.7*10308 (8 байт)
            Console.WriteLine(number_8);
            decimal number_9 = -0.4587m; // Десятичное дробное число от ±1.0*10-28 до ±7.9228*1028 (16 байт) [Суффикс M/m]
            Console.WriteLine(number_9);
            char star_char = '*'; // Символы (2 байта)
            Console.WriteLine(star_char);
            object symbol = "154bn"; // Может содержать любой тип даннных
            Console.WriteLine(symbol);
            var n1 = 12.4; // Неявная типизация
            var n2 = 13;
            var n3 = '*';
            var n4 = "Good Day";
            var n5 = "Good People";
            Console.WriteLine(n1.GetType().ToString());
            Console.WriteLine(n2.GetType().ToString());
            Console.WriteLine(n3.GetType().ToString());
            Console.WriteLine(n4.GetType().ToString());
            Console.WriteLine(n5.GetType().ToString());
            int number = 10; // Упаковку и распоковку (boxing/unboxing)
            object obj;
            obj = number; // Упаковка (boxing)
            int number_0 = (int)obj; // Распаковка (unboxing)
            Console.WriteLine(number_0);
            Nullable<int> number_10 = 5; // Использование Nullable
            if (number_10.HasValue)
                Console.WriteLine(number_10.Value);
            else
                Console.WriteLine("Переменная number_10 не содержит значение.");

            /* Массивы */
            string[] str = new string[] { "Белка", "Енот", "Крот", "Фагот" }; // Создание одномерного массива
            int l = str.Length;
            Console.WriteLine($"Длина массива: {l}"); // Длина массива
            for (int z = 0; z < str.Length; z++) // Перебор элементов массива
            {
                Console.Write($"{z}-ый элемент массива: ");
                Console.WriteLine(str[z]);
            }
            Console.Write("Введите номер элемента массива, который хотите изменить: "); // Изменение элемента массива
            int num = Convert.ToInt32(Console.ReadLine());
            for (int q = 0; q < str.Length; q++)
            {
                if (q == num)
                {
                    Console.Write("Введите содержимое нового элемента: ");
                    string str_20 = Console.ReadLine();
                    str[q] = str_20;
                }
            }
            for (int e = 0; e < str.Length; e++)
            {
                Console.Write($"{e}-ый элемент массива: ");
                Console.WriteLine(str[e]);
            }
            int[,] dblmas = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // Двумерный массив
            int rows = dblmas.GetUpperBound(0) + 1; // Количество строк в двумерном массиве
            int columns = dblmas.Length / rows; // Количество элементов в строке 
            Console.WriteLine("Двумерный массив: ");
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {

                    Console.Write($"{dblmas[r, c]} \t");
                }
                Console.WriteLine();
            }
            float[][] stmass = new float[3][]; // Зубчатый массив
            stmass[0] = new float[2];
            stmass[1] = new float[3];
            stmass[2] = new float[4];
            for (int f = 0; f < stmass.Length; f++)
            {
                for (int p = 0; p < stmass[f].Length; p++)
                {
                    Console.Write("Новый элемент массива: ");
                    float elem = Convert.ToSingle(Console.ReadLine());
                    stmass[f][p] = elem;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Зубчатый массив: ");
            for (int m = 0; m < stmass.Length; m++)
            {
                for (int n = 0; n < stmass[m].Length; n++)
                {
                    Console.Write($"{stmass[n][m]} \t");
                }
                Console.WriteLine();
            }
            var str_1 = "Яркие лучи солнца озарили стеклянные звёзды..."; // Неявная типизация
            var mass_2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(str_1.GetType().ToString());
            Console.WriteLine(mass_2.GetType().ToString());

            /* Кортежи */
            Tuple<int, string, char, string, ulong> tpl = new Tuple<int, string, char, string, ulong>(1, "Милый", '*', "Щенок", 548612ul);
            Console.WriteLine($"item1 = {tpl.Item1}, item2 = {tpl.Item2}, item3 = {tpl.Item3}, item4 = {tpl.Item4}, item5 = {tpl.Item5}");
            var k = tpl.Item1; // Распаковка кортежа
            Console.WriteLine($"item[i] = {k}");
            var i = tpl.Item3;
            Console.WriteLine($"item[i] = {i}");
            var j = tpl.Item4;
            Console.WriteLine($"item[i] = {j}");
            var tpl_1 = Tuple.Create(9, 9); // Сравнение кортежей
            var tpl_2 = Tuple.Create(3, 9);
            if ((((IComparable)tpl_1).CompareTo(tpl_2) == 0))
                Console.WriteLine("Кортежи равны!");
            if ((((IComparable)tpl_1).CompareTo(tpl_2) == 1))
                Console.WriteLine("Первый кортеж больше второго!");
            else
                Console.WriteLine("Кортежи не равны!");

            /* Строки*/
            string str_5 = "В поисках истины...";
            string str_6 = "Ты погрузился в реальность?";
            string str_7 = "Или в иллюзию?";
            if (str_5.Length == str_6.Length) // Сравнение строк
                Console.WriteLine("Наши строки равны!");
            else
                Console.WriteLine("Разошлись пути наших строк...");
            string[] values = new string[] { str_5, str_6, str_7 }; // Сцепление строк
            String str_8 = String.Join(" ", values);
            Console.WriteLine(str_8);
            var str_9 = "Повтори историю."; // Копирование строк
            var str_10 = str_9.Substring(0, str_9.IndexOf(".") + 1);
            Console.WriteLine(str_9);
            Console.WriteLine(str_10);
            Console.WriteLine(str_5.Substring(10)); // Выделение подстроки
            string[] words = str_6.Split(new char[] { ' ' }); // Разделение строки на слова
            foreach (string iterator in words)
            {
                Console.WriteLine(iterator);
            }
            string str_11 = "Я с сабой честен."; // Вставка подстроки в заданную позицию
            string str_12 = " не";
            str_11 = str_11.Insert(9, str_12);
            Console.WriteLine(str_11);
            Console.WriteLine(str_5.Remove(9)); // Удаление заданной подстроки
            string str_13 = "Уютный дом."; // Работа с пустыми и null строками
            string null_str = null;
            string empty_str = String.Empty;
            string str_14 = str_13 + null_str;
            Console.WriteLine(str_14);
            bool symbol_13 = (empty_str == null_str);
            Console.WriteLine(symbol_13);
            string str_15 = empty_str + null_str;
            Console.WriteLine(empty_str.Length);
            Console.WriteLine(str_15.Length);

            /* Работа с локальной функцией */
            int t_1 = 1; 
            string t_2 = "Крепасть, где нет эмоций...";
            char t_3 = '*';
            ulong t_4 = 54851ul;
            float t_5 = -547.12f;
            var tuple_13 = Tuple.Create<int, string, char, ulong, float>(t_1, t_2, t_3, t_4, t_5);
            var tuple_14 = Tuple.Create<int, string, char, ulong, float>(t_1, t_2, t_3, t_4, t_5);
            string last = (string)tuple_13.Item2;
            if (tuple_13 == tuple_14)
            {
                Console.WriteLine("Кортежи равны!");
            }
            int[] Brown = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Минимальный элемент массива|Максимальный элемент массива|Сумма элементов массива|Первая буква строки ->");
            Console.WriteLine(func(t_2, Brown));
        }
        static Tuple<int, int, int, char> func(string a, int[] b)
        {
            int min = 10, max = 0, sum = 0;
            char h;
            foreach (int key in b)
            {
                if (key > max) { max = key; }
                if (key < min) { min = key; }
                sum += key;
            }
            h = a[0];
            var tuples = Tuple.Create<int, int, int, char>(min, max, sum, h);
            return tuples;
        }
    }
}
