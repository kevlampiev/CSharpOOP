using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    internal class BCoder : ICoder
    {
        //объединенный алфавит
        private char[] _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZАБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧЬЫЪЭЮЯ".ToCharArray();

        private char GetOppositChar(char letter)
        {
            char c = Char.ToUpper(letter);
            bool isUpperCase = Char.IsUpper(letter);
            try
            {
                int position = _alphabet.Length - Array.IndexOf(_alphabet, c) - 1;
                if (position < 0 || position>=_alphabet.Length) 
                {
                    return c; 
                } 
                else
                {
                    return isUpperCase ? Char.ToUpper(_alphabet[position]) : Char.ToLower(_alphabet[position]);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return letter;
            }
            
        }

        public string Encode(string SourceStr)
        {
            StringBuilder result = new StringBuilder(SourceStr.Length);
            foreach (char c in SourceStr.ToCharArray())
            {
                result.Append(GetOppositChar(c));
            }
            return result.ToString();
        }

        public string Decode(string SourceStr)
        {
            return this.Encode(SourceStr);
        }
    }
}