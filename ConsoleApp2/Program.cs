using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0711988_Assignment2
{
   public class Program
    {
        public static void Main()
        {// Student Name Jaspreet Singh Dhaliwal  Student ID C0711988
            //CSD3354 Section 2
            //Assignment 2
            // March 6,2019
            // TO DO: Call Method2 from the DelegateExercises Class
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }
}

public delegate void MyDelegate();

public class DelegateExercises
{
    void Method1()
    {
        System.Console.WriteLine("Method1");
    }
    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        myDelegate();
    }
}
