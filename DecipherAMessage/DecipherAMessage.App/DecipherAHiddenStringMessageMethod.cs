using System;
using System.Collections.Generic;
using System.Text;

namespace DecipherAMessage.App
{
    public class DecipherAHiddenStringMessageMethod : IDecipherAHiddenStringMessageMethod
    {
        public string UsingROT13ToDeciperAString(string input)
        {
            var characterDisctionaryFor13PositionChange = new Dictionary<char, char>()
            {
                {'A', 'N' },
                {'B', 'O' },
                {'C', 'P' },
                {'D', 'Q' },
                {'E', 'R' },
                {'F', 'S' },
                {'G', 'T' },
                {'H', 'U' },
                {'I', 'V' },
                {'J', 'W' },
                {'K', 'X' },
                {'L', 'Y' },
                {'M', 'Z' },
                {'N', 'A' },
                {'O', 'B' },
                {'P', 'C' },
                {'Q', 'D' },
                {'R', 'E' },
                {'S', 'F' },
                {'T', 'G' },
                {'U', 'H' },
                {'V', 'I' },
                {'W', 'J' },
                {'X', 'K' },
                {'Y', 'L' },
                {'Z', 'M' },
            };
            var newString = new StringBuilder();

            char[] characters = input.ToCharArray();

            foreach (var character in characters)
            {
                if(char.IsLetter(character))
                {
                    if(char.IsLower(character))
                    {
                        newString.Append(char.ToLower(characterDisctionaryFor13PositionChange[char.ToUpper(character)]));
                    }
                    else
                    {
                        newString.Append(characterDisctionaryFor13PositionChange[character]);
                    }                    
                }
                else
                {
                    newString.Append(character);
                }
            }
            return newString.ToString();
        }
    }
}
