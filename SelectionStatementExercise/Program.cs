namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to play a guessing game?");
            string playGame = Console.ReadLine();

            while (playGame != "yes" && playGame != "no")
            {
                Console.WriteLine("That was not an option.\nDo you want to play a guessing game? ('yes' or 'no')");
                playGame = Console.ReadLine();
            }

            while (playGame == "yes")
            {
                var random = new Random();
                var favNumber = random.Next(1, 1000);
                var userInput = 0;

                while (userInput != favNumber) 
                {
                    Console.Write("Guess what my favorite number is:");
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput < favNumber)
                    {
                        Console.WriteLine($"Too low...\nYour guess: {userInput}");
                    }

                    else if (userInput > favNumber)
                    {
                        Console.WriteLine($"Too high...\nYour guess: {userInput}");
                    }

                    else
                    {
                        Console.WriteLine($"You got it!!!\nYour guess: {userInput}");
                    }
                }

                Console.WriteLine("Do you want to play again?");
                playGame = Console.ReadLine();
            }
            
            
            
           
            

            
        }
    }
}
