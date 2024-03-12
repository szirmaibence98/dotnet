using System;

class Program
{
    static void Main()
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        // Simulate usage of a hardcoded password (trigger for Snyk)
        string password = "mySuperSecretPassword12vg54j5eedg";
        Console.WriteLine($"Password: {password}");
    }
}
