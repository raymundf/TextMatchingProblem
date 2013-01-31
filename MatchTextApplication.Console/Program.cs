using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextMatch.Implementations;

namespace TextMatchApplication.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleMatchText = new SimpleTextMatch();

            System.Console.WriteLine(String.Join(",", 
                simpleMatchText.FindMatchedPositions(
                "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea",
                "ll")));

            System.Console.ReadKey();
        }
    }
}
