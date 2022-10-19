using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CALC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     Калькулятор     ");
            Console.WriteLine(" - Умножение производится с помощью операции: *");
            Console.WriteLine(" - Деление производится с помощью операции: /");
            Console.WriteLine(" - Сложение производится с помощью операции: +");
            Console.WriteLine(" - Вычитание производится с помощью операции: -");
            Console.WriteLine();

            while (true) 
            {  
                Console.Write(" Введите выражение: "); 
                Console.WriteLine(RPN.Calculate(Console.ReadLine())); 
            }
        }
    }
    class RPN
    {
        static private bool Whitespace(char c)
        {
            if ((" ".IndexOf(c) != -1))
                return true;
            return false;
        }
        static private bool Operation(char с)
        {
            if (("+-/*()".IndexOf(с) != -1))
                return true;
            return false;
        }
        static private byte PriorityOfOperations(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                default: return 5;
            }
        }
        static public double Calculate(string input)
        {
            string output = ConvertPN(input); 
            double result = Calculation(output); 
            return result; 
        }
        static private string ConvertPN(string input)
        {
            string output = string.Empty; 
            Stack<char> operStack = new Stack<char>(); 

            for (int i = 0; i < input.Length; i++) 
            {
                if (Char.IsDigit(input[i])) 
                    {
                        while (!Whitespace(input[i]) && !Operation(input[i]))
                    {
                        output += input[i]; 
                        i++; 

                        if (i == input.Length) break; 
                    }

                    output += " ";
                    i--; 
                }

                 else if (Operation(input[i])) 
                {
                    switch (input[i])
                    {
                        case '(':
                            operStack.Push(input[i]);
                            break;
                        case ')':
                            {
                                char s = operStack.Pop();

                                while (s != '(')
                                {
                                    output += s.ToString() + ' ';
                                    s = operStack.Pop();
                                }
                                break;
                            }
                        default:
                            if (operStack.Count > 0 && PriorityOfOperations(input[i]) <= PriorityOfOperations(operStack.Peek()))
                            {   
                                output += operStack.Pop().ToString() + " ";
                                operStack.Push(char.Parse(input[i].ToString()));
                            }
                            break;
                    }
                 }
            }

            while (operStack.Count > 0)
                output += operStack.Pop() + " ";

            Console.WriteLine("Обратная польская нотация: " + output);
            Console.Write("Ответ: ");  return output; 
        }
        static private double Calculation(string input)
        {
            double result = 0; 
            Stack<double> temp = new Stack<double>(); 

            for (int i = 0; i < input.Length; i++) 
            {
                if (Char.IsDigit(input[i]))
                {
                    string a = string.Empty;

                    while (!Whitespace(input[i]) && !Operation(input[i])) 
                    {
                        a += input[i]; 
                        i++;
                        if (i == input.Length) break;
                    }
                    temp.Push(double.Parse(a)); 
                    i--;
                }
                else if (Operation(input[i])) 
                {
                    double a = temp.Pop();
                    double b = temp.Pop();

                    switch (input[i])
                    {
                        case '+': result = b + a;
                            break;
                        case '-': result = b - a;
                            break;
                        case '*': result = b * a;
                            break;
                        case '/': result = b / a;
                            break;
                    }
                    temp.Push(result);
                }
            }
            return temp.Peek(); 
        }
    }
}