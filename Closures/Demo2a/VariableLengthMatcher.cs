using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo2
{
    public class VariableLengthMatcher
    {
        private int maxLength;

        public VariableLengthMatcher(int maxLength)
        {
            this.maxLength = maxLength;
        }

        public bool Match(string item)
        {
            return item.Length <= maxLength;
        }
    }
}
