using System;
using System.Collections.Generic;
using Utils;

namespace Demo2d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Maximum length of string to include? ");
            int maxLength = int.Parse(Console.ReadLine());

            // ----- PREDICATE -----

            Utils.Predicate<string> predicate = item => item.Length <= maxLength;

            // ----- PREDICATE -----

            IList<string> shortWords = ListUtil.Filter(SampleData.Words, predicate);
            ListUtil.Dump(shortWords);

            Console.WriteLine("Now for words with <= 5 letters:");

            maxLength = 5;
            shortWords = ListUtil.Filter(SampleData.Words, predicate);
            ListUtil.Dump(shortWords);
        }
    }
}
