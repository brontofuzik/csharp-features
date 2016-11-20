using System;
using System.Collections.Generic;

namespace Utils
{
    public delegate bool Predicate<T>(T obj);

    public delegate Predicate<T> UnaryCombinator<T>(Predicate<T> predicate); 

    public delegate Predicate<T> BinaryCombinator<T>(Predicate<T> predicate1, Predicate<T> predicate);

    public static class ListUtil
    {
        public static UnaryCombinator<string> not = (predicate) =>
            (item) => !predicate(item);

        public static BinaryCombinator<string> and = (predicate1, predicate2) =>
            (item) => predicate1(item) && predicate2(item);

        public static BinaryCombinator<string> or = (predicate1, predicate2) =>
            (item) => predicate1(item) || predicate2(item);

        public static IList<T> Filter<T>(IList<T> source, Predicate<T> predicate)
        {
            IList<T> result = new List<T>();
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static void Dump<T>(IList<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
