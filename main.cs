using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold and rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you investigate?");
      Console.WriteLine("Type YES or NO");
      string noiseChoice = Console.ReadLine().ToUpper();

      if (noiseChoice == "NO") {
        Console.WriteLine("Not much of an adventure if we don't leave our room! THE END");
      } else if (noiseChoice == "YES") {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
      } else {
        Console.WriteLine("Please enter a valid response next time...");
        return;
      }

      Console.WriteLine("Type OPEN or KNOCK");
      string doorChoice = Console.ReadLine().ToUpper();

      if (doorChoice == "KNOCK") {
        Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \" \"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
        Console.WriteLine("Type your answer:");
        string riddleAnswer = Console.ReadLine().ToUpper();
        if (riddleAnswer == "NOTHING") {
          Console.WriteLine("The door opens and nothing is there. You turn off the light and run back to your room and lock the door. THE END");
        } else {
          Console.WriteLine("The voice says \"You should have known better\", as you fall to the ground before everything goes black, you see a hooded figure standing over you. THE END");
        }
      } else if (doorChoice == "OPEN") {
        Console.WriteLine("The door is locked! See if one of your 3 keys will open it.");
        Console.WriteLine("Enter a number (1-3):");
        string keyChoice = Console.ReadLine();

        switch (keyChoice) {
          case "1":
            Console.WriteLine("You chose the first key. Lucky choice! The door opens and nothing is there, strange... THE END");
            break;
          case "2":
            Console.WriteLine("You chose the wrong key. The door does not open. THE END");
            break;
           case "3":
             Console.WriteLine("You chose the wrong key. The door does not open. THE END");
             break;          
        }
      } else {
        Console.WriteLine("Please enter a valid response next time...");
        return;
      }
     
    }
  }
}

