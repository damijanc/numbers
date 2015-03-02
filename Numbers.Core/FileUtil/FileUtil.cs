using System;
using System.Collections.Generic;
using System.IO;

namespace CAXperts.Core.FileUtil
{
    public class FileUtil : IFileUtil
    {
        public List<String> Read(string path)
        {

            List<string> lines = new List<String>();

            //open the file and read all the lines
            foreach (String line in File.ReadLines(@path))
            {
                lines.Add(line);
            }

            //return it
            return lines;
        }
    }
}
