using System;
using System.Linq;
using System.Text;

namespace Codewars.YourOrderPlease.Tests
{
    internal class Kata
    {
        static int getOrder(string text)
        {
            var foundNumber = text
                .Single(x => int.TryParse(x.ToString(), out var result));

            return int.Parse(foundNumber.ToString());
        }

        internal static string Order(string text)
        {

            //if (string.IsNullOrEmpty(text))
            //{
            //    return string.Empty;
            //}

            //var sortedItems = text
            //    .Split(" ")
            //    .OrderBy(item => getOrder(item));

            //return string.Join(' ', sortedItems);

            var orderedText = new StringBuilder();
            // returns empty string
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            // split the text  to get the separate parts
            var listOfStrings = text.Split(" ");
            //var values = Enumerable
            //    .Range(1, listOfStrings.Length)
            //    .Select(index =>
            //    {
            //        return listOfStrings.Single(x => x.Contains(index.ToString()));
            //    });

            //return string.Join(" ", values);


            // get the number within the parts
            for (int i = 1; i <= listOfStrings.Length; i++)
            {
                var number = i.ToString();
                var item = listOfStrings.Single(x => x.Contains(number));
                orderedText.Append(' ' + item);
            }

            // returns text in correct order
            return orderedText.ToString().Trim();
        }
    }
}