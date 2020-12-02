using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Rule : IPasswordRule
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

        public bool PasswordFollowsRule(string password)
        {
            var characterCount = 0;
            foreach (var character in password)
            {
                if (character == ExpectedCharacter)
                {
                    characterCount++;
                }
            }
            return characterCount >= MinCount && characterCount <= MaxCount;
        }

        private void SetMinMaxCount(string[] parts)
        {
            var counts = parts[0].Split("-");
            MinCount = int.Parse(counts[0]);
            MaxCount = int.Parse(counts[1]);
        }
    }
}
