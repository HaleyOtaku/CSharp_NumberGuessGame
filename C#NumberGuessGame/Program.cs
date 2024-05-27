//Following this tutorial => https://youtu.be/Qs2aDQq8yWc?si=PKvkF38_zKinbJIs

namespace C_NumberGuessGame
{
    //Remove internal from class name!
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            //1 is the (inclusive) lower bound, while 11 is the (exclusive) upper bound
            //So, the range below is 1-10, since 11 is "excluded"
            int randomNum = random.Next(1,11);

            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("A number between 1 and 10 will be generated.");
            Console.WriteLine("If you guess the correct number, you win!");

            //Testing purposes: Console.WriteLine(randomNum);

            //The following loop will keep running while isCorrectGuess is false
            while (!isCorrectGuess) 
            {
                Console.WriteLine("Please enter your guess.");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("Your guess is too high!");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low!");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    isCorrectGuess = true;
                }
                
            }

            Console.WriteLine("Congratulations! You have won the game!");
            Console.ReadKey();
        }
    }
}
