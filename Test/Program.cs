using System;
using Test.Models;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new A2Context();
            var users = dbContext.User.ToList();

            foreach (var u in users) {
                Console.WriteLine($"ID: {u.Id}, Username: {u.Username}");
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}