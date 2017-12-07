using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordCounter.Models
{
    public class WordCountModel
    {
        public static int WordCount(string inputString)
        {
            string[] textMass;
            string text = inputString.Replace('\n', ' ');
            textMass = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int res = textMass.Length;
            if (textMass[textMass.Length - 1] == "")
            {
                res = res - 1;
            }

            return res;
        }

        public static int CurWordCount(string inputString, string CurWord)
        {
            string[] textMass;
            string text = inputString.Replace('\n', ' ');
            text = text.Replace('\r', ' ');
            textMass = text.Split(new char[] { ' ' });
            int res = 0;
            for (int i = 0; i < textMass.Length; ++i)
            {
                if (textMass[i] == CurWord)
                {
                    res = res + 1;
                }
            }

            return res;
        }
    }
}