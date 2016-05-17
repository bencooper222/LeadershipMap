﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LeadershipMap
{
    class Parser
    {
        private string txtFileLocation;
        public Parser(string textFileLocation)
        {
            this.txtFileLocation = textFileLocation;
        }

        static Parser()
        {

        }

        /// <summary>
        /// Return a specific line number of the text file
        /// </summary>
        /// <param name="lineNumber"></param>
        /// <returns></returns>
        public string GetRow(int lineNumber)
        {
            return File.ReadLines(txtFileLocation).Skip(lineNumber - 1).Take(1).First();
        }

        /// <summary>
        /// Gets the n-1th element in a line
        /// </summary>
        /// <param name="elementIndex">Follows standard indexing conventions. "0" will return first element</param>
        /// <param name="lineNumber"></param>
        /// <returns></returns>
        public string GetElementFromRowIndex(int elementIndex, int lineNumber)
        {
            string[] line = GetRow(lineNumber).Split(new char[',']);

            return line[elementIndex];
        }

        public string GetElementFromRowText(int elementIndex, string row)
        {
            string[] line = row.Split(new char[] { ',' });

            return line[elementIndex];
        }

        public string[] GetArrayOfElements(string row)
        {
            return row.Split(new char[] { ',' }); 
        }

        public int CountLines()
        {
            return File.ReadLines(txtFileLocation).Count();
        }
    }
}