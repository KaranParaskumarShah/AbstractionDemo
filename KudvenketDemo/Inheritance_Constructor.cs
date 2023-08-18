using System;

namespace KudvenketDemo
{
    public class Inheritance_Constructor
    {
        public string firstName;
        public string lastName;
        public static string collegeName = "SAL COLLEGE OF ENGINEERING";

        public string grade;


        static Inheritance_Constructor()
            {
            Console.WriteLine("hi the first block of code execute ");
            }


        public Inheritance_Constructor()
        {
            Console.WriteLine("This is a base class and also default constructor");
        }

        public Inheritance_Constructor(string message)
        {
            Console.WriteLine("This is parameterized constructor " + message);
        }




    }


    public class ChildDemo : Inheritance_Constructor
    {
        public string organizeName;
        public string tutionSirName;

        public ChildDemo()
        {
            Console.WriteLine("This is a child class and also default constructor");
        }

        //when i pass the parameter but constructor called in parent class is default constructor so if i want to called parent parameterized constructor 
        public ChildDemo(string message) : base("Aman")
        {
            Console.WriteLine("this is a parameterized constructor " + message);
        }

    }

    public class Documents : ChildDemo
    {
        public string aadharno;
        public void Print()
        {
            Console.WriteLine("this is a multileve inheritance and also use static variable");
        }
    }




}
