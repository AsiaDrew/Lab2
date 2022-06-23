public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hey there, what is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Nice to meet you {name}!");

        while (true)
        {
            Console.Write($"{name} please enter a number between 1 - 100: ");
            int input = int.Parse(Console.ReadLine());

            if (input >= 0 && input <= 100)
            {
                //odd
                if (input % 2 == 1 && input < 60)
                {
                    Console.WriteLine("Odd and less than 60");
                }
                else if (input % 2 == 1 && input > 60)
                {
                    Console.WriteLine("Odd and greater than 60");
                }

                //even
                if (input % 2 == 0)
                {
                    if (input % 2 == 0 && input < 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (input >= 26 && input <= 60)
                    {
                        Console.WriteLine("Even and between 26 and 60 inclusive");
                    }
                    else if (input > 60)
                    {
                        Console.WriteLine("Even and greater than 60");
                    }

                }
            }
            else
            {
                Console.WriteLine($"OOPS!!! Try again {name}. Pick a number between 1 - 100.");
            }

            //prompt to end
            Console.WriteLine($"Do you want to enter another number {name}? Enter y/n.");
            string response = Console.ReadLine();
            if (response.ToLower() == "y")
            {
                continue;
            }
            else if (response.ToLower() == "n")
            {
                Console.WriteLine($"Bye {name}!");

                break;
            }
            else
            {
                Console.WriteLine($"Bye {name}!");
                break;
            }

        }
    }
}