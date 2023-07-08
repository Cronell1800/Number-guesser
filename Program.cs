namespace Number_guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Random random = new Random();
            int guessedNumber = random.Next(1, 100);

            Console.WriteLine("Can you guess the number i'm thinking?");

            do
            {
                Console.WriteLine("Enter guessed number: ");
                String number = Console.ReadLine();
                int enteredNumber = int .Parse(number);
                counter++;

                if (enteredNumber == guessedNumber)
                {
                    break;
                } else if (enteredNumber < guessedNumber)
                {
                    Console.WriteLine("My guessed number is bigger");
                } else if (enteredNumber > guessedNumber)
                {
                    Console.WriteLine("My guessed number is smaller");
                }


            } while (counter < guessedNumber);

            Console.WriteLine("You have found the number i guessed in " + counter + " turns");
        }
    }
}