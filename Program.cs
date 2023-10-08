using System;
namespace NLogDemo
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of Two numbers");
            int a = 6; //Convert.ToInt32(Console.ReadLine());
            int b = 2; //Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a = "+a+"\n"+"b = "+b);
            AddNumbers add = new AddNumbers ();
            Console.WriteLine("Result is " +" "+ add.Sum(a,b));

        }
    }
}
