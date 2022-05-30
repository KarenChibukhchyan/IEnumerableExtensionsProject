using System;
using System.Collections.Generic;

namespace IEnumerableExtensionsProject
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Where_<T>(this IEnumerable<T> source, Func<T, bool> func)
        {
            foreach (var element in source)
            {
                if (func(element))
                    yield return element;
            }
        }

        public static IEnumerable<T> Select_<T>(this IEnumerable<T> source, Func<T, T> func)
        {
            foreach (var element in source)
            {
                yield return func(element);
            }
        }

        public static IEnumerable<T> First_<T>(this IEnumerable<T> source, Func<T, bool> func)
        {
            if (func == null)
            {
                foreach (var element in source)
                {
                    yield return element;
                    yield break;
                }
            }
            else
            {
                foreach (var element in source)
                {
                    if (func(element))
                        yield return element;
                }
            }
        }
    }
}
