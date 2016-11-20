using System;
using System.Collections.Generic;
using Utils;

namespace Demo2c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Minimum length of string to include? ");
            int minLength = int.Parse(Console.ReadLine());

            Console.Write("Maximum length of string to include? ");
            int maxLength = int.Parse(Console.ReadLine());

            // ----- PREDICATE -----

            Utils.Predicate<string> minLengthPredicate = item => minLength <= item.Length;
            Utils.Predicate<string> maxLengthPredicate = item => item.Length <= maxLength;
            Utils.Predicate<string> lengthPredicate = ListUtil.and(minLengthPredicate, maxLengthPredicate);

            // ----- PREDICATE -----

            IList<string> shortWords = ListUtil.Filter(SampleData.Words, lengthPredicate);
            ListUtil.Dump(shortWords);
        }
    }
}
