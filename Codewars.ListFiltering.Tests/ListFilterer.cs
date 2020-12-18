using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars.ListFiltering.Tests
{
    internal class ListFilterer
    {
        internal static List<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>().ToList();
            
            //var list = new List<int>();

            //var items = 
            //list.AddRange(items);

            //listOfItems.ForEach(item =>
            //{
            //    if (item is int number)
            //    {
            //        list.Add(number);
            //    }
            //});

            //return list;
        }
    }
}