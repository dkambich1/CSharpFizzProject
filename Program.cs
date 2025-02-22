using System.Globalization;




class Program
{
    static void Main()
    {
        string[] action = ["Fizz", "Buzz"];
        int gameCount = 101;

        for(int i = 1; i < gameCount; i++)
        {
            if(i % 5 == 0 && i % 3 == 0)
                Console.WriteLine($"{i} - {action[0]}{action[1]}");
            
            else if(i % 5 == 0)
                Console.WriteLine($"{i} - {action[1]}");

            else if(i % 3 == 0)
                Console.WriteLine($"{i} - {action[0]}");
            else    
                Console.WriteLine(i);
        }

    }
}