using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMethodTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.Print();
            p.PrintTest();

            p = new Child();
            p.Print();
            p.PrintTest();

            p = new GrandChild();
            p.Print();

            p = new GrandGrandChild();
            p.Print();

            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();

            Console.ReadKey();
        }
    }

    class Parent
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a parent");
        }

        protected virtual void Test()
        {
            Console.WriteLine("Parent test");
        }

        public virtual void PrintTest()
        {
            this.Test();
        }
    }

    class Child : Parent
    {
        public override void Print()
        {
            Console.WriteLine("I am a child");
        }

        protected override void Test()
        {
            Console.WriteLine("Child test");
        }
    }

    class GrandChild : Child
    {
        public override void Print()
        {
            Console.WriteLine("I am a grand child");
        }
    }

    class GrandGrandChild : GrandChild
    {
        public override void Print()
        {
            Console.WriteLine("I am a super grand child");
        }
    }
}
