using System;

partial class Program
{
  static void Main(string[] args)
  {
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Hello, " + name + "!");

    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
  }
}

