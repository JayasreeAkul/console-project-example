using System;
using System.Diagnostics;


partial class Program
{
  static void Main(string[] args)
  {
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Hello, " + name + "!");

    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();

    string s1 = @"/C dir c:\jaya\" + Request.QueryString["dir"];
    ProcessStartInfo i1 = new ProcessStrartInfo("CMD.exe", s1);
    Process.Start(i1);
  }
}
