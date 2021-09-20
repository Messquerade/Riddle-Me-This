using System;
using System.Collections.Generic;

namespace Challenge.Models {

  public class Riddle
  {
    public string Question { get; set; }
    public string Answer { get; set; }

    public Riddle(string question, string answer)
    {
        Question = question;
        Answer = answer;
    }

    public string GetQuestion() {return Question;}
    public string GetAnswer() {return Answer;}

    public bool AskRiddle(string input)
    {
      if (input == Answer) {
        return true;
      } else {
        return false;
      }
    }
  }

}



// ask user a riddle, if correct console.writeline("You defeated the Sphinx")
// if incorrect, ("Sphinx ate you for dinner X.X")
// class is Riddle
// fields could be question, answer
// constructor
// methods askRiddle, getting and setting
// askRiddle("input") takes string input, and checks if it is the same as the Riddle.answer
// return bool true if they are same, false if the input is not the same as the answer
