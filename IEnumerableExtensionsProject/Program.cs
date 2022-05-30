using System;

namespace IEnumerableExtensionsProject
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] arr = new[] {1, 2, 3, 4, 5};
            var query = arr.Where_(x => x > 3);
            foreach (var element in query)
            {
                Console.WriteLine(element);
            }


            var query1 = arr.Where_(x => x < 3).Select_(x => x + 10);
            foreach (var element in query1)
            {
                Console.WriteLine(element);
            }

            var query2 = arr.Where_(x => x < 3).Select_(x => x + 10).First_(x => x < 15);
            foreach (var element in query2)
            {
                Console.WriteLine(element);
            }
        }
    }
}