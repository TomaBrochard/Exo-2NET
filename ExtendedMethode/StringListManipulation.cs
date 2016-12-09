using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedMethode
{
    static class StringListManipulation
    {
        public static List<string> SortByLastLetter(this List<string> stringList)
        {
            List<string> reversedString = reverseListString(stringList);
            reversedString.Sort();
            List<string> sortededString = reverseListString(reversedString);
            return sortededString;
        }

        private static List<string> reverseListString(List<string> stringList)
        {
            List<string> reversedString = new List<string>();

            foreach (string item in stringList)
            {
                char[] charArray = item.ToCharArray();
                Array.Reverse(charArray);
                reversedString.Add(new string(charArray));
            }
            return reversedString;
        }
    }
}
