using System;

namespace Calс
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont;

            do
            {
                double num1 = 0; double num2 = 0;

            // Отображение зоголовка
            Console.WriteLine("Консольный калькулятор\r");
            Console.WriteLine("                       \n");


                // Ввод первого числа
                Console.WriteLine("Введите первое число и нажмите Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

                // Ввод второго числа
                Console.WriteLine("                       \n");
                Console.WriteLine("Введите второе число и нажмите Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

                // Выбор операции над числами
                Console.WriteLine("                       \n");
                Console.WriteLine("Выберите операцию, которую хотите произвести:");
            Console.WriteLine("\t1 - Сложение");
            Console.WriteLine("\t2 - Вычитание");
            Console.WriteLine("\t3 - Умножение");
            Console.WriteLine("\t4 - Деление");
            Console.Write("Твой выбор? ");

                //  Использование оператора switch для выполнения математических расчетов
                switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Результат: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine($"Результат: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine($"Результат: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "4":
                    Console.WriteLine($"Результат: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

                Console.WriteLine("                       \n");
                Console.WriteLine("Совершить еще одну операцию? (Если да, то напишите 'yes' и нажмите Enter)");
                Console.WriteLine("                       \n");
                cont = Convert.ToString(Console.ReadLine());

        } while(cont == "yes");
        }
    }
}
