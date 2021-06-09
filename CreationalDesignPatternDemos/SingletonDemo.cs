using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatternDemos
{
    public class Program3
    {
        static void Main()
        {
            SingletonDemo singletonDemo1 = SingletonDemo.MyObject();
            singletonDemo1.MyMethod();

            SingletonDemo singletonDemo2 = SingletonDemo.MyObject();
            singletonDemo2.MyMethod();

            //SingletonDemo singletonDemo1 = new SingletonDemo();
            //singletonDemo1.MyMethod();

            //SingletonDemo singletonDemo2 = new SingletonDemo();
            //singletonDemo2.MyMethod();


        }
    }


sealed class SingletonDemo
{
    private SingletonDemo() { }
    public static SingletonDemo getinstance = null;
    public static SingletonDemo MyObject()
    {
        if(getinstance == null)
    {
            return new SingletonDemo();
        }
        else {
            return getinstance;
        }
    }
    public void MyMethod()
    {
        Console.WriteLine("This is a method"); ;
    }
}


    // Thread Safe 
    public sealed class Singleton2
    {
        Singleton2() { }
        private static readonly object Lock = new object();  
    private static Singleton2 instance = null;
        public static Singleton2 Instance
        {
            get
            {
                lock (Lock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton2();
                        }
                        return instance;
                    }
            }
        }
    }
}

