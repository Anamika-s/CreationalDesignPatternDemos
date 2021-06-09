using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatternDemos
{
    public class Program2
    {
        static void Main()
        {
            WithOutSingletonDemo singletonDemo1 = new WithOutSingletonDemo();
            singletonDemo1.MyMethod();

            WithOutSingletonDemo singletonDemo2 = new WithOutSingletonDemo();
            singletonDemo2.MyMethod();
        }
    }
    }
    class WithOutSingletonDemo
    {
        public void MyMethod()
        {
            Console.WriteLine("This is a method"); ;
        }
    }
