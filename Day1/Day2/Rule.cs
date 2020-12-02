using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Rule
    {
        public Rule(string input)
        {
            //1-3 a
            var parts = input.Split(" ");
            ExpectedCharacter = char.Parse(parts[1]);
            SetMinMaxCount(parts);
        }
        public int MinCount { get; private set; }
        public int MaxCount { get; private set; }
        public char ExpectedCharacter { get; private set; }

        private void SetMinMaxCount(string[] parts)
        {
            var counts = parts[0].Split("-");
            MinCount = int.Parse(counts[0]);
            MaxCount = int.Parse(counts[1]);
        }
    }
}
