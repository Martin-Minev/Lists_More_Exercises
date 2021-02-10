using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = Console.ReadLine().Split().Select(int.Parse).ToList();
            string someText = Console.ReadLine();
            List<char> text = someText.ToList();
            List<int> sumDigits = new List<int>();
            int sum = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < digits.Count; i++)
            {
                while (digits[i] > 0)
                {
                    sum += digits[i] % 10;
                    digits[i] /= 10;
                }
                sumDigits.Add(sum);
                sum = 0;
            }
            int searchedIndex = 0;
            for (int i = 0; i < sumDigits.Count; i++)
            {
                if (text.Count < sumDigits[i])
                {
                    searchedIndex = sumDigits[i] - text.Count;
                    sb.Append(text[searchedIndex]);
                    text.RemoveAt(searchedIndex);
                }
                else
                {
                    searchedIndex = sumDigits[i];
                    sb.Append(text[searchedIndex]);
                    text.RemoveAt(searchedIndex);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
