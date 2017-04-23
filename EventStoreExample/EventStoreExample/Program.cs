using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Domain;
using Domain.Entities;

namespace EventStoreExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var subjects = new List<Subject>
            {
                Subject.Create("Mathmatics", 8.9),
                Subject.Create("English", 6.5),
                Subject.Create("Biological Sciences", 3.4)
            };
            var student = Student.Create("Guilherme", 25, "00206745", subjects);
            Console.ReadKey();
        }
    }
}
