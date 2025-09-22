using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Begineer_Course
{
    internal class While_loop
    {
        public void questionOne()
        {
            Console.WriteLine("Question 1:-");
            int i1 = 1;
            int count1 = 0;
            while (i1 <= 100)
            {
                if (i1 % 3 == 0)
                {
                    count1++;

                }
                i1++;
            }
            Console.WriteLine(count1);
        }

        public void questionTwo()
        {
            String str = " ";
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Enter Number");
                str = Console.ReadLine();

                if (str == "ok")
                {
                    break;
                }

                int num = Convert.ToInt32(str);

                sum = sum + num;
            }
            Console.WriteLine(sum);
        }

        public void questionThree()
        {
            int num;
            int fact = 1;
            Console.WriteLine("Enter Number For Factorial");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = num; i >= 1; i--)
            {
                fact = fact * i;

            }
            Console.WriteLine(fact);
        }

        public void questionFour()
        {
            Random rand = new Random();
            int secret = rand.Next(0, 11);
            int num = 0;
            Console.WriteLine("Enter Numbers between 1-10");

            for(int i = 0; i < 4; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if(num == secret)
                {
                    Console.WriteLine("You Won");
                }
            }

            if(num != secret)
            {
                Console.WriteLine("You Loss");
            }
        }
        public void questionFive()
        {
            int[] arr = { 5, 3, 8, 8, 5, 5 ,5, 1, 4 };
            int max = 0;
            int secondMax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > secondMax && arr[j] < max)
                {
                    secondMax = arr[j];
                }
            }
            Console.WriteLine("maximum=" + max);
            Console.WriteLine("second maximum=" + secondMax);

        }
    }
}