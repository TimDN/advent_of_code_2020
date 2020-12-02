using Helper;
using System;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //form 1-3 a: abcde
            var inputs = Input.InputToList();
            CheckInput(inputs, true);
            CheckInput(inputs, false);
        }

        static void CheckInput(List<string> inputs, bool oldRule)
        {
            var validPassword = 0;
            foreach (var input in inputs)
            {
                var parts = input.Split(":");
                var rule = GetPasswordRule(oldRule, parts[0]);
                var password = parts[1].Trim();
                if (rule.PasswordFollowsRule(password))
                {
                    validPassword++;
                }
            }
            Console.WriteLine(validPassword);
        }

        static IPasswordRule GetPasswordRule(bool old, string ruleInput)
        {
            if (old)
            {
                return new Rule(ruleInput);
            }
            else
            {
                return new PositionRule(ruleInput);
            }
        }
    }
}
