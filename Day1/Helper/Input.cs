using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Helper
{
    public static class Input
    {
        public static List<string> InputToList(string fileName = "input.txt")
        {
            if(!(File.Exists(fileName)))
            {
                throw new Exception("No input file found");
            }
            return File.ReadAllLines(fileName).ToList();
        }
    }
}
