using System;
using System.Collections.Generic;
using System.IO;

#pragma warning disable CA1062

namespace WorkingWithStreams
{
    public static class ReadingFromString
    {
        public static string ReadAllStreamContent(StringReader stringReader)
        {
            return stringReader.ReadToEnd();
        }

        public static string ReadCurrentLine(StringReader stringReader)
        {
            return stringReader.ReadLine();
        }

        public static bool ReadNextCharacter(StringReader stringReader, out char currentChar)
        {
            int temp;
            if ((temp = stringReader.Read()) > -1)
            {
                currentChar = (char)temp;
                return true;
            }
            else
            {
                currentChar = ' ';
                return false;
            }
        }

        public static bool PeekNextCharacter(StringReader stringReader, out char currentChar)
        {
            int temp;
            if ((temp = stringReader.Peek()) > -1)
            {
                currentChar = (char)temp;
                return true;
            }
            else
            {
                currentChar = ' ';
                return false;
            }
        }

        public static char[] ReadCharactersToBuffer(StringReader stringReader, int count)
        {
            char[] arr = new char[count];
            stringReader.Read(arr, 0, count);
            return arr;
        }
    }
}
