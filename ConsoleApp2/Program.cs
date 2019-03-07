﻿using System;
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

public class DelegateExercises
{
    public delegate int MyDelegate(int intvalue);

    int Method1(int intMethod1)

    {
        return intMethod1*4;
    }
    int Method2(int intMethod1)
    {
        return intMethod1*20;

    }
    public void Method4(MyDelegate myDelegate)
    {
        for (int i = 1; i <= 5; i++)
            System.Console.Write(myDelegate(i) + " ");
    }
    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        Method4(myDelegate);
        myDelegate = new MyDelegate(Method2);
        Method4(myDelegate);
    }
}
