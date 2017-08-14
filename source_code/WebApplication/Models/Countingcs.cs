using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Countingcs
    {
        public Hashtable table = new Hashtable();

        public string Countwords(string value)
        {
            string result = String.Empty;
            char[] delims = { ',', ' ', '.', '?', ';', '!', '"', '\'' };
            string[] words = value.Trim().Split(delims, StringSplitOptions.RemoveEmptyEntries);

            // add words to Hashtable
            foreach (string next in words)
            {
                if (table[next] == null)
                    table[next] = 1;
                else
                {
                    int n = (int)table[next];
                    table[next] = n + 1;
                }

            }

            foreach (DictionaryEntry e in table)
            {
                result += e.Key.ToString();
                if (Convert.ToInt32(e.Value) > 1)
                {
                    result += " ( " + e.Value.ToString() + " ) <br/> ";
                }
                else
                {
                    result += "<br/>";
                }
            }

            return result;

        }

    }
}