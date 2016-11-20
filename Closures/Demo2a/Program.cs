using System;
using System.Collections.Generic;
using Utils;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Maximum length of string to include? ");
            int maxLength = int.Parse(Console.ReadLine());

            // ----- PREDICATE -----

            VariableLengthMatcher matcher = new VariableLengthMatcher(maxLength);
            Utils.Predicate<string> predicate = matcher.Match;

            // ----- PREDICATE -----
            
            IList<string> shortWords = ListUtil.Filter(SampleData.Words, predicate);
            ListUtil.Dump(shortWords);
        }
    }
}
