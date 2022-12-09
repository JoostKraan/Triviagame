using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Triviagamefinal;

namespace TriviaGame
{
    public class Game
    {
        static Program Program = new Program();
        static Game newGame = new Game();
        static Program user = new Program();

        public static void resetConsole()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void Start()
        {

            Console.Clear();
            Console.WriteLine("                                                             - Welcome to my Trivia game! -");
            Console.WriteLine("                                                     - You can choose between 3 categories and one mixed category -");
            Console.WriteLine("");
            Console.WriteLine("                                                     1) C# Questions");
            Console.WriteLine("");
            Console.WriteLine("                                                     2) Geography and History");
            Console.WriteLine("");
            Console.WriteLine("                                                     3) Gaming related Questions");
            Console.WriteLine("");
            Console.WriteLine("                                                     4) Mix");
            Console.WriteLine();
            Console.WriteLine("                                                     5) Go back to main menu...");

            int bTomain = int.Parse(Console.ReadLine());

            if (bTomain == 1)
            {
                Console.Clear();

                Console.ReadLine();
            }


        }
        
    }
}
