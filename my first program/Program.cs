using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_first_program
{
    class Program
    {
        static void Main(string[] args)
        {
            //output text


            Console.WriteLine("Hello. What is your name?");

            int playerScore = 0;
            string playerName = "";

            playerName = Console.ReadLine();

            int add = 0;

            while (playerScore < 20) 
            //requesting input
            {
                Console.Write("Increment score: ");
                add = Convert.ToInt32(Console.ReadLine());

                playerScore = playerScore + add;
                Console.Write("current Score: ");
                Console.WriteLine(playerScore);
            }

            Console.WriteLine("Score of ");
            Console.WriteLine(playerScore);
            Console.WriteLine(playerScore);
        
          
            
            
        }
    }
}
