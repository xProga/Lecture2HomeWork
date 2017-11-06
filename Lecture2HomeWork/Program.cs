using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Lecture2HomeWorkClasses;

namespace Lecture2HomeWork
{
    class Program
    {
        public static void TaskN1()
        {
            Task1.CompareThreeValues(Task1.InputValues());
        }

        public static void TaskN2()
        {
            Task2.CountNumbersInValue(Task2.InputValue());
        }

        public static void TaskN3()
        {
            Task3.InputValuesUntilNotZero();
        }

        public static void TaskN4()
        {
            Task4.LoginPasswordValidation();
        }

        public static void TaskN5()
        {
            List<double> inputHeightWeight = Task5.Input();
            Task5.BMICalculation(inputHeightWeight[0], inputHeightWeight[1]);
        }

        public static void TaskN6()
        {
            Task6.GoodValuesCount();
        }

        public static void TaskN7()
        {
            Task7.ValuesFromAToB();
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo selectedTask;
            var rule = @"[1-7]";

            Console.WriteLine("Добрый день, уважаемый пользователь. Демонстрацию работы какой программы вы бы хотели увидеть?");
            Console.WriteLine("\t1. Программа возврата минимального из трех чисел.");
            Console.WriteLine("\t2. Программа подсчета количества цифр числа.");
            Console.WriteLine("\t3. Программа подсчета суммы всех нечетных положительных чисел введенных пользователем.");
            Console.WriteLine("\t4. Программа проверки правильности ввода логина и пароля.");
            Console.WriteLine("\t5. Программа расчета BMI человека и вывод количества кг, которые необходимо набрать/сбросить.");
            Console.WriteLine("\t6. Программа подсчета \"Хороших\" чисел в диапазоне от 1 до 1 000 000 000.");
            Console.WriteLine("\t7. Реализация рекурсивного метода вывода чисел и подсчета их суммы в диапазоне, указанном пользователем.");
            selectedTask = Console.ReadKey(true);
            if (Regex.IsMatch(selectedTask.KeyChar.ToString(), rule))
            {
                switch (selectedTask.KeyChar)
                {
                    case '1':
                        TaskN1();
                        break;
                    case '2':
                        TaskN2();
                        break;
                    case '3':
                        TaskN3();
                        break;
                    case '4':
                        TaskN4();
                        break;
                    case '5':
                        TaskN5();
                        break;
                    case '6':
                        TaskN6();
                        break;
                    case '7':
                        TaskN7();
                        break;
                }
            }
        }
    }
}
