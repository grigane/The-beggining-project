using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework module 3? not finished
            //Console.Write("Input the first integer: ");
            //string numberA = Console.ReadLine();
            //Console.Write("Input the second integer: ");
            //string numberB = Console.ReadLine();
            //int result1 = 0;

            //if (int.TryParse(numberA, out result1))
            //{
            //    if (int.TryParse(numberA, out int result2))
            //    {
            //        string equal = (result1 == result2) ? $"{result1} is equal to {result2}" :
            //            (result1 > result2) ? $"{result1} is greater than {result2}" :
            //            $"{result2} is greater than {result1}";

            //        Console.WriteLine(equal);
            //    }
            //    else
            //    {
            //        Console.WriteLine("It is not walid input");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("It is not walid input");
            //}

            //Console.ReadLine();
            #endregion

            #region Nikitas example

            //Console.Write("enter first integer: ");
            //string number = Console.ReadLine();

            //Console.Write("enter second integer: ");
            //string number1 = Console.ReadLine();
            //int result1 = 0;

            //if (int.TryParse(number, out result1))
            //{
            //    if (int.TryParse(number, out int result2))
            //    {
            //        string equal = (result1 == result2) ? $"{result1} is equal to {result2}" :
            //            (result1 > result2) ? $"{result1} is greater than {result2}" :
            //            $"{result2} is greater than {result1}";

            //        Console.WriteLine(equal);
            //    }
            //    else
            //    {
            //        Console.WriteLine("It is not valid input");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("It is not valid input");
            //}

            //Console.ReadLine();
            #endregion

            #region Homework module 4 months

            //Console.Write("Write number of any month: ");
            //string numberMo = Console.ReadLine();


            ////string result = numberTrue == 1 ? "Month has 31 days" : "Np comments on others";




            ////Console.Write(result);
            ////Console.Write("The month has 31 days");


            //Console.ReadLine();
            #endregion

            #region Class work with Functions

            //string name = "John";
            //string fromFunction = OutputName(name);


            //Console.WriteLine(fromFunction);
            //Console.ReadLine();


            //static string OutputName(string name)
            //{
            //    return $"Welcome friend {name}! Have a nice day.";
            //}

            //int result12 = ResultOfNumbers();
            //int result13 = ResultOfDivision();
            //int resultOfFunctions = result12 + result13;

            //Console.WriteLine("Result of two numbers is: " + result12);
            //Console.WriteLine("Result of two numbers is: " + result13);
            //Console.WriteLine("Result of two numbers is: " + resultOfFunctions);

            //Console.ReadLine();

            //static int ResultOfNumbers()
            //{
            //    var number1 = 11;
            //    var number2 = 9;
            //    return number1 * number2;

            //}

            //static int ResultOfDivision()
            //{
            //    int number1 = 11;
            //    int number2 = 9;
            //    return number1 / number2;
            #endregion

            #region calculate circle or square area
            
            string inputRadius = IntroCircle();
            string inputSide = IntroSquare();

            Console.WriteLine("__________________Task 1_______________");
            Console.WriteLine(inputRadius);
            double numberR = Convert.ToDouble(Console.ReadLine());
            var resultCircle = cicleArea(numberR);
                            
            Console.WriteLine("Area of the circle with radius {0} is {1}", numberR,resultCircle);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("__________________Task 2_______________");
            Console.WriteLine(inputSide);
            double numberS = Convert.ToDouble(Console.ReadLine());
            var resultSquare = SquareArea(numberS);
            Console.WriteLine("Area of the square with side {0} is {1}", numberS, resultSquare);

            Console.WriteLine("Press any key to exit the app...");
            Console.ReadKey();

            static string IntroCircle()
            {
                return $"Enter the radius of a circle:";
            }

            static double cicleArea(double numberR)
            {
                double area;
                area = Math.PI * numberR * numberR;
                return (area);
            }
            static string IntroSquare()
            {
                return $"Enter one side length of a square:";
            }
            static double SquareArea (double numberS)
            {
                double square;
                square = numberS * numberS;
                return (square);
            }

            #endregion
        }

    }
}