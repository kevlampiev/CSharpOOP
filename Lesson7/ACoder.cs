using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    internal class ACoder : ICoder
    {
        private string Shift(string SourceStr, int step) 
        {
            StringBuilder Output = new StringBuilder(SourceStr.Length);
            foreach (char c in SourceStr)
            {
                Output.Append(Convert.ToChar(c + step));
            }
            return Output.ToString();
        }

        public string Encode(string SourceStr)
        {
            return Shift(SourceStr, 1);
        }

        public string Decode(string SourceStr)
        {
            return Shift(SourceStr, -1);
        }
    }
}
