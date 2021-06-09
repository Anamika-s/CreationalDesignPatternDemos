using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatternDemos
{
    class Teacher : i1
    {
        public string getName()
        {
            return "Teacher Name";
        }
        public string getFName()
        {
            return "Teacher Father Name";
        }
    }
    class Student : i1
    {
        public string getName()
        {
            return "Student Name";
        }
        public string getFName()
        {
            return "Student Father Name";
        }
    }

    interface i1
    {
        string getName();
        string getFName();
    }

      class CreateObj
    {
        public  static i1 getObject(string typeOfObject)
        {
            i1 obj = null;
            if (typeOfObject.ToLower() == "student")
            {
                obj = new Student();
            }
            else
            {
                obj = new Teacher();
            }
            return obj;
        }

    }
}
