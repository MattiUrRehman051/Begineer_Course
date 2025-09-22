using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begineer_Course
{
    internal class Array_Exercise
    {
        public void questionTwo()
        {
            Console.WriteLine("Enter Name: ");
            String name = Console.ReadLine();
            String reversed = " ";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reversed += name[i];

            }
            Console.WriteLine(reversed);
        }

        public void questionThree()
        {
            int num;
            String result;
            int[] arr = new int[5];
            int[] sortedArr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter " + i + " number=");
                num = Convert.ToInt32(Console.ReadLine());


                bool exists = false;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == num)
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists)
                {
                    Console.WriteLine("Try again");
                    i--;
                }
                else
                {
                    arr[i] = num;
                }

            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            result = string.Join(",", arr);
            Console.WriteLine(result);





        }
    }
}