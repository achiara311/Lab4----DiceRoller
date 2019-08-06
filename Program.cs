using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolling
{
    class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            WelcomeUser();
            string input = Console.ReadLine().ToLower();
            bool repeat = true;
            while (repeat)
            {

                if (input == "y")
                {
                    int answer = TryParseInt("How many sides do the dice have?");

                    int number = RandomNumbers(answer);
                    int numberTwo = RandomNumbers(answer);
                    Console.WriteLine($"{number}, {numberTwo}");

                    repeat = true;

                }
                else if (input == "n")
                {
                    Console.WriteLine("See you later.");
                    break;
                }
                else
                {
                    Console.WriteLine("Go home and eat your nuggets, Becca. You're drunk.");
                    break;
                }

                Console.WriteLine("Do you want to roll again?");
                input = Console.ReadLine().ToLower();
                if (input != "y" && input != "yes")
                {
                    Console.WriteLine("Good Bye!");
                    repeat = false;
                }     

            }
            Console.ReadKey();
        }

        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? Y/N");
        }

        //Function to get random number
        public static int RandomNumbers(int number)
        {
            number = random.Next(1, number + 1);

            return number;

        }

        public static int TryParseInt(string message)
        {
            try
            {
                Console.WriteLine(message);
                int answer = int.Parse(Console.ReadLine());
                return answer;
            }
            catch (Exception)
            {
                Console.WriteLine("Not a number try again\n");
                return TryParseInt(message);
            }
        }

    }
}

