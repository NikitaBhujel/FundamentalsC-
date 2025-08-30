using System;
using System.Runtime.CompilerServices;

namespace fundamental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            Console.Write("Hi");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Lets get started with number" +n);
            Console.WriteLine("C# is read as C Sharp ");
            int a = 2, b = 3;
            Console.WriteLine("Display" + (a + b));
            //Console.ReadLine();
            //Variables are containers for storing data values
            string name = "Niki";
            Console.WriteLine(name);
            int myNum = 15;
            Console.WriteLine(myNum);
            int my = 15;
            my = 20; // myNum is now 20
            Console.WriteLine(my);
            //constant
            const int c = 1;
            //myNum = 20; This throws error
            Console.WriteLine("c" + c);


        }
    }
}
