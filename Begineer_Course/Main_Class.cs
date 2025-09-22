using System;
using System.Collections.Generic; // use to work with list and collections
using System.IO;
using System.Linq; // use to work with database
using System.Text; // use to work with texts
using System.Threading.Tasks; // use to work with multi threaded applications

namespace Begineer_Course
{

    internal class Main_Class
    {
        public static void Main(string[] args)
        {

            Lecture_Prastice lp = new Lecture_Prastice();
            //lp.myMethod();


            Conditional_Loops cl = new Conditional_Loops();
            //cl.questionOne();
            //cl.questionTwo();
            //cl.questionThree();
            //cl.questionFour();

            While_loop wl = new While_loop();
            //wl.questionOne();
            //wl.questionTwo();
            //wl.questionThree()
            //wl.questionFour();
            //wl.questionFive();

            Array_Exercise ae = new Array_Exercise();
            //ae.questionTwo();
            //ae.questionThree();

            Debugging db = new Debugging();
            db.debug();

        }
    }
}
