using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1dv406_1_1.Model
{
    public static class TextAnalyzer
    {
        // Metod som returnerar antalet versaler som finns i strängen
        public static int GetNumberOfCapitals(string text) 
        {
            int onlyUpperCase = 0;

            foreach(char c in text)
            {
                if (Char.IsUpper(c)) 
                {
                    onlyUpperCase++;
                }
            }
            return onlyUpperCase;
        }
    }
}