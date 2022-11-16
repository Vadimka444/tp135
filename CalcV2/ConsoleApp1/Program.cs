using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; 

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.Write("введите первое число: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Это недопустимый ввод. Пожалуйста, введите целое значение: ");
                    numInput1 = Console.ReadLine();
                }

                Console.Write("введите второе число: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Это недопустимый ввод. Пожалуйста, введите целое значение: ");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine("выберите оператор:");
                Console.WriteLine("\t+ - сложение");
                Console.WriteLine("\t- - вычитание");
                Console.WriteLine("\t* - умножение");
                Console.WriteLine("\t/ - деление");
                
                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("ошибка \n");
                    }
                    else Console.WriteLine("результат: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("возникло исключение.\n - Details: " + e.Message);
                }

                Console.Write("введите n и нажмите Enter для завершения. Чтобы продолжить нажмите Enter: ");
                if (Console.ReadLine() == "n") endApp = true;
            }
            return;
        }
    }
}