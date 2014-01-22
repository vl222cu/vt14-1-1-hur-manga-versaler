using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1dv406_1_1.Model
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text) 
        {
            int onlyUpperCase = 0;

            foreach(char c in text)
            {
                onlyUpperCase++;
            }
            return onlyUpperCase;
        }
    }
}