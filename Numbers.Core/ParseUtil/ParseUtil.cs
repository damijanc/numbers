using System;
using System.Collections.Generic;

namespace CAXperts.Core.ParseUtil
{
    public class ParseUtil : IParseUtil
    {
        private List<int> numbers = new List<int>();

        public List<int> Parse(List<String> lines)
        {

            char[] charSeparators = new char[] { ' ' };

            //check if the number of lines are %4
            if (lines.Count % 4 != 0)
            {
                throw new Exception("Incorrrect number of lines. Please check the input file.");
            }

            int current = 1;
            while (current < lines.Count)
            {
                //take the second line
                String line = lines[current];
                //clean up line
                line = line.Replace("\t", " ");
                //extract the chars
                String[] characters = line.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                //compare it with number patterns
                Compare(characters);
                //go to the next line
                current = current + 4;
            }

            return this.numbers;
        }

        private void Compare(String[] characters)
        {
            //check for  /     _|    |  |___|	|___
            foreach (string pattern in characters)
            {
                switch (pattern)
                {
                    case "/":
                        this.numbers.Add(3);
                        break;
                    case "_|":
                        this.numbers.Add(2);
                        break;
                    case "|":
                        this.numbers.Add(1);
                        break;
                    case "|___|":
                        this.numbers.Add(4);
                        break;
                    case "|___":
                        this.numbers.Add(5);
                        break;
                    default:
                        throw new Exception("Unknown character.");
                }
            }
        }
    }
}
