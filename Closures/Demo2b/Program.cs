using System;
using System.Collections.Generic;
using Utils;

namespace Demo2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Maximum length of string to include? ");
            int maxLength = int.Parse(Console.ReadLine());

            // ----- PREDICATE -----

            Utils.Predicate<string> predicate = delegate(string item)
            {
                return item.Length <= maxLength;
            };

            // ----- PREDICATE -----

            IList<string> shortWords = ListUtil.Filter(SampleData.Words, predicate);
            ListUtil.Dump(shortWords);
        }
    }
}
