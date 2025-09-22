using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begineer_Course
{
    internal class Debugging
    {
        public void debug()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            int sum = 0;
            for (int i = 0; i <= numbers.Length; i++) 
            {
                sum += numbers[i];
            }

            double average = sum / numbers.Length;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);
        }
    }
}
