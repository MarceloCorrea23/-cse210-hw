using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int numberUser = 0;
        
        do{
            Console.Write("Enter a number. Entering the number 0 stops the number loading: ");

            string UserNumber= Console.ReadLine();
            numberUser = int.Parse(UserNumber);

            if(numberUser != 0){
                numbers.Add(numberUser);
            }

        } while (numberUser != 0);


        //1. Compute the sum, or total, of the numbers in the list.

        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
                       
        }
        Console.WriteLine($"THE TOTAL SUM IS: {sum}");

        //2. Compute the average of the numbers in the list.

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //3. Find the maximum, or largest, number in the list.

        int big= numbers[0];

        foreach (int number in numbers){

            if(number > big){

                big = number;

            }
        }
        Console.Write($"The largest number is: {big}");
    }
}