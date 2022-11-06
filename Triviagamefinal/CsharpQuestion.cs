using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triviagamefinal
{
    public class CsharpQuestion
    {
        int index = 0;
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
        string[] cSharpAnwser =
        {
                "                                       Niks",
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

        public String AskMeQuestion()
        {
            Random randomizer = new Random();
            index = randomizer.Next(0, 9);
            return cSharpquestions[index];

        }
        public String Anwser()
        {

            return cSharpAnwser[index];
        }
        public String[] FakeAnwsers()
        {
            return cSharpAnwser;
        }
    }
}
