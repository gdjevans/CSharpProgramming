﻿using System.Collections.Generic;

namespace Searches
{
    class Program
    {
        static int linearSearches(List<int> elements, int x)
        {
            int length = elements.Count;
            for(int i = 0; i < length; i++)
            {
                if(elements[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        static int binarySearches(List<int> elements, int x)
        {
            int start = 0;
            int stop = elements.Count - 1;
            int middle = (int)((start + stop) / 2);
            while (elements[middle] != x && start < stop)
            {
                if(x < elements[middle])
                {
                    stop = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }

                middle = (int)((start + stop) / 2);
            }

            return (elements[middle] != x) ? -1 : middle;
        }
    }
}
