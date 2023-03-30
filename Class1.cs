using Microsoft.VisualBasic.FileIO;
using System;
using System.Xml.Linq;
using System.IO;




namespace Security
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hi! Welcome to the Game");
      while (true)
      {
        Console.WriteLine();
        Console.WriteLine("Are you ready to Go \n1.YES \n 2.NO \n");
        var option = Convert.ToInt32(Console.ReadLine());
        if (option == 2)
        {
          break;
        }
        Console.WriteLine("Enter your name");
        var name = Console.ReadLine();
        Console.WriteLine("{0} you are ready to go!", name);
        int compscore = 0;
        int playscore = 0;
        Console.WriteLine();
        Console.WriteLine("You have 3 chances to play and after 3 chances the max scorer will be the winner");
        Console.WriteLine();
        Console.WriteLine("You opponent is Mr.Computer");
        Console.WriteLine();
        Console.WriteLine("Start the game");
        for (int i = 1; i < 4; i++)
        {
          Console.WriteLine();
          Console.WriteLine("Player's turn:");
          Console.WriteLine();
          Console.WriteLine("Select your choice");
          Console.WriteLine("1.STONE\n 2.PAPER\n 3.SCISSOR\n");
          var ch = Convert.ToInt32(Console.ReadLine());
          if (ch == 1)
          {
            Console.WriteLine("STONE");
          }
          else if (ch == 2)
          {
            Console.WriteLine("PAPER");
          }
          else if (ch == 3)
          {
            Console.WriteLine("SCISSOR");
          }
          else
          {
            Console.WriteLine("Invalid Choice....Please select a number");
            continue;
          }
          Console.WriteLine();
          Console.WriteLine("Mr.Computer's turn :");
          var random = new Random();
          var list = new List<string> { "STONE", "PAPER", "SCISSOR" };
          int index = random.Next(3);        //selects a random number between 0 and 3
          Console.WriteLine(list[index]);
          Console.WriteLine();
          if (ch == 1 && index == 0 || ch == 2 && index == 1 || ch == 3 && index == 2)
          {
            Console.WriteLine();
            Console.WriteLine("Oh no! Its a TIE");
            Console.WriteLine("................................");
          }
          else if (ch == 1 && index == 1 || ch == 2 && index == 2 || ch == 3 && index == 0)
          {
            Console.WriteLine();
            Console.WriteLine("Mr.Computer won! ");
            Console.WriteLine("1 point");
            Console.WriteLine("................................");
            compscore += 1;
          }
          else if (index == 0 && ch == 2 || index == 1 && ch == 3 || index == 2 && ch == 1)
          {
            Console.WriteLine();
            Console.WriteLine("Player won!");
            Console.WriteLine("1 point");
            Console.WriteLine("................................");
            playscore += 1;
          }
        }
        Console.WriteLine(".................................");
        Console.WriteLine("GAME OVER");
        Console.WriteLine();
        Console.WriteLine("Mr.Computer's score is" + compscore);
        Console.WriteLine();
        Console.WriteLine("Player's score is " + playscore);
        Console.WriteLine();
        if (compscore == playscore)
        {
          Console.WriteLine();
          Console.WriteLine("This Game is a TIE \n Both are the Winners");
        }
        else if (compscore > playscore)
        {
          Console.WriteLine();
          Console.WriteLine("Mr.Computer has won the Game ! \n Please try again");
        }
        else if (playscore > compscore)
        {
          Console.WriteLine();
          Console.WriteLine("Hurray! You have won the Game \n Congratulations");
        }
        Console.WriteLine();
        Console.WriteLine("Do you want to exit the Game ?");
        Console.WriteLine("Choose your Option:\n 1.Yes \n 2.No\n");
        var select = Convert.ToInt32(Console.ReadLine());
        if (select == 1)
          break;
      }
    }
  }



}
