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
            Random random = new Random();//because the word is chosen randomly
            int chosenAnswer = random.Next(0,10);
            string choice;//initialize choice, use this for the do/while
            string[] answers = {"FLOAT","BLAME","SHARP","IDIOT","MORON","GLOAT","CLOAK","BROKE","FIXED","PUSHY"};//possible answers for the game to choose
            //Console.WriteLine(answers[chosenAnswer]); was to test that the random worked

            do
            {
                int pickedAnswer = random.Next(0,10);
                while (!victory)
                {
                    Console.Write($"Your guess: ");
                    string entry = Console.ReadLine().ToUpper();
                    if ( entry == answers[pickedAnswer])
                    {
                        Console.WriteLine("You did it!");
                        victory = true;
                    }
                    turns++;
                }
                Console.WriteLine($"You took {turns} turns");
                Console.Write("Would you like to play again? (y/n); ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
