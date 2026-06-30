using System;
using System.Collections.Generic;
using System.Text;

namespace ITCourse.MyLinq
{
    public static class MyLinq
    {
        // WHERE
        public static IEnumerable<T> Where<T>(
            IEnumerable<T> source,
            Func<T, bool> predicate)
        {
            List<T> filteredItems = new List<T>();

            foreach (T currentItem in source)
            {
                if (predicate(currentItem))
                {
                    filteredItems.Add(currentItem);
                }
            }

            return filteredItems;
        }

        // ORDER BY (Ascending)
        public static IEnumerable<T> OrderBy<T>(
            IEnumerable<T> source)
            where T : IComparable<T>
        {
            List<T> sortedItems = new List<T>();

            foreach (T currentItem in source)
            {
                sortedItems.Add(currentItem);
            }

            for (int i = 0; i < sortedItems.Count - 1; i++)
            {
                for (int j = i + 1; j < sortedItems.Count; j++)
                {
                    if (sortedItems[i].CompareTo(sortedItems[j]) > 0)
                    {
                        T temporaryValue = sortedItems[i];
                        sortedItems[i] = sortedItems[j];
                        sortedItems[j] = temporaryValue;
                    }
                }
            }

            return sortedItems;
        }

        // FIRST
        public static T First<T>(
            IEnumerable<T> source,
            Func<T, bool> predicate)
        {
            foreach (T currentItem in source)
            {
                if (predicate(currentItem))
                {
                    return currentItem;
                }
            }

            throw new Exception("Element was not found.");
        }

        // FIRST OR DEFAULT
        public static T FirstOrDefault<T>(
            IEnumerable<T> source,
            Func<T, bool> predicate)
        {
            foreach (T currentItem in source)
            {
                if (predicate(currentItem))
                {
                    return currentItem;
                }
            }

            return default(T);
        }

        // SINGLE
        public static T Single<T>(
            IEnumerable<T> source,
            Func<T, bool> predicate)
        {
            int matchingElementsCount = 0;
            T foundElement = default(T);

            foreach (T currentItem in source)
            {
                if (predicate(currentItem))
                {
                    matchingElementsCount++;
                    foundElement = currentItem;
                }
            }

            if (matchingElementsCount == 1)
            {
                return foundElement;
            }

            throw new Exception(
                "No element or more than one element satisfies the condition.");
        }

        // SINGLE OR DEFAULT
        public static T SingleOrDefault<T>(
            IEnumerable<T> source,
            Func<T, bool> predicate)
        {
            int matchingElementsCount = 0;
            T foundElement = default(T);

            foreach (T currentItem in source)
            {
                if (predicate(currentItem))
                {
                    matchingElementsCount++;
                    foundElement = currentItem;
                }
            }

            if (matchingElementsCount == 0)
            {
                return default(T);
            }

            if (matchingElementsCount == 1)
            {
                return foundElement;
            }

            throw new Exception(
                "More than one element satisfies the condition.");
        }

        // ANY
        public static bool Any<T>(
            IEnumerable<T> source,
            Func<T, bool> predicate)
        {
            foreach (T currentItem in source)
            {
                if (predicate(currentItem))
                {
                    return true;
                }
            }

            return false;
        }

        // ALL
        public static bool All<T>(
            IEnumerable<T> source,
            Func<T, bool> predicate)
        {
            foreach (T currentItem in source)
            {
                if (!predicate(currentItem))
                {
                    return false;
                }
            }

            return true;
        }

        // COUNT
        public static int Count<T>(
            IEnumerable<T> source,
            Func<T, bool> predicate)
        {
            int matchingElementsCount = 0;

            foreach (T currentItem in source)
            {
                if (predicate(currentItem))
                {
                    matchingElementsCount++;
                }
            }

            return matchingElementsCount;
        }

        // COUNT (all elements)
        public static int Count<T>(
            IEnumerable<T> source)
        {
            int totalElementsCount = 0;

            foreach (T currentItem in source)
            {
                totalElementsCount++;
            }

            return totalElementsCount;
        }

        // DISTINCT
        public static IEnumerable<T> Distinct<T>(
            IEnumerable<T> source)
        {
            List<T> uniqueItems = new List<T>();

            foreach (T currentItem in source)
            {
                bool elementExists = false;

                foreach (T uniqueItem in uniqueItems)
                {
                    if (uniqueItem.Equals(currentItem))
                    {
                        elementExists = true;
                        break;
                    }
                }

                if (!elementExists)
                {
                    uniqueItems.Add(currentItem);
                }
            }

            return uniqueItems;
        }
    }
}
