using System;

namespace NumberGuess {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Welcome to the number guess game !");

      Random rd = new();
      int answer = rd.Next(1, 21);
      int attempted = 3;
      int counter = 0;
      Console.WriteLine("Enter your guess from 1 to 20:");
      while (counter <= 2) {

        int guess = guessnum();
        counter++;
        if (guess < answer) {
          Console.WriteLine("Your guess was too low");
        } else if (guess > answer) {
          Console.WriteLine("Your guess was too high");
        } else {
          Console.WriteLine("Correct! You win!");
          break;
        }
        Console.WriteLine("You have {0} attempt left", attempted - counter);
      }

      Console.WriteLine($"The guess number was: {answer}");

    } // main method 

    private static int guessnum() {

      int input = 0;
      try {
        input = Convert.ToInt32(Console.ReadLine());
      } catch (FormatException) {
        Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
        input = guessnum();
      }
      if (input > 20) {
           Console.WriteLine("Please enter value < 21");
          input = guessnum();   

      }
      return input;

    } // end of enterinput ()

  } //  class program
}