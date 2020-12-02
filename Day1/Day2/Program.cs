using Helper;
using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //form 1-3 a: abcde
            var inputs = Input.InputToList();

            var validPassword = 0;
            foreach(var input in inputs)
            {
                var parts = input.Split(":");
                var rule = new Rule(parts[0]);
                var password = parts[1].Trim();
                var characterCount = 0;
                foreach(var character in password)
                {
                    if(character == rule.ExpectedCharacter)
                    {
                        characterCount++;
                    }
                }
                if(characterCount >= rule.MinCount && characterCount <= rule.MaxCount)
                {
                    validPassword++;
                }
            }
            Console.WriteLine(validPassword);
        }
    }
}
