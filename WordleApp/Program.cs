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
                "\nBlue is not used at all");
            int turns = 0;//initializing at zero turns
            bool victory = false; //if they have won
            //bool validInput = false;//if input is valid or not
            Random random = new Random();//because the word is chosen randomly
            //int chosenAnswer = random.Next(0,10);
            string choice;//initialize choice, use this for the do/while
            string[] answers = {"FLOAT","BLAME","SHARP","IDIOT","MORON","GLOAT","CLOAK","BROKE","FIXED","PUSHY"};//possible answers for the game to choose
            string testString = "FLACK";
            //Console.WriteLine(answers[chosenAnswer]); was to test that the random worked

            do
            {
                int pickedAnswer = random.Next(0,10);
                string answer = answers[pickedAnswer];
                while (!victory)
                {
                    Console.Write($"Your guess: ");
                    string entry = Console.ReadLine().ToUpper();
                    int strLength = entry.Length;
                    if(entry.Length < 5 || entry.Length > 5)
                    {
                        Console.WriteLine("All answers are precisely 5 letters long, this will not increment turns or provide a hint. Guess again.");
                    }
                    for(int counter = 0; counter < answer.Length; counter++)
                    {
                        if (entry[counter] == answer[counter])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (answer.Contains(entry[counter]) && entry[counter] != answer[counter])
                        {
                            Console.ForegroundColor= ConsoleColor.Yellow;
                        }
                        Console.WriteLine(entry[counter].ToString());
                        Console.ForegroundColor= ConsoleColor.White;//reset
                        //testing char iteration
                        //if (entry == answers[pickedAnswer][counter])
                        //{

                        //}
                        //if (entry.Equals(answers[pickedAnswer]))
                        //{
                        //    victory = true;
                        //}
                    }
                    //if ( entry == answers[pickedAnswer])
                    //{
                    //    Console.WriteLine("You did it!");
                    //    victory = true;
                    //}
                    //turns++;
                }
                Console.WriteLine($"You took {turns} turns");
                Console.Write("Would you like to play again? (y/n); ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
