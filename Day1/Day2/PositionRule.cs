using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class PositionRule : IPasswordRule
    {
        public PositionRule(string input)
        {
            //1-3 a
            var parts = input.Split(" ");
            ExpectedCharacter = char.Parse(parts[1]);
            SetPositions(parts);
        }

        public int PositionOne { get; private set; }
        public int PositionTwo { get; private set; }
        public char ExpectedCharacter { get; private set; }

        public bool PasswordFollowsRule(string password)
        {
            var firstChar = password[PositionOne];
            var secondChar = password[PositionTwo];
            if (firstChar != secondChar)
            {
                if(firstChar == ExpectedCharacter || secondChar == ExpectedCharacter)
                {
                    return true;
                }
            }
            return false;
        }

        private void SetPositions(string[] parts)
        {
            var counts = parts[0].Split("-");
            PositionOne = ConvertTo0BaseIndex(counts[0]);
            PositionTwo = ConvertTo0BaseIndex(counts[1]);
        }

        private static int ConvertTo0BaseIndex(string counts)
        {
            return int.Parse(counts) - 1;
        }
    }
}
