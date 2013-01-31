using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextMatch.Implementations
{
    public class SimpleTextMatch : ITextMatch
    {
        public int[] FindMatchedPositions(string text, string subtext)
        {
            var loweredText = text.ToLower();
            var loweredSubText = subtext.ToLower();
            var matchedStartPositions = new List<int>();

            for(var x = 0; x < text.Length; x++)
            {
                if(loweredText[x] != loweredSubText[0]) 
                    continue;

                for (var a = 0; a < loweredSubText.Length && (x + a) < loweredText.Length; a++)
                {
                    if (loweredText[x + a] != loweredSubText[a])
                        break;

                    if (a == loweredSubText.Length - 1)
                        matchedStartPositions.Add(x + 1);
                }
            }

            return matchedStartPositions.ToArray();
        }


    }
}
