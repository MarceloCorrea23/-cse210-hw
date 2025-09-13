using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        // part of the code that generates the random number

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, 100);

        int number;
        
        do {
            Console.Write("What is your guess? ");
            number = int.Parse(Console.ReadLine());

            if (randomNumber > number){
                 Console.WriteLine("Higher");
            }
             else if (randomNumber < number){
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("You guessed it!");
            }    
        
        } while (number != randomNumber);

    }
}