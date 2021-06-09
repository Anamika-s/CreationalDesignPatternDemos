using System;

namespace CreationalDesignPatternDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teacher teacher = new Teacher();
            //teacher.getFName();

            Console.WriteLine("ENter your class type");
            string type = Console.ReadLine();
            i1 obj = CreateObj.getObject(type);
            Console.WriteLine(obj.getName());

        }
    }
}
