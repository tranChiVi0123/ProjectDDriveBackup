using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string test = "@ws$%x$@tb";
                int lenSub = 9;
                while (lenSub <= test.Length)
                {

                    for (int i = 0; i <= test.Length - lenSub; i++)
                    {
                        string subStr = test.Substring(i, lenSub);
                        if (checkValidPass(subStr))
                        {
                            Console.WriteLine(lenSub - 1);
                            return;
                        }

                    }
                    if (lenSub == test.Length)
                    {
                        if (checkValidPass(test))
                        {
                            Console.WriteLine(lenSub);
                            return;
                        }
                    }
                    lenSub++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static private bool checkValidPass(string sub)
        {
            // ít nhất 5 lowercase unique
            // ít nhất 1 symbol $ % @
            // Min 6

            int Len = sub.Length;
            char[] arrstr = sub.ToCharArray();
            Hashtable htb = new Hashtable();
            for (int i = 0; i < Len; i++)
            {
                if (!htb.ContainsKey(arrstr[i]))
                {
                    htb.Add(arrstr[i], 1);
                }
            }
            bool check = false;
            List<string> symbols = new List<string>();
            foreach (DictionaryEntry item in htb)
            {
                if (item.Key.Equals('$') || item.Key.Equals('%') || item.Key.Equals('@'))
                {
                    check = true;
                    symbols.Add(item.Key.ToString());
                }
            }
            foreach (string s in symbols)
            {
                htb.Remove('$');
                htb.Remove('%');
                htb.Remove('@');
            }
            if (htb.Count >= 5 && check)
            {
                return true;
            }
            return false;
        }
    }
}
