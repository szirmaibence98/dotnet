using System;

class Program
{
    static void Main()
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        // Simulate usage of a hardcoded password (trigger for Snyk)
        string password = "mySuperSecretPassword12wdffddd8d3y34";
        Console.WriteLine($"Password: {password}");
    }
}
