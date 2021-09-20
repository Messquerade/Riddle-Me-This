using System;
using System.Collections.Generic;
using Challenge.Models;


namespace Challenge {

  class Program
  {
    static void Main()
  {
    Riddle firstRiddle = new Riddle("What is at the end of the rainbow?", "W");
    Console.WriteLine(firstRiddle.GetQuestion());
    string answer1 = Console.ReadLine();
// bool answer1 = question1 == "Yes" 
    if (firstRiddle.AskRiddle(answer1)) {
      Console.WriteLine("Congratulations! You defeated the Sphinx!");

    } else {
      Console.WriteLine("The Sphinx ate you for dinner.");
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