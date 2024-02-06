using System;
using ListLecture.Models;

namespace ListLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Product test = new Product("apple");

            Console.WriteLine(test.Name);
        }
    }
}
