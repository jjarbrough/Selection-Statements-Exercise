using System.Runtime.CompilerServices;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("guess a number");
            var userInput = int.Parse(Console.ReadLine());
            if(userInput < favNumber)
            {
                Console.WriteLine("too low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high!");
            }
            else
            {
                Console.WriteLine("Guessed it!");
            }
        }
    }
}
