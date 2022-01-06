using System;
using System.Collections.Generic;
using System.Linq;

namespace Program 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string yourName = Console.ReadLine();

            Console.WriteLine("Hello <" + yourName + " >!");
            Console.WriteLine("Welcome to NTQ Solution");
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}