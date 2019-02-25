using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {


            // Григорий Капусткин
            // задача 1
            // Написать метод, возвращающий минимальное из трёх чисел
            Console.WriteLine("Выбор наименьшего из трёх чисел. \nВведите первое число: ");
            var num_1 = GetNum();
            Console.WriteLine("Введите второе число: ");
            var num_2 = GetNum();
            Console.WriteLine("Введите третье число: ");
            var num_3 = GetNum();

            var min = MinOf3(num_1, num_2, num_3);

            Console.WriteLine("\n\nМеньшим из трёх введённых чисел является " + min);
            NextPart();

            // Григорий Капусткин
            // задача 2
            // Написать метод подсчета количества цифр числа.
            Console.WriteLine("Подсчёт количества цифр числа. \nВведите число: ");
            var num_task2 = Math.Abs(GetNum());
            int count_task2 = 0;

            //я могу выделить его как метод, но это же всего одна строка
            do { count_task2 = count_task2 + 1; num_task2 = num_task2 / 10; } while (num_task2 >= 1);

            Console.WriteLine("Количество цифр во введённом вами числе равно " + count_task2);
            NextPart();

            // Григорий Капусткин
            // задача 3
            // С клавиатуры вводятся числа, пока не будет введен 0. 
            // Подсчитать сумму всех нечетных положительных чисел.
            Console.WriteLine("Подсчитаем все введённые нечётные положительные числа. \n введите 0, чтобы прервать подсчёт");

            var sum_task3 = 0;
            var hold = 1;
            while (hold != 0)
            {
                Console.WriteLine("Введите число: ");
                var num_task3 = GetNum();
                if (num_task3 > 0 && num_task3 % 2 != 0)
                { sum_task3 = sum_task3 + num_task3; }
                if (num_task3 == 0) { hold = 0; }
            }

            Console.WriteLine("Результат равен " + sum_task3);
            NextPart();

            // Григорий Капусткин
            // задача 4
            // Реализовать метод проверки пароля. Ограничить тремя попытками через do while. 
            String Login_true = "root";
            String Pass_true = "GeekBrains";
            var attempts = 0;
            bool pass_control = false;

            do
            {
                Console.WriteLine("Введите логин: ");
                string Login = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                string Pass = Console.ReadLine();
                attempts++;
                if (Login == Login_true && Pass == Pass_true)
                { pass_control = true; break; }
                else
                if (attempts < 3)
                { Console.WriteLine("Неверно, попробуйте ещё раз."); }
            }
            while (attempts < 3);
            if (pass_control) { Console.WriteLine("Доступ разрешён, добро пожаловать."); }
            else { Console.WriteLine("Доступ запрещён!"); }
            NextPart();

            // Григорий Капусткин
            // задача 5
            // а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы 
            // и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            Console.WriteLine("Программа расчёта Индекса Массы Тела. \nПожалуйста, введите свой рост в сантиметрах: ");
            var height = GetNumD() / 100;
            Console.WriteLine("Пожалуйста, введите свой вес в килограммах: ");
            var mass = GetNumD();
            var indexMass = mass / (height * height);
            var indexMass_max = 24.99;
            var indexMass_min = 18.5;
            var IMT_switch = 0;
            double resultIMT = 0;
            double mass_opt = 0;
            if (indexMass > indexMass_max) { IMT_switch = 1; }
            else if (indexMass < indexMass_min) { IMT_switch = 2; }

            switch (IMT_switch)
            {
                case 1:
                    mass_opt = indexMass_max * (height * height);
                    resultIMT = Math.Abs(mass - mass_opt);
                    Console.WriteLine("\nВаш индекс массы тела равен {0:F2}, многовато.", indexMass);
                    Console.WriteLine("Вам стоит похудеть на {0:F2} килограмм", resultIMT);
                    break;
                case 2:
                    mass_opt = indexMass_min * (height * height);
                    resultIMT = Math.Abs(mass - mass_opt);
                    Console.WriteLine("\nВаш индекс массы тела равен {0:F2}, маловато.", indexMass);
                    Console.WriteLine("Вам стоит набрать ещё {0:F2} килограмм", resultIMT);
                    break;
                default:
                    Console.Write("\nВаш индекс массы тела равен {0:F2}, в пределах нормы.", indexMass);
                    break;
            }
            NextPart();

            // Григорий Капусткин
            // задача 6
            // *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            // «Хорошим» называется число, которое делится на сумму своих цифр. 
            // Реализовать подсчёт времени выполнения программы, используя структуру DateTime. 

            Console.WriteLine("Подождите, идёт подсчёт количества 'хороших' чисел в заданном диапазоне");
            Console.WriteLine(DateTime.Now);
            Console.SetCursorPosition(0, 4); Console.Write("Обрабатывается число: ");
            Console.SetCursorPosition(0, 5); Console.Write("Найдено: ");
            
            var GoodNum = 0;
            DateTime start = DateTime.Now;
            int range = 1_000_000_000;
            for (var counter_6 = 1; counter_6 <= range; counter_6++)
            {
                Console.SetCursorPosition(23, 4); Console.Write(counter_6);
                if (GoodNumCheck(counter_6)) { GoodNum++; Console.SetCursorPosition(10, 5); Console.Write(GoodNum); }
            }

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now - start);
            NextPart();
        } 


        private static int GetNum()
        {
            var a = Convert.ToInt32(Console.ReadLine());
            return a;
        }

        private static double GetNumD()
        {
            var a = Convert.ToDouble(Console.ReadLine());
            return a;
        }

        private static void NextPart()
            {
                Console.ReadKey();
                Console.WriteLine("Нажмите любую клавишу, чтобы продолжить:");
                Console.Clear();
            }

        private static int MinOf3(int num_1, int num_2, int num_3)
            {
                int min;
                if (num_1 < num_2 && num_1 < num_3) { min = num_1; }
                else if (num_2 < num_3) { min = num_2; }
                else { min = num_3; }

                return min;
            }

        private static bool GoodNumCheck(int counter_6)
        {
            var good = false;
            var holder = counter_6;
            var sum_6 = 0;
            var a = 0;
            do {
                a = counter_6 % 10;
                sum_6 = sum_6 + a;
                counter_6 = counter_6 / 10;
            } while (counter_6 >= 1);
            if (holder % sum_6 == 0) { good = true; }
            return good; 
        }

}
    }