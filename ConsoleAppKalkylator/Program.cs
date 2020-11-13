using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Operators = { "+", "-", "*", "/" }; // array of allawed operators
            string op1; // first operator
            string op2; // second operator
            double term1; // first term
            double term2; // second term
            double term3; // third term
            double result = 0; // the result of the calculation
            string temp; // placeholder in loop for checking terms are in right format


            // loops for operators:
            do
            {
                Console.WriteLine("Enter first operator: ");
                op1 = Console.ReadLine();
                if (!Array.Exists(Operators, element => element == op1))
                    Console.WriteLine("Invalid operator. Allowed operators: +, -, * and /");
            } while (!Array.Exists(Operators, element => element == op1));

            do
            {
                Console.WriteLine("Enter second operator: ");
                op2 = Console.ReadLine();
                if (!Array.Exists(Operators, element => element == op2))
                    Console.WriteLine("Invalid operator. Allowed operators: +, -, * and /");
            } while (!Array.Exists(Operators, element => element == op2));

            // loops for terms:
            do
            {
                Console.WriteLine("Enter first term: ");
                temp = Console.ReadLine();
                if (!double.TryParse(temp, out term1))
                    Console.WriteLine("Invalid format. Use format: 123,456,789");
            } while (!double.TryParse(temp, out term1));

            do
            {
                Console.WriteLine("Enter second term");
                temp = Console.ReadLine();
                if (!double.TryParse(temp, out term2))
                    Console.WriteLine("Invalid format. Use format: 123,456,789");
            } while (!double.TryParse(temp, out term2));

            do
            {
                Console.WriteLine("Enter third term");
                temp = Console.ReadLine();
                if (!double.TryParse(temp, out term3))
                    Console.WriteLine("Invalid format. Use format: 123,456,789");
            } while (!double.TryParse(temp, out term3));


            // Calculations:
            if (op1 == "+")
            {
                if (op2 == "+")
                    result = term1 + term2 + term3;
                else if (op2 == "-")
                    result = term1 + term2 - term3;
                else if (op2 == "*")
                    result = term1 + term2 * term3;
                else if (op2 == "/")
                    result = term1 + term2 / term3;
            }
            else if (op1 == "-")
            {
                if (op2 == "+")
                    result = term1 - term2 + term3;
                else if (op2 == "-")
                    result = term1 - term2 - term3;
                else if (op2 == "*")
                    result = term1 - term2 * term3;
                else if (op2 == "/")
                    result = term1 - term2 / term3;
            }
            else if (op1 == "*")
            {
                if (op2 == "+")
                    result = term1 * term2 + term3;
                else if (op2 == "-")
                    result = term1 * term2 - term3;
                else if (op2 == "*")
                    result = term1 * term2 * term3;
                else if (op2 == "/")
                    result = term1 * term2 / term3;
            }
            else if (op1 == "/")
            {
                if (op2 == "+")
                    result = term1 / term2 + term3;
                else if (op2 == "-")
                    result = term1 / term2 - term3;
                else if (op2 == "*")
                    result = term1 / term2 * term3;
                else if (op2 == "/")
                    result = term1 / term2 / term3;
            }
            // result:
            Console.WriteLine(term1 + " " + op1 + " " + term2 + " " + op2 + " " + term3 + " = " + result);


            Console.ReadLine();
        }
    }
}
