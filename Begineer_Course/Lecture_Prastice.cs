using Begineer_Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begineer_Course
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }
    internal class Lecture_Prastice
    {
        public void myMethod()
        {
            byte number = 2;
            int count = 10;
            double price = 30.567;
            float totalPrice = 20.5f;
            char character = 'A';
            String firstName = "Matti Ur Rehman";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(price);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // type Conversions (byte - int):-
            Console.WriteLine();
            byte sampleVar = 34;
            int num = sampleVar;
            Console.WriteLine("Data type conversion from byte to int " + num);

            // type Conversions (int - byte):-
            Console.WriteLine();
            int i = 22;
            byte j = (byte)i;
            Console.WriteLine("Data type conversion from int to byte " + j);

            // type Conversions (String - int):-
            Console.WriteLine();
            var numb = "1234";
            int k = Convert.ToInt32(numb);
            Console.WriteLine("Data type conversion from String to int " + k);

            // type Conversions (String - int):- handling by try catch
            Console.WriteLine();
            Console.WriteLine("Try - Catch");
            try
            {
                var str = "1234";
                byte l = Convert.ToByte(str);
                Console.WriteLine("Data type conversion from String to int " + l);
            }
            catch
            {
                Console.WriteLine("the number could not converted to byte");
            }

            // format function
            Console.WriteLine();
            Console.WriteLine("format function");
            var F_Name = "Matti Ur";
            var L_Name = "Rehman";

            var fullName = F_Name + " " + L_Name;
            Console.WriteLine(fullName);
            var myFullname = string.Format("my name is {0} {1}", F_Name, L_Name);

            // join function
            Console.WriteLine();
            Console.WriteLine("join function");
            String[] names = { "matti", "ali", "taha" };
            String result = String.Join(",", names);
            Console.WriteLine(result);

            // verbatiam string
            Console.WriteLine();
            Console.WriteLine("verbatiam string");
            string normalPath = "C:\\Users\\Matti\\Documents\\file.txt";
            Console.WriteLine(normalPath);

            string verbatiamPath = @"C:\Users\Matti\Documents\file.txt";
            Console.WriteLine(verbatiamPath);

            //Enum Method Calling
            Console.WriteLine();
            Console.WriteLine("Enum Method Calling");
            var method = ShippingMethod.RegisteredAirMail;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            // parse method
            Console.WriteLine();
            Console.WriteLine("Parse Method");
            var input = "Express";
            ShippingMethod sm = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), input);

            // value type
            Console.WriteLine();
            Console.WriteLine("value type");
            int a = 10;
            int b = a;

            a = 99;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            // referance type:-
            Console.WriteLine();
            Console.WriteLine("referance type");

            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = arr1;

            arr1[0] = 99;

            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

            // datetime:-
            //DateTime ki data type be datetime he hia

            Console.WriteLine("datetime");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            DateTime myDate = new DateTime(2025, 9, 19, 3, 03, 33);
            Console.WriteLine(myDate);

            Console.WriteLine("Date-Formate");
            var date = now.ToString("dd/mm/yyyy ss:mm:hh");
            Console.WriteLine(date);

            var dt = new DateTime(2001, 6, 25, 2, 3, 22);
            DateTime dt1 = DateTime.Now;

            TimeSpan diff = dt1 - dt;

            Console.WriteLine("Total Days: " + diff.Days);
            Console.WriteLine("Total Hours: " + diff.Hours);
            Console.WriteLine("Total Minutes: " + diff.Minutes);
            Console.WriteLine("Total Seconds: " + diff.Seconds);
            Console.WriteLine("Total in double Days: " + diff.TotalDays);

            // String her dafa memory main new object banay ga
            String str1 = "hi";
            str1 = str1 + " Matti!";
            Console.WriteLine(str1);

            //String Builder:- memory main new object nahii banay ga
            var sb = new StringBuilder("hello");
            sb.Append(" how are you doing");
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("?");
            Console.WriteLine(sb.ToString());


        }
    }
}