using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var oddNumber = GetOddNumber(100);
            foreach (var item in oddNumber)
            {
                Console.WriteLine(item);
            }
            var EvenNumber = GetEvenNumber(100);
            foreach (var item in EvenNumber)
            {
                Console.WriteLine(item);
            }
        }


        public static IEnumerable<int> GetOddNumber(int count)
        {
            for (int i = 0; i <= count; i++)
            {
                if (i % 2 == 1)
                    yield return i;
            }
        }
        public static IEnumerable<int> GetEvenNumber(int count)
        {
            for (int i = 0; i <= count; i++)
            {
                if (i % 2 == 0)
                    yield return i;
            }
        }

    }
}
