using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    public interface ICoder
    {
        string Encode(string SourceStr);
        string Decode(string SourceStr);
    }
}
