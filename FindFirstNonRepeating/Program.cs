using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFirstNonRepeating
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: FindFirstNonRepeating {string} -> writes character to console." );
            }
            var stringIn = args[0];
             var stringChars = stringIn.ToList();
            HashSet<char> hashSet=new HashSet<char>(stringChars);
            if (hashSet.Count == stringChars.Count)
            {
                Console.WriteLine("First Non-repeating char: "+hashSet.First());
                return;
            }
            IDictionary<char,int> strDictionary=new Dictionary<char, int>(hashSet.Count);
            foreach (var c in hashSet)
            {
                var cCount = stringChars.Count(s => s == c);
                strDictionary.Add(c,cCount);
            }

            var firstOne = strDictionary.First(s => s.Value == 1).Key;
            Console.WriteLine("First Non-repeating char: " + firstOne);
        }
    }
}
