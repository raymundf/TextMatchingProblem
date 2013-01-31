using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextMatch
{
    public interface ITextMatch
    {
        int[] FindMatchedPositions(string text, string subtext);
    }
}
