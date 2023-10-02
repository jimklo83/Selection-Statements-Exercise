namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favNumber = random.Next(1, 1000);
            Console.Write("Guess what my favorite number is:");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low...");
            }

            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high...");
            }

            else
            {
                Console.WriteLine("You got it!!!");
            }
        }
    }
}
