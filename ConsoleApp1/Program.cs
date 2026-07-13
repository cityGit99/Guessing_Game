namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNumber = random.Next(1, 11);

            Console.WriteLine("=======Welcome the the fun guessiong game=======");
            Console.WriteLine("A number between 1 and 10 will be generated.");
            Console.WriteLine("If you guess the correct number, you win!");
            Console.WriteLine("================================================");


            while (!isCorrectGuess) 
            {
            Console.WriteLine("Please enter your guess (between 1 and 10):");
            int guess = Convert.ToInt32(Console.ReadLine());

                if(guess > randomNumber)
                {
                    Console.WriteLine("You guess is too high");
                }else if(guess < randomNumber)
                {
                    Console.WriteLine("You guess is too low");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the correct number!");
                    isCorrectGuess = true;
                    
                }
                Console.WriteLine("You have won the game!");
            }

            Console.ReadKey();

        }
    }
}
