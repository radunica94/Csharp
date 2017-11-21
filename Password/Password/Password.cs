using System;
using System.Collections.Generic;
using System.Text;

namespace Password
{
    class Password
    {
        public struct PasswordSettings
        {
            public int smallLetters, capitalLetters, digits, symbols;
            public bool noSimilarCharacters, noAmbiguousChars;
            public PasswordSettings(int a, int b, int c, int d, bool similar, bool ambiguous)
            {
                this.smallLetters = a;
                this.capitalLetters = b;
                this.digits = c;
                this.symbols = d;
                this.noSimilarCharacters = similar;
                this.noAmbiguousChars = ambiguous;
            }
        }

        
    }
}
