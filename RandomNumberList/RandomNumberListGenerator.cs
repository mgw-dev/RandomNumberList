using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberList
{
    public static class RandomNumberListGenerator
    {
        private static Random random = new Random();

        /// <summary>
        /// Get list of unique integers in provided range (inclusive)
        /// </summary>
        /// <returns></
        /// returns>
        public static List<int> GetRandomList(int x, int y)
        {
            // Determine which provided value is higher or lower.
            int lower = x < y ? x : y;
            int upper = y > x ? y : x;

            // Create the list. This ensures that there are no duplicate values.
            List<int> list = new List<int>();
            for (int i = lower; i <= upper; i++)
            {
                list.Add(i);
            }

            // Then, scramble the list.
            list.Scramble();

            // Return scrambled list.
            return list;
        } 

        /// <summary>
        /// Steps through the list and swaps every element with one random other element, with a cance to not swap values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private static void Scramble<T>(this List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int r = random.Next(-1, list.Count - 1);
                
                if (r != -1)
                {
                    list.Swap(i, r);
                }
                    
            }
        }

        /// <summary>
        /// Swap two elements in a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private static void Swap<T>(this List<T> l, int x, int y)
        {
            T tmp = l[x];
            l[x] = l[y];
            l[y] = tmp;
        }
    }
}
