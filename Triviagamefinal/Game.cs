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
            
            if(bTomain == 1)
            {
                Console.Clear();
                CsharpQuestion csharp = new CsharpQuestion();
                Console.WriteLine(csharp.AskMeQuestion());
             var input =  Console.ReadLine();
            
            }





        }


        public static void NLQuestions()
        {

            string[] Geohisto = //Questions related to history and geography
            {
                "                                       Wat is de hoofdstad van egypte?",
                "Wat is het kleinste land op aarde?",
                "Wat is de hoofdstad van Turkmenistan?",
                "Wanneer is Zuid-Sudan onafhankeijk geworden?",
                "Wat is het Grootse land op aarde?",
                "Wie is de premier van Duitsland?",
                "In welk land is Internet uitgevonden",
                "Wie heeft de radio uitgevonden",
                "Welk land heeft de meeste inwoners op aarde?",
                "'Wat is de oudste stad in de wereld?"
            };
            string[] GamingQ = //Gaming related questions
            {
                "Wat is het eerste spel dat is gemaakt?",
                "Wat is een indie game?",
                "Wat is de eerste gameConsole die is uitgekomen?",
                "Van welk bedrijf is Xbox?",
                "Wat is het eerste pixel art game?",
                "Wat is het grootste spel in bestandsgroote?",
                "Welk spel duurde het langst om te maken?",
                "Wat is het meest verkochte spel op Steam?",
                "Wie is de eigenaar van steam?",
                "Welke gamestudio’s heeft Microsoft gekocht?"
            };
            string[] Mixed = //All questions from the 3 Categories in one quiz (30 questions total)
            {
                "                       Wanneer gebruik je if else?",
                "                       Hoe zorg je ervoor dat een stukje code niet gelezen word door de compiler?",
                "                       Welke symbolen gebruik je voor het aangeven van een string?",
                "                       Hoe roep je een Method op?",
                "                       Wat is de maximale waarde die in een int past",
                "                       Welke waardes kan een bool hebben?",
                "                       Waar gebruik je Console.ReadLine(); voor?",
                "                       Hoe stop je een loop?",
                "                       Met welke tekens kun je een bepaald aantal regels commenten?",
                "                       Wat doet de eerste waarde van een Console.Beep?",
                "Wat is de hoofdstad van egypte?",
                "Wat is het kleinste land op aarde?",
                "Wat is de hoofdstad van Turkmenistan?",
                "Wanneer is Zuid-Sudan onafhankeijk geworden?",
                "Wat is het Grootse land op aarde?",
                "Wie is de premier van Duitsland?",
                "In welk land is Internet uitgevonden",
                "Wie heeft de radio uitgevonden",
                "Welk land heeft de meeste inwoners op aarde?",
                "'Wat is de oudste stad in de wereld?",
                "Wat is het eerste spel dat is gemaakt?",
                "Wat is een indie game?",
                "Wat is de eerste gameConsole die is uitgekomen?",
                "Van welk bedrijf is Xbox?",
                "Wat is het eerste pixel art game?",
                "Wat is het grootste spel in bestandsgroote?",
                "Welk spel duurde het langst om te maken?",
                "Wat is het meest verkochte spel op Steam?",
                "Wie is de eigenaar van steam?",
                "Welke gamestudio’s heeft Microsoft gekocht?"
            };
            }
        }
}
