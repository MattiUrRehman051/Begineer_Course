using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begineer_Course
{
    internal class Conditional_Loops
    {
        public void questionOne()
        {
            Console.WriteLine("If Else");

            Console.WriteLine();

            Console.WriteLine("Enter Any Number");
            int numm = Convert.ToInt32(Console.ReadLine());

            if (numm >= 0 && numm <= 10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.WriteLine();
        }

        public void questionTwo()
        {
            Console.WriteLine("Question : - 2");
            Console.WriteLine("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("maximum = " + num1);
            }
            else
            {
                Console.WriteLine("maximum = " + num2);
            }

            Console.WriteLine();
        }

        public void questionThree()
        {
            Console.WriteLine("Question 3");
            Console.WriteLine("Enter Width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Image Is Landscape");
            }
            if (height > width)
            {
                Console.WriteLine("Image Is Portrate");
            }
            Console.WriteLine();
        }

        public void questionFour()
        {
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter Speed Limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Speed of Car: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demerit_points = (carSpeed - speedLimit) / 5;
                switch (demerit_points)
                {
                    case 1:
                        Console.WriteLine("1 demerit point incured");
                        break;

                    case 2:
                        Console.WriteLine("2 demerit point incured");
                        break;

                    case 3:
                        Console.WriteLine("3 demerit point incured");
                        break;

                    case 4:
                        Console.WriteLine("4 demerit point incured");
                        break;

                    case 5:
                        Console.WriteLine("5 demerit point incured");
                        break;

                    case 6:
                        Console.WriteLine("6 demerit point incured");
                        break;

                    case 7:
                        Console.WriteLine("7 demerit point incured");
                        break;

                    case 8:
                        Console.WriteLine("8 demerit point incured");
                        break;

                    case 9:
                        Console.WriteLine("9 demerit point incured");
                        break;

                    case 10:
                        Console.WriteLine("10 demerit point incured");
                        break;

                    case 11:
                        Console.WriteLine("11 demerit point incured");
                        break;

                    case 12:
                        Console.WriteLine("12 demerit point incure");
                        break;

                    default:
                        Console.WriteLine("Lisence Suspended");
                        break;


                }
            }

        }
    }
}
