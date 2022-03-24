using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions1
{
    internal static class Extensions
    {
        public static string CapitaliseString(this string text)
        {
            StringBuilder stringbuilder = new StringBuilder(text);
            stringbuilder[0] = Char.ToUpper(stringbuilder[0]);
            return text = stringbuilder.ToString();
        }
        public static string ReverseMethod(this string text)
        {
            if (text.Length <= 1)
            {
                return text;
            }

            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static string IndexReturn(this string text, int index )
        {
            index = text.Length - 1;
            return index.ToString();
        }

            public static T[] Append<T>(this T[] array, T item)
            {
                return new List<T>(array) { item }.ToArray();



            } 
    }   

    }

