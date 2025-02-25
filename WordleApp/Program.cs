using System.Runtime.InteropServices;

namespace WordleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Wordle App");
            Console.WriteLine("The rules:" +
                "\nYou have six guesses" +
                "\nThe word is a valid five letter word" +
                "\nA green letter is correct and in the right spot" +
                "\nYellow is correct but in the wrong place" +
                "\nWhite is not used at all");
            Random random = new Random();
           
            string choice;//initialize choice, this is for the do/while loop
            string[] answers = {"FLOAT","BLAME","SHARP","IDIOT","MORON","GLOAT","CLOAK","BROKE","FIXED","PUSHY"};//possible answers for the game to choose
            
            do
            {
                int turns = 0;
                bool victory = false;
                int pickedAnswer = random.Next(0,10);
                string answer = answers[pickedAnswer];
                while (!victory || turns == 5)
                {
                    Console.Write($"\nYour guess: ");
                    string entry = Console.ReadLine().ToUpper();
                    int strLength = entry.Length;
                    if (entry.Length < 5 || entry.Length > 5)
                    {
                        Console.WriteLine("All answers are precisely 5 letters long, this will not increment turns or provide a hint. Guess again.");
                    }
                    else
                    {
                       
                        for (int counter = 0; counter < answer.Length; counter++)
                        {

                            if (entry[counter] == answer[counter])
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if (answer.Contains(entry[counter]) && entry[counter] != answer[counter]) 
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }


                            Console.Write($"" + entry[counter].ToString() + " "); //prints your guess
                            Console.ForegroundColor = ConsoleColor.White;//reset color


                        }
                        if (entry == answer)
                        {
                            Console.Write("\nYou did it!");
                            victory = true;
                        }
                      
                        if (turns == 5)
                        {
                            Console.WriteLine("\nYou have lost.");
                            victory = true;//Ik its odd, but thats the name of the variable for leaving
                        }
                        turns++;
                    }
                    
                }
                int turnsTaken = turns;
                Console.WriteLine($"\nYou took {turns} turns");
                Console.Write("Would you like to play again? (y/n); ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
