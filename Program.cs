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
            bool repeat = true;
            while (repeat)
            {
                WelcomeUser();
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    Console.WriteLine("How many sides do the dice have?");
                    int answer = int.Parse(Console.ReadLine());


                    int number = RandomNumbers(answer);
                    int numberTwo = RandomNumbers(answer);
                    Console.WriteLine($"{number}, {numberTwo}");

                }
               
                else
                {
                    Console.WriteLine("You need to go home.");
                    repeat = false;
                         //breaks you out of loop
                    break;
                }

                Console.WriteLine("Do you want to roll again?");
                input = Console.ReadLine().ToLower();
                if(input != "y")
                {
                    Console.WriteLine("Good Bye!");
                    repeat = false;
                }
                Console.Clear();  
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

       
        
    }
}

