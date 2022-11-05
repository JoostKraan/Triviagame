using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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

            switch (bTomain)
            {
                case 1:
                    Console.Clear();
                    NLQuestions();
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Put Data Here");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Put Data Here");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Put Data Here");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    Program.Menu();
                    break;


            }





        }


        public static void NLQuestions()
        {
            string[] cSharpquestions = //C# related Questions
                 
            {
                "                                       Wat doet een void",
                "                                       Hoe zorg je ervoor dat een regel code niet gelezen word door de compiler?",
                "                                       Welke symbolen gebruik je voor het aangeven van een string?",
                "                                       Hoe roep je een Method op?",
                "                                       Wat is de maximale waarde die in een int past",
                "                                       welke waardes kan een bool hebben?",
                "                                       Waar gebruik je Console.ReadLine(); voor?",
                "                                       Hoe stop je een Loop?",
                "                                       met welke tekens kun je een bepaald aantal regels commenten?",
                "                                       Wat doet de eerste waarde van een Console.Beep?"
            };
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
            Random random = new Random();

            int index = random.Next(0, cSharpquestions.Length);
            Console.WriteLine(cSharpquestions[index]);
            switch (index)
            {
                case 0:
                    Console.WriteLine("");
                    Console.WriteLine("                                     A: Het zorgt ervoor dat een method niks uitvoert.");
                    Console.WriteLine("                                     B: Het zorgts ervoor dat de method geen waarde terug geeft.");
                    Console.WriteLine("                                     C: Je kan de Method dan niet oproepen in ander methods.");
                    Console.WriteLine("");
                    Console.WriteLine("                                     4) Back...");

                    int answer0 = char.Parse(Console.ReadLine());
                    if (answer0 == 'a')
                    {
                        Console.WriteLine("Wrong");
                    }
                    else if (answer0 == 'b')
                    {

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(60, 10);
                        Console.WriteLine("Correct");
                        Console.ResetColor();



                    }
                    else if (answer0 == 'c')
                    {
                        Console.WriteLine("Wrong");

                    }

                    int backopt = int.Parse(Console.ReadLine());
                    if (backopt == 4)
                    {

                        newGame.Start();
                    }

                    break;
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("                                     A: Met 3 hoge punten (''') ");
                    Console.WriteLine("                                     B: Met /* ");
                    Console.WriteLine("                                     C: Met // ");
                    Console.WriteLine("");
                    Console.WriteLine("                                     4) Back... ");
                    int backopt1 = int.Parse(Console.ReadLine());
                    if (backopt1 == 4)
                    {
                        newGame.Start();
                    }
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("                                     A: \"");
                    Console.WriteLine("                                     B: '");
                    Console.WriteLine("                                     C: *");
                    Console.WriteLine("");
                    Console.WriteLine("                                     4) Back... ");
                    int backopt2 = int.Parse(Console.ReadLine());
                    if (backopt2 == 4)
                    {
                        newGame.Start();
                    }
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("                                     A: Method{};");
                    Console.WriteLine("                                     B: Method[];");
                    Console.WriteLine("                                     C: Method();");
                    Console.WriteLine("");
                    Console.WriteLine("                                     4) Back...");
                    int backopt3 = int.Parse(Console.ReadLine());
                    if (backopt3 == 4)
                    {
                        newGame.Start();
                    }
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("                                     A: 17976931348623");
                    Console.WriteLine("                                     B: 2147483647");
                    Console.WriteLine("                                     C: 222507385850");
                    Console.WriteLine("");
                    Console.WriteLine("                                     4) Back...");
                    int backopt4 = int.Parse(Console.ReadLine());
                    if (backopt4 == 4)
                    {
                        newGame.Start();
                    }
                    break;
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("                                     A: True/False");
                    Console.WriteLine("                                     B: 0/1");
                    Console.WriteLine("                                     C: Y/N");
                    Console.WriteLine("");
                    Console.WriteLine("                                     4) Back...");
                    int backopt5 = int.Parse(Console.ReadLine());
                    if (backopt5 == 4)
                    {
                        newGame.Start();
                    }
                    break;
                case 6:
                    Console.WriteLine("");
                    Console.WriteLine("                                     A: Voor het lezen van de vorige regel in console");
                    Console.WriteLine("                                     B: Voor het lezen van de user nput");
                    Console.WriteLine("                                     C: Voor het lezen van een string");
                    Console.WriteLine("");
                    Console.WriteLine("                                     4) Back...");
                    int backopt6 = int.Parse(Console.ReadLine());
                    if (backopt6 == 4)
                    {
                        newGame.Start();
                    }
                    break;
                case 7:
                    Console.WriteLine("");
                    Console.WriteLine("                                     A: Stop;");
                    Console.WriteLine("                                     B: pause;");
                    Console.WriteLine("                                     C: break;");
                    Console.WriteLine("");
                    Console.WriteLine("                                     4) Back...");
                    int backopt7 = int.Parse(Console.ReadLine());
                    if (backopt7 == 4)
                    {
                        newGame.Start();
                    }
                    break;
                case 8:
                    Console.WriteLine("");
                    Console.WriteLine("                                     A: /// ");
                    Console.WriteLine("                                     B: /* ");
                    Console.WriteLine("                                     C: ** ");
                    Console.WriteLine("");
                    Console.WriteLine("                                     4) Back");
                    int backopt8 = int.Parse(Console.ReadLine());
                    if (backopt8 == 4)
                    {
                        newGame.Start();
                    }
                    break;
                case 9:
                    Console.WriteLine("");
                    Console.WriteLine("                                     A: Bepaald de snelheid van de toon in miliseconden");
                    Console.WriteLine("                                     B: bepaald de frequentie");
                    Console.WriteLine("                                     C: Bepaald de pitch");
                    Console.WriteLine("");
                    Console.WriteLine("                                     4) Back...");
                    int backopt9 = int.Parse(Console.ReadLine());
                    if (backopt9 == 4)
                    {
                        newGame.Start();
                    }
                    break;















            }
        }


    }
}
