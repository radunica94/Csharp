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
                smallLetters = a;
                capitalLetters = b;
                digits = c;
                symbols = d;
                noSimilarCharacters = similar;
                noAmbiguousChars = ambiguous;
            }
        }

        public char[] GeneratePassword(PasswordSettings settings, int passwordLength)
        {
            Random random = new Random();
            char[] finalPassword = new char[passwordLength];
            var chars = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < finalPassword.Length; i++)
            {
                finalPassword[i] = chars[random.Next(chars.Length)];
            }
            return finalPassword;
        }

        public bool CheckPassword(char[] password)
        {
            for (int i = 0; i < password.Length; i++)
                if (password[i] >= 'a' && password[i] <= 'z')
                    return true;
            return false;

        }
    }
}
