using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    //interface of 1 : A
    public interface Wholeseller
    {
        void bigQuantityOfTowel();


    }

    //interface of 2 : A
    public interface Retailer
    {
        void smallQuantityofTowel();
    }
    //normal abstract class
    public abstract class Gov
    {
        public void govScheme()
        {
            Console.WriteLine("here medical 5lpa free in semi gover");
        }
    }

    //abstract class of 1 : A
    //here abstract class extends multiple interface
    //
    public abstract class Handloom : Gov, Wholeseller, Retailer
    {
        public abstract void towel();

        public virtual void bedsheets()
        {
            Console.WriteLine("Here different different bedsheets ");
        }


        public void curtains()
        {
            Console.WriteLine("here door and widow curtains available");

        }


        public void doormates()
        {
            Console.WriteLine("Here Lots of quality there for the customers");
        }

        public void bigQuantityOfTowel()
        {
            Console.WriteLine("I want 10000");
        }

        public void smallQuantityofTowel()
        {
            Console.WriteLine("I want 100 ");
        }
    }


    //child class : A
    public class Store : Handloom
    {
        public override void towel()
        {
            Console.WriteLine("Moti ,Magic ,luchavala towel are there");
        }

        public override void bedsheets()
        {
            base.bedsheets();
            Console.WriteLine("Single with pillow and without pillow");
        }

        public new void curtains()
        {
            Console.WriteLine("new curtains");
        }


        public Store()
        {
            Console.WriteLine("this is default constructor");
        }
        int num3;
        double num4;
        string fname;

        public Store(int num1, string name, double num2)
        {
            num3 = num1;
            fname = name;
            num4 = num2;
            Console.WriteLine($"this is parameterized constructor {num3},{fname},{num4}");
        }

    }


    //abstract class : B
    public abstract class HighClassCustomer
    {
        int bill = Convert.ToInt32(Console.ReadLine());
        public void billPrice()
        {
            if (bill > 10000)
            {
                Console.WriteLine("Premium Customer");
            }
            else
            {
                Console.WriteLine("Average Customer");
            }
        }

        public abstract void lowClassCustomer();

    }

    //child class : B
    public class Customer : HighClassCustomer
    {
        public override void lowClassCustomer()
        {
            Console.WriteLine("this is customer of low bill");
        }
    }

    //abstract class : c
    //abstract class inherit another abstract class after agian inherit child class
    //here one abstract class has no abstract methods
    //
    public abstract class Worker
    {
        public void name()
        {
            Console.WriteLine("kalu");
        }
    }

    public abstract class WorkerFamily : Worker
    {
        public void member()
        {
            Console.WriteLine("Total member of the family");
        }
    }

    public class WorkerChild : WorkerFamily
    {
        public void memberIncome()
        {
            Console.WriteLine("1000k");
        }
    }


    public class GovChild : Handloom, Wholeseller, Retailer
    {
        public void bigQuantityOfTowel()
        {
            throw new NotImplementedException();
        }

        public void smallQuantityofTowel()
        {
            throw new NotImplementedException();
        }

        public override void towel()
        {
            throw new NotImplementedException();
        }
    }



    //Main class of project
    class Program
    {
        static void Main(string[] args)
        {
            Store objSelect = new Store();
            objSelect.towel();
            objSelect.bedsheets();
            objSelect.curtains();
            objSelect.doormates();

            Store objSelect2 = new Store(32, "hello", 777.6789D);



            WorkerChild objWoker = new WorkerChild();
            objWoker.memberIncome();
            objWoker.name();
            objWoker.member();

            Console.ReadKey();
        }
    }
}
