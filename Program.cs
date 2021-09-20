using System;
using System.Collections.Generic;
using Challenge.Models;


namespace Challenge {

  class Program
  { 
    static void Win() {
      Console.WriteLine("You defeated the sphinx!");
    }

    static void Lose() {
      Console.WriteLine("The sphinx ate you for dinner.");
    }

    static void Main()
  {
    Console.WriteLine("The sphinx will ask you a riddle. Get it wrong and she will eat you...");
    Riddle firstRiddle = new Riddle("What is at the end of the rainbow?", "w");
    Riddle secondRiddle = new Riddle("The more of this there is, the less you see? What is it?", "darkness");
    Console.WriteLine(firstRiddle.GetQuestion());
    string answer1 = Console.ReadLine();
    if (firstRiddle.AskRiddle(answer1)) {
      Console.WriteLine("Pretty smart. But how about this one?");
      Console.WriteLine(secondRiddle.GetQuestion());
      string answer2 = Console.ReadLine();
      if (secondRiddle.AskRiddle(answer2)) {
        Program.Win();
      } else {
        Program.Lose();
      }
    } else {
      Program.Lose();
      }
    }
  }
}

// firstRiddle.GetQuestion();
// firstRiddle.SetAnswer("Dogs");
// Console.WriteLine("The Sphinx will now ask you a riddle");
// Concole.WriteLine(firstRiddle.GetQuestion());
// string input = Console.ReadLine();
// 