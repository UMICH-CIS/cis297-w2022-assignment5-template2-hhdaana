using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorGUIForm());
        }

        class Eqautions
        {
            public int num1;
            public int num2;
            public int num3;

            double y;
            double value1;
            double value2;
            Boolean stat = true;

            //constructor
            public Eqautions(int a, int b, int c)
            {
                this.num1 = a;
                this.num2 = b;
                this.num3 = c;
            }
            //default constructor
            public Eqautions()
            {

            }
            public int eq
            {
                get
                {
                    CalculatorGUIForm calculatorGUIForm = new CalculatorGUIForm();
                    return this.num1;
                }

                set
                {
                    this.num1 = value;
                }
            }

            public int eq1
            {
                get
                {
                    return this.num2;
                }

                set
                {
                    this.num2 = value;
                }
            }

            public int eq2
            {
                get
                {
                    return this.num3;
                }

                set
                {
                    this.num3 = value;
                }
            }


            public double calculate()
            {
                y = Math.Pow(num2, 2) - 4 * num1 * num3;
                return y;
            }

            public void final_sol()
            {
                if (y == 0)
                {
                    if (num1 == 0)
                    {

                        stat = false;

                    }
                    else
                    {
                        value1 = -num2 / (2 * num1);
                        value2 = value1;
                    }

                }
                else if (y > 0)
                {
                    if (num1 == 0)
                    {

                        stat = false;

                    }
                    else
                    {
                        value1 = (-num2 + Math.Sqrt(y)) / (2 * num1);
                        value2 = (-num2 - Math.Sqrt(y)) / (2 * num1);
                    }

                }
                else
                {
                    stat = false;
                }
            }
            //displays solution for the equation 
            public void show_sol()
            {
                //Console.WriteLine($"Quadratic Equation with  A: {0}   B: {1}  C: {2}", A, B, C);
                calculate();
                final_sol();
                if (stat)
                {
                    if (value1 == value2)
                    {
                        Console.WriteLine($"The equation has one root: {value1}");
                    }
                    else
                    {
                        Console.WriteLine($"Root X1 = {value1}");
                        Console.WriteLine($"Root X2 = {value2}");
                    }
                }
                else
                {
                    Console.WriteLine("Equation has no real roots!");
                }

            }
        }



        class Programs
        {
            static void MainMenu(string[] args)
            {
                bool showMenu = true;
                while (showMenu)
                {
                    showMenu = MainMenu();

                }


            }

            private static bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("----------- Calculator by Ali Seklawi --------------------");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Return a string without the Whitespaces");
                Console.WriteLine("2) Reverse a string");
                Console.WriteLine("3) Display the quotient and the remainder");
                Console.WriteLine("4) Find the logarithm of a specified number to base 10");
                Console.WriteLine("5) Find the logarithm of a specified number to a specified base");
                Console.WriteLine("6) Display the minimum and maximum of the two numbers");
                Console.WriteLine("7) Find the specified number to the specified power");
                Console.WriteLine("8) Find the roots of a quadratic equation");
                Console.WriteLine("9) Find the square root of the given number");
                Console.WriteLine("10) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1"://1.	Return a string without the Whitespaces
                        RemoveWhitespace();
                        return true;

                    case "2"://2.	Reverse a string
                        ReverseString();
                        return true;

                    case "3"://3.	Display the quotient and the remainder
                        Remainders();
                        return true;

                    case "4"://4.	Find the logarithm of a specified number to base 10
                        LogBase10();
                        return true;

                    case "5"://5.	Find the logarithm of a specified number to a specified base
                        LogBaseUn();
                        return true;

                    case "6"://6.	Display the minimum and maximum of the two numbers
                        MinMax();
                        return true;

                    case "7"://7.	Find the specified number to the specified power
                        SpPower();
                        return true;

                    case "8"://8.	Find the roots of a quadratic equation
                        Quadratic();
                        return true;

                    case "9": // Sqrt-Square Root. This function returns the square root of the given number.
                        SquareRoot();
                        return true;

                    case "10":
                        return false;

                    default:
                        return true;
                }
            }

            /// <summary>
            /// This method captures user input as a string
            /// </summary>
            //<returns>The <see cref="System.String"/returns>
            private static string CaptureInput()
            {
                Console.Write("Enter the string you want to modify: ");
                return Console.ReadLine();
            }

            /// <summary>
            /// 1.	Return a string without the Whitespaces
            /// </summary>

            private static void RemoveWhitespace()
            {
                Console.Clear();
                Console.WriteLine("Remove Whitespace");

                DisplayResult(CaptureInput().Replace(" ", ""));
            }

            /// <summary>
            /// Displays the result as a modified string
            /// </summary>
            /// <param name="message">The <see cref="System.String"/> message to display.</param>
            private static void DisplayResult(string message)
            {
                Console.WriteLine($"\r\nYour modified string is: {message}");
                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }

            /// <summary>
            /// 2.	Reverse a string
            /// </summary>
            private static void ReverseString()
            {
                Console.Clear();
                Console.WriteLine("Reverse String");

                char[] charArray = CaptureInput().ToCharArray();
                Array.Reverse(charArray);
                DisplayResult(String.Concat(charArray));
            }

            /// <summary>
            /// 3. This function will give the remainder of a user input number.
            /// </summary>
            private static void Remainders()
            {
                Console.Clear();
                Console.WriteLine("Display the quotient and the remainder");

                Console.Write("Enter the Divident number: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the divisor number: ");
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine("{0} devided by {1} is {2} of remainder {2} ", number1, number2, Math.DivRem(number1, number2, out int result), (number1 % number2));

                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();


            }

            /// <summary>
            /// 4. This function will give the log of a base 10.
            /// </summary>
            private static void LogBase10()
            {
                Console.Clear();
                Console.WriteLine("Find the logarithm of a specified number to base 10");
                Console.Write("Enter the number: ");
                double number = double.Parse(Console.ReadLine());

                Console.WriteLine("The log({0}) to the base of {1} is {2}.", number, 10, Math.Log10(number));

                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }

            /// <summary>
            /// 5. This function will give the log of a base that the user chooses.
            /// </summary>
            private static void LogBaseUn()
            {
                Console.Clear();
                Console.WriteLine("Find the logarithm of a specified number to a specified base");
                Console.Write("Enter the number: ");
                double number = double.Parse(Console.ReadLine());

                Console.Write("Enter the base: ");
                double base1 = double.Parse(Console.ReadLine());

                Console.WriteLine("The log({0}) to the base of {1} is {2}.", number, base1, Math.Log(number, base1));

                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }

            /// <summary>
            /// 6. This function will give the minimum and maximum of the two numbers.
            /// </summary>
            private static void MinMax()
            {
                Console.Clear();
                Console.WriteLine("Display the minimum and maximum of the two numbers");

                Console.Write("Enter the first number: ");
                double number1 = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double number2 = double.Parse(Console.ReadLine());

                Console.WriteLine("The Minimum of {0} and {1} is {2}.", number1, number2, Math.Min(number1, number2));
                Console.WriteLine("The Maximum of {0} and {1} is {2}.", number1, number2, Math.Max(number1, number2));

                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }

            /// <summary>
            /// 7. This funtion will calculate a specified number to the specified power.
            /// </summary>
            private static void SpPower()
            {
                Console.Clear();
                Console.WriteLine("Find the specified number to the specified power");

                Console.Write("Enter the number: ");
                double number = double.Parse(Console.ReadLine());

                Console.Write("Enter the power: ");
                double power = double.Parse(Console.ReadLine());

                Console.WriteLine("{0} to the power of {1} is {2}.", number, power, Math.Pow(number, power));

                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }

            /// <summary>
            /// 8. This function will find the roots of a quadratic equation.
            /// </summary>
            private static void Quadratic()
            {
                Console.Clear();
                Console.WriteLine("Find the square root of the given number");

                Eqautions quadratic = new Eqautions();

                Console.Write("Enter the coefficent number of A: ");
                quadratic.num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the coefficent number of B: ");
                quadratic.num2 = int.Parse(Console.ReadLine());

                Console.Write("Enter the coefficent number of C: ");
                quadratic.num3 = int.Parse(Console.ReadLine());

                quadratic.show_sol();

                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();

            }


            /// <summary>
            /// 9. Sqrt-Square Root. This function returns the square root of the given number.
            /// </summary>

            private static void SquareRoot()
            {
                Console.Clear();
                Console.WriteLine("Find the square root of the given number");
                Console.Write("Enter the number: ");
                double number7 = double.Parse(Console.ReadLine());

                Console.WriteLine("Square root of {0} is {1}.", number7, Math.Sqrt(number7));

                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }

        }
    }

}
