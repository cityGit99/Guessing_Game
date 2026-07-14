namespace gameCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int UserOption;

            Console.WriteLine("Welcome to the Game Collection!");
            Console.WriteLine("Please enter below number to choose a game to play:");
            Console.WriteLine("1.Guessing Game");
            Console.WriteLine("2.Dice Game");

            UserOption = Convert.ToInt32(Console.ReadLine());

            if (UserOption == 1)
            {
                GuessGame guessGame = new GuessGame();
                guessGame.GuessingGame();
            }
            else if (UserOption == 2)
            {
                
            }
            else
            {
                Console.WriteLine("Invalid option. Please restart the program and choose a valid game.");
            }



        }
    }
}
