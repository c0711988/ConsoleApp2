using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0711988_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Name Jaspreet Singh Dhaliwal  Student ID C0711988
            //CSD3354 Section 2
            //Assignment 2
            // March 6,2019
            //TO DO: Call Method2 from the DelegateExercises Class
            DelegateExercises a = new DelegateExercises();
            a.Method2();

        }
    }
}

    public class DelegateExercises
{
    public delegate int  MyDelegate();

    void Method1()

    {
        System.Console.WriteLine("MyDelegate");

    }
    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        myDelegate();
    }
}
