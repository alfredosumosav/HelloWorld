using System;
/*
 * Here import all classes (including methods),
 * interfaces
 * and types
 * that you need
 */

namespace HelloWorld
{
    // Single-line comment
    /// <summary>
    /// This is an important class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 10;
            //double num2 = 11.1;
            //bool state = true;
            //char char1 = 'a';
            //string str = "hello";
            //int maxInt = int.MaxValue;
            //int minInt = int.MinValue;
            //var num1 = 10;
            //var num2 = 11.1;
            //var state = true;
            //var char1 = 'a';
            //var str = "hello";
            int x = 10;
            int y = 11;
            var z1 = x++;
            var z2 = ++y;
            Console.WriteLine("Hello World!");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z1);
            Console.WriteLine(z2);
            //Console.WriteLine(maxInt);
            //Console.WriteLine(maxInt+1);
            //Console.WriteLine(minInt);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(state);
            //Console.WriteLine(char1);
            //Console.WriteLine(str);
        }
    }
}
