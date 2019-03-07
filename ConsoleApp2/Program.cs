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
  
            DelegateExercises a = new DelegateExercises();
            a.Method2();

        }
    }
}

    public class DelegateExercises
{
    public delegate int  MyDelegate(int intValue);

    public intMethod1(int iMethod1)

    {
       return intMethod1 * 2;
    }

    public int Method2(int intMethod2)
    {
        return intMethod2 * 10;
    }
    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        int result1 = myDelegate(10);
        System.Console.WriteLine(result1);
        myDelegate = new MyDelegate(Method2);
        int result2 = myDelegate(10);
        System.Console.WriteLine(result2);
    }
}
