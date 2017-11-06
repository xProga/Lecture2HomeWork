using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2HomeWorkClasses
{
    /// <summary>
    /// 1. Написать метод возвращающий минимальное из трех чисел.
    /// </summary>
    public static class Task1
    {

        /// <summary>
        /// Метод предоставляющий пользователю интерфейс для ввода сравниваемых чисел
        /// </summary>
        /// <returns>Возвращает введенные пользователем числа</returns>
        public static List<int> InputValues()
        { 
            List<int> inputValues = new List<int>();

            Console.Write("Введите три числа для сравнения, через запятую: ");
            string[] rawInputValues = Console.ReadLine().Split(',', ' ').Where(x => x != "").ToArray();

            for (int i = 0; i < 3; i++ )
            {
                inputValues.Add(int.Parse(rawInputValues[i]));
            }

            return inputValues;
        }

        /// <summary>
        /// Метод сравнения трех введенных чисел
        /// </summary>
        /// <param name="inputValues">Список из трех введенных чисел</param>
        public static void CompareThreeValues(List<int> inputValues)
        {
            inputValues = inputValues.OrderBy(x => x).ToList();
            Console.WriteLine("Минимальное из трех введенных чисел: {0} ", inputValues.First());
            Console.ReadKey();
        }
           
    }
    /// <summary>
    /// 2. Написать метод подсчета количества цифр числа.
    /// </summary>
    public static class Task2
    {
        /// <summary>
        /// Метод предоставляющий пользователю интерфейс для подсчета количества значений в нем
        /// </summary>
        /// <returns>Возвращает введенныое пользователем значение</returns>
        public static int InputValue()
        { 
            int inputValue;
            Console.WriteLine("Введите число для подсчета количества знаков в нем: ");
            inputValue = int.Parse(Console.ReadLine());
            return inputValue;
        }

        /// <summary>
        /// Метод подсчета количества чисел в введенном числе
        /// </summary>
        /// <param name="inputValue">Число для подсчета количества значений в нем</param>
        public static void CountNumbersInValue(int inputValue)
        {
            int i = 0;
            while (inputValue != 0)
            {
                inputValue = inputValue / 10;
                i++;
            }

            Console.WriteLine("Количество чисел во введенном числе: {0}", i);
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    /// </summary>
    public static class Task3
    {
        /// <summary>
        /// Метод поределения и вывода всех нечетных положительных чисел.
        /// </summary>
        public static void InputValuesUntilNotZero()
        {
            int inputValue;
            int summ = 0;

            do
            {
                Console.Write("Введите число (для завершеения введите 0): ");
                inputValue = int.Parse(Console.ReadLine());
                if (inputValue % 2 != 0 && inputValue > 0)
                {
                    summ += inputValue;
                }
            }
            while (inputValue != 0);

            Console.WriteLine("Сумма всех введенных положительных нечетных чисел: {0}", summ);
            Console.ReadKey();
        }


    }

    /// <summary>
    /// 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин:root, Password:GeekBrains). 
    /// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
    /// С помощью цикла do while ограничить ввод пароля тремя попытками.
    /// </summary>
    public static class Task4
    {
        /// <summary>
        /// Метод проверки введенных данных пользователя на корректность.
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <param name="password">Пароль пользователя</param>
        /// <returns></returns>
        private static bool Validation(string login, string password)
        { 
            bool valid = false;

            if (login.Equals("root") && password.Equals("GeekBrains"))
            {
                valid = true;
            }

            return valid;
        }

        /// <summary>
        /// Метод предоставляющий интерфейс для ввода данных пользователя (логина и пароля)
        /// </summary>
        public static void LoginPasswordValidation()
        {
            int i = 0;
            bool result = false;

            do
            {
                Console.Write("Логин: ");
                string login = Console.ReadLine();
                Console.Write("Пароль: ");
                string password = Console.ReadLine();
                if (Task4.Validation(login, password) == false)
                {
                    Console.WriteLine("Введен неверный логин или пароль. У вас осталось {0} попытки(а).", 2 - i);
                }
                else
                {
                    result = true;
                    Console.WriteLine("Добро пожаловать в систему, root!");
                    break;
                }
                i++;
            } while (i < 3 || result != true);

            if (result == false) { Console.WriteLine("Доступ в систему заблокирован."); }
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
    ///    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    /// </summary>
    public static class Task5
    {
        /// <summary>
        /// Метод, предоставляющий интерфейс для ввода данных пользоваеля (рост и вес).
        /// </summary>
        /// <returns>Возвращает список ответов пользователя (рост, вес)</returns>
        public static List<double> Input()
        {
            List<double> answers = new List<double>();

            Console.WriteLine("Добрый день, пользователь. Данная программа рассчитывает ваш индекс массы тела на основе вашего роста и веса. Пожалуйста, введите исходные данные.");
            Console.Write("Рост, в метрах: ");
            answers.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Вес, кг: ");
            answers.Add(Convert.ToDouble(Console.ReadLine()));
            return answers;
        }

        /// <summary>
        /// Метод подсчета и определения недостающей/избыточной массы пользовалея на основе введенных данных.
        /// </summary>
        /// <param name="height">Рост пользователя</param>
        /// <param name="weight">Вес пользователя</param>
        public static void BMICalculation(double height, double weight)
        {
            double bmi = weight / Math.Pow(height, 2);
            double excessLackingWeight = 0;
            string outputMessage = "Уважаемый пользователь, ваш ИМТ, на текущий момент, " + bmi.ToString("f2") + ". ";
            if (bmi < 18.5)
            {
                excessLackingWeight = 18.5 * Math.Pow(height, 2);
                excessLackingWeight = excessLackingWeight - weight;
                outputMessage += "В вашем теле наблюдается ДЕФИЦИТ массы. Вам не хватает " + excessLackingWeight.ToString("f1") + " кг для достижения нормального ИМТ.";
            }
            else if (bmi > 30.0)
            {
                excessLackingWeight = 30.0 * Math.Pow(height, 2);
                excessLackingWeight = weight - excessLackingWeight;
                outputMessage += "В вашем теле наблюдается ИЗБЫТОК массы. Рекомендуется обратить внимание на рацион и работать над снижением веса. Для достижения нормального ИМТ рекомендуется сбросить " + excessLackingWeight.ToString("f1") + " кг.";
            }
            else
            {
                outputMessage += "Ваше тело находится в нормальном состоянии. Продолжайте в том же духе :)";
            }

            Console.WriteLine(outputMessage);
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 6. *Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000. 
    /// Хорошим называется число, которое делится на сумму своих цифр. 
    /// Реализовать подсчет времени выполнения программы, используя структуру DateTime.
    /// </summary>
    public static class Task6
    {
        /// <summary>
        /// Метод, предоаставляющий интерфейс для взаимодействия с программой определения Хороших чисел.
        /// </summary>
        public static void GoodValuesCount()
        {
            Console.WriteLine("Добрый день, пользователь. Данная программа призвана расчитать количество Хороших чисел в диапазоне от 1 до 1 000 000 000. Расчет пошел!");

            int goodValuesCount = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if (Task6.CountNumbersInValue(i) == true)
                {
                    goodValuesCount++;
                }
            }

            Console.WriteLine("Количество Хороших чисел: {0}", goodValuesCount);
            Console.ReadKey();
        }

        /// <summary>
        /// Метод реализующий определения чиел как Хороших.
        /// </summary>
        /// <param name="value">Значение для проверки на соответствие условию Хорошего числа.</param>
        /// <returns></returns>
        private static bool CountNumbersInValue(int value)
        {
            bool result = false;
            int summ = 0;
            int currentValue = value;

            do
            {
                summ += currentValue % 10;
                currentValue = currentValue / 10;
            }
            while (currentValue != 0);

            if (value % summ == 0) { result = true; }

            return result;
        }

    }

    /// <summary>
    /// 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
    ///    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
    /// </summary>
    public static class Task7
    {
        /// <summary>
        /// Метод, предоставляющий интерфейс для ввода данных стартового и конечного числа.
        /// </summary>
        public static void ValuesFromAToB()
        {
            Console.Write("Добрый день, уважаемый пользователь. Для осуществления работы с рекурсией, пожалуйста, введите 2 числа: ");
            string[] inputValues = Console.ReadLine().Split(',', ' ').Where(x => x != "").ToArray();
            int valueStart = int.Parse(inputValues[0]);
            int valueEnd = int.Parse(inputValues[1]);
            int summ = 0;

            if (valueStart < valueEnd)
            {
                Task7.RecursionAToB(valueStart, valueEnd, ref summ);
                Console.WriteLine("Сумма всех значений: {0}", summ);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Введены некорректные значения. Стартовое значение должно быть меньше конечного!");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Реализация рекурсионного метода подсчета суммы и вывода значений в диапазоне введенном пользователем.
        /// </summary>
        /// <param name="valueStart">Начальное значение диапазона</param>
        /// <param name="valueEnd">Конечное значение диапазона</param>
        /// <param name="summ">Сумма чисел диапазона</param>
        /// <returns></returns>
        private static int RecursionAToB(int valueStart, int valueEnd, ref int summ)
        {

            if (valueStart == valueEnd)
            {
                summ += valueEnd;
                Console.WriteLine(valueEnd);
            }
            else
            {
                Console.WriteLine(valueStart);
                Task7.RecursionAToB(valueStart + 1, valueEnd, ref summ);
                summ += valueStart;
            }

            return summ;
        }
    }
    
}